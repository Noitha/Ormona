using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Ormona.Planets.Meshes;
using Ormona.Scripts;
using UnityEngine;
using UnityEngine.Rendering;
using Object = UnityEngine.Object;

namespace Ormona.Planets.Scripts
{
    [Serializable]
    public class Chunk
    {
        #region Variables
        
        /// <summary>
        /// Id of the chunk as world-position.
        /// </summary>
        public Vector3Int WorldPosition { get; }

        /// <summary>
        /// Container for the entities of the chunk.
        /// </summary>
        public ChunkEntity[,,] data;
        
        /// <summary>
        /// References the scene-object.
        /// </summary>
        private GameObject SceneReferenceObject { get; }

        /// <summary>
        /// Was this chunk modified since last save.
        /// </summary>
        public bool modifiedSinceLastSave;
        
        /// <summary>
        /// To which planet does this Chunk belong.
        /// </summary>
        private Planet Planet { get; set; }

        /*
        /// <summary>
        /// Is the chunk fully loaded. Visible and collider set.
        /// </summary>
        public bool loaded;*/

        /// <summary>
        /// Have the trees already been created for this chunk.
        /// </summary>
        public bool TreesCreated { get; private set; }
        
        //Readonly variables of the neighbour-positions
        public readonly Vector3Int leftChunkPosition;
        public readonly Vector3Int rightChunkPosition;
        public readonly Vector3Int bottomChunkPosition;
        public readonly Vector3Int topChunkPosition;
        public readonly Vector3Int backChunkPosition;
        public readonly Vector3Int frontChunkPosition;
        
        /// <summary>
        /// Holds the references of the scene-objects of each entity-group. 
        /// </summary>
        public readonly Dictionary<string, EntityGroup> entityGroupSceneReference;

        /// <summary>
        /// Distinct names of the entities in the chunk.
        /// </summary>
        private readonly HashSet<int> _entityGroups;
        #endregion

        /// <summary>
        /// Chunk constructor
        /// </summary>
        /// <param name="planet"></param>
        /// <param name="worldPosition"></param>
        /// <param name="sceneReferenceObject"></param>
        public Chunk(in Planet planet, in Vector3Int worldPosition, in GameObject sceneReferenceObject)
        {
            //Set the planet it belongs to.
            Planet = planet;
            
            //Set the world-position of the chunk. 
            WorldPosition = worldPosition;
            
            //Set neighbour chunks positions
            leftChunkPosition = WorldPosition + new Vector3Int(-8, 0, 0);
            rightChunkPosition = WorldPosition + new Vector3Int(8, 0, 0);
            bottomChunkPosition = WorldPosition + new Vector3Int(0, -4, 0);
            topChunkPosition = WorldPosition + new Vector3Int(0, 4, 0);
            backChunkPosition = WorldPosition + new Vector3Int(0, 0, -8);
            frontChunkPosition = WorldPosition + new Vector3Int(0, 0, 8);
            
            //Set the scene-reference-object of the chunk.
            SceneReferenceObject = sceneReferenceObject;

            //Set modifiedSinceLastSave to false.
            modifiedSinceLastSave = false;

            //Set loaded to false.
            //loaded = false;
            
            //Initialize a new HashSet for the different entities.
            _entityGroups = new HashSet<int>();
            
            //Initialize a new Dictionary for the entity group patents.
            entityGroupSceneReference = new Dictionary<string, EntityGroup>();
        }

        /// <summary>
        /// Initialize
        /// </summary>
        public void Initialize()
        {
            //Try to load the data of the chunk from an existing file or generate new content.
            if (Load(out var chunkData))
            {
                data = chunkData;
                TreesCreated = true;
            }
            else
            {
                TreesCreated = false;
                data = new ChunkEntity[8, 8, 8];

                //Generate
                GenerateData();
            }
        }

        /// <summary>
        /// Fill the list of the specific entity-group.
        /// </summary>
        /// <param name="entityName"></param>
        /// <param name="localPosition"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void FillListOfEntityGroup(in string entityName, in Vector3Int localPosition)
        {
            if (!entityGroupSceneReference.TryGetValue(entityName, out var list))
            {
                return;
            }

            var chunkEntity = data[localPosition.x, localPosition.y, localPosition.z];
            
            var secondLeftSelfPattern = GetRelativeChunkEntity(Direction.Left, localPosition).neighbourPatterns.leftPattern;
            var secondRightSelfPattern = GetRelativeChunkEntity(Direction.Right, localPosition).neighbourPatterns.rightPattern;
            var secondBottomSelfPattern = GetRelativeChunkEntity(Direction.Bottom, localPosition).neighbourPatterns.bottomPattern;
            var secondTopSelfPattern = GetRelativeChunkEntity(Direction.Top, localPosition).neighbourPatterns.topPattern;
            var secondBackSelfPattern = GetRelativeChunkEntity(Direction.Back, localPosition).neighbourPatterns.backPattern;
            var secondFrontSelfPattern = GetRelativeChunkEntity(Direction.Front, localPosition).neighbourPatterns.frontPattern;
            
            switch (chunkEntity.entity.buildType)
            {
                case BuildType.Planet:
                    var planetMesh = GetPlanetMesh(chunkEntity.selfNeighbourPattern, chunkEntity.neighbourPatterns, new NeighbourPatterns
                        (
                            secondLeftSelfPattern, 
                            secondRightSelfPattern, 
                            secondBottomSelfPattern, 
                            secondTopSelfPattern,
                            secondBackSelfPattern,
                            secondFrontSelfPattern
                        )
                    );
                    
                    list.meshAndPosition.Add
                    (
                        new MeshAndPosition
                        {
                            mesh = planetMesh,
                            position = localPosition
                        }
                    );
                    
                    break;
                
                
                case BuildType.Pillar:

                    var pillarMesh = GetPillarMesh(chunkEntity.selfNeighbourPattern);

                    if (TestOnePattern(chunkEntity.neighbourPatterns.leftPattern,
                        new byte[] {5,21,37,53}))
                    {
                        pillarMesh = Planets.CombineMeshes.CombineWithSecondMeshAtDifferentPosition(pillarMesh, GetPillarMesh(3), new Vector3(-1f, 0, 0));
                    }
                    
                    if (TestOnePattern(chunkEntity.neighbourPatterns.rightPattern,
                        new byte[] {6,22,38,54}))
                    {
                        pillarMesh = Planets.CombineMeshes.CombineWithSecondMeshAtDifferentPosition(pillarMesh, GetPillarMesh(3), new Vector3(1f, 0, 0));
                    }
                    
                    if (TestOnePattern(chunkEntity.neighbourPatterns.bottomPattern,
                        new byte[] {21, 22, 23, 37, 38, 39, 53, 54, 55}))
                    {
                        pillarMesh = Planets.CombineMeshes.CombineWithSecondMeshAtDifferentPosition(pillarMesh, GetPillarMesh(4), new Vector3(0, -.5f, 0));
                    }
                    if (TestOnePattern(chunkEntity.neighbourPatterns.backPattern,
                        new byte[] {21,22,}))
                    {
                        pillarMesh = Planets.CombineMeshes.CombineWithSecondMeshAtDifferentPosition(pillarMesh, GetPillarMesh(48), new Vector3(0, 0, -1));
                    }
                    
                    if (TestOnePattern(chunkEntity.neighbourPatterns.frontPattern,
                        new byte[] {37,38}))
                    {
                        pillarMesh = Planets.CombineMeshes.CombineWithSecondMeshAtDifferentPosition(pillarMesh, GetPillarMesh(48), new Vector3(0, 0, 1));
                    }
                    
                    list.meshAndPosition.Add
                    (
                        new MeshAndPosition
                        {
                            mesh = pillarMesh,
                            position = localPosition
                        }
                    );
                    
                    break;
                
                
                case BuildType.Fluid: break;

                default: throw new ArgumentOutOfRangeException();
            }
        }
        
        /// <summary>
        /// Combine the meshes, apply the material and a collider
        /// </summary>
        /// <param name="entityName"></param>
        public void CombineMeshes(in string entityName)
        {
            if (!entityGroupSceneReference.TryGetValue(entityName, out var list))
            {
                return;
            }

            var entityInformation = Planet.planetEntities.GetEntityByLabel(entityName);
            
            var combine = new CombineInstance[list.meshAndPosition.Count];

            var i = 0;
            while (i < list.meshAndPosition.Count)
            {
                combine[i].mesh = list.meshAndPosition[i].mesh;

                var position = list.meshAndPosition[i].position;
                combine[i].transform = Matrix4x4.Translate(new Vector3(position.x, position.y * .5f, position.z));
                i++;
            }

            var newMesh = new Mesh();
            newMesh.CombineMeshes(combine);

            var meshFilter = list.parent.GetComponent<MeshFilter>();
            meshFilter.mesh = newMesh;
            
            var meshRenderer = list.parent.GetComponent<MeshRenderer>();

            Planet.planetMaterials.TryGetValue(entityName, out var material);
            meshRenderer.material = material;

            if (!entityInformation.isFluid)
            {
                var meshCollider = list.parent.GetComponent<MeshCollider>();
                meshCollider.sharedMesh = newMesh;
            }

            meshRenderer.shadowCastingMode = entityInformation.castShadow ? ShadowCastingMode.On : ShadowCastingMode.Off;
        }

        /// <summary>
        /// Get the data of an neighbour entity, either in this chunk or in the neighbour chunk.
        /// </summary>
        /// <param name="direction">The direction</param>
        /// <param name="localPosition">From which local-position from this chunk.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">Chunk not found.</exception>
        private ChunkEntity GetRelativeChunkEntity(in Direction direction, in Vector3Int localPosition)
        {
            switch (direction)
            {
                case Direction.Left:
                    if (localPosition.x - 1 != -1)
                    {
                        return data[localPosition.x - 1, localPosition.y, localPosition.z];
                    }
                    else
                    {
                        return GetChunk(direction, out var leftChunk)
                            ? leftChunk.data[7, localPosition.y, localPosition.z]
                            : new ChunkEntity(Planet.planetEntities.entities[0]);
                    }

                case Direction.Right:
                    if (localPosition.x + 1 != 8)
                    {
                        return data[localPosition.x + 1, localPosition.y, localPosition.z];
                    }
                    else
                    {
                        return GetChunk(direction, out var rightChunk)
                            ? rightChunk.data[0, localPosition.y, localPosition.z]
                            : new ChunkEntity(Planet.planetEntities.entities[0]);
                    }

                case Direction.Bottom:
                    if (localPosition.y - 1 != -1)
                    {
                        return data[localPosition.x, localPosition.y - 1, localPosition.z];
                    }
                    else
                    {
                        return GetChunk(direction, out var bottomChunk)
                            ? bottomChunk.data[localPosition.x, 7, localPosition.z]
                            : new ChunkEntity(Planet.planetEntities.entities[0]);
                    }

                case Direction.Top:
                    if (localPosition.y + 1 != 8)
                    {
                        return data[localPosition.x, localPosition.y + 1, localPosition.z];
                    }
                    else
                    {
                        return GetChunk(direction, out var topChunk)
                            ? topChunk.data[localPosition.x, 0, localPosition.z]
                            : new ChunkEntity(Planet.planetEntities.entities[0]);
                    }
                
                case Direction.Back:
                    if (localPosition.z - 1 != -1)
                    {
                        return data[localPosition.x, localPosition.y, localPosition.z - 1];
                    }
                    else
                    {
                        return GetChunk(direction, out var backChunk)
                            ? backChunk.data[localPosition.x, localPosition.y, 7]
                            : new ChunkEntity(Planet.planetEntities.entities[0]);
                    }

                case Direction.Front:
                    if (localPosition.z + 1 != 8)
                    {
                        return data[localPosition.x, localPosition.y, localPosition.z + 1];
                    }
                    else
                    {
                        return GetChunk(direction, out var frontChunk)
                            ? frontChunk.data[localPosition.x, localPosition.y, 0]
                            : new ChunkEntity(Planet.planetEntities.entities[0]);
                    }

                default: throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="chunk"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private bool GetChunk(in Direction direction, out Chunk chunk)
        {
            switch (direction)
            {
                case Direction.Left: return Planet.LoadedChunks.TryGetValue(leftChunkPosition, out chunk);
                case Direction.Right: return Planet.LoadedChunks.TryGetValue(rightChunkPosition, out chunk);
                case Direction.Bottom: return Planet.LoadedChunks.TryGetValue(bottomChunkPosition, out chunk);
                case Direction.Top: return Planet.LoadedChunks.TryGetValue(topChunkPosition, out chunk);
                case Direction.Back: return Planet.LoadedChunks.TryGetValue(backChunkPosition, out chunk);
                case Direction.Front: return Planet.LoadedChunks.TryGetValue(frontChunkPosition, out chunk);
                default: throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }
        
        private byte CalculateMeshPattern(BaseEntity thisEntity, BaseEntity neighbourEntity, byte incrementValue)
        {
            byte pattern = 0;
            
            //Check if empty.
            if (neighbourEntity.id != 0)
            {
                pattern += incrementValue;
            }

            //Check if same build-type
            if (thisEntity.buildType == BuildType.Planet && neighbourEntity.buildType == BuildType.Pillar)
            {
                pattern -= incrementValue;
            }

            return pattern;
        }
        
        private void CalculatePatternOfLocalEntity(in Vector3Int localPosition)
        {
            var entity = data[localPosition.x, localPosition.y, localPosition.z].entity;
            
            if (entity.id == 0)
            {
                data[localPosition.x, localPosition.y, localPosition.z].selfNeighbourPattern = 0;
                return;
            }
            
            byte selfNeighbourPattern = 0;

            //Left
            if (localPosition.x - 1 != -1)
            {
                var leftEntity = data[localPosition.x - 1, localPosition.y, localPosition.z].entity;
                selfNeighbourPattern += CalculateMeshPattern(entity, leftEntity, 1);
            }
            else
            {
                if (GetChunk(Direction.Left, out var leftChunk))
                {
                    var leftEntity = leftChunk.data[7, localPosition.y, localPosition.z].entity;
                    selfNeighbourPattern += CalculateMeshPattern(entity, leftEntity, 1);
                }
            }
            
            //Right
            if (localPosition.x + 1 != 8)
            {
                var rightEntity = data[localPosition.x + 1, localPosition.y, localPosition.z].entity;
                selfNeighbourPattern += CalculateMeshPattern(entity, rightEntity, 2);

            }
            else
            {
                if (GetChunk(Direction.Right, out var rightChunk))
                {
                    var rightEntity = rightChunk.data[0, localPosition.y, localPosition.z].entity;
                    selfNeighbourPattern += CalculateMeshPattern(entity, rightEntity, 2);
                }
            }
            
            //Bottom
            if (localPosition.y - 1 != -1)
            {
                var bottomEntity = data[localPosition.x, localPosition.y - 1, localPosition.z].entity;
                selfNeighbourPattern += CalculateMeshPattern(entity, bottomEntity, 4);
            }
            else
            {
                if (GetChunk(Direction.Bottom, out var bottomChunk))
                {
                    var bottomEntity = bottomChunk.data[localPosition.x, 7, localPosition.z].entity;
                    selfNeighbourPattern += CalculateMeshPattern(entity, bottomEntity, 4);
                }
            }
            
            //Top
            if (localPosition.y + 1 != 8)
            {
                var topEntity = data[localPosition.x, localPosition.y + 1, localPosition.z].entity;
                selfNeighbourPattern += CalculateMeshPattern(entity, topEntity, 8);
            }
            else
            {
                if (GetChunk(Direction.Top, out var topChunk))
                {
                    var topEntity = topChunk.data[localPosition.x, 0, localPosition.z].entity;
                    selfNeighbourPattern += CalculateMeshPattern(entity, topEntity, 8);
                }
            }
            
            //Back
            if (localPosition.z - 1 != -1)
            {
                var backEntity = data[localPosition.x, localPosition.y, localPosition.z - 1].entity;
                selfNeighbourPattern += CalculateMeshPattern(entity, backEntity, 16);
            }
            else
            {
                if (GetChunk(Direction.Back, out var backChunk))
                {
                    var backEntity = backChunk.data[localPosition.x, localPosition.y, 7].entity;
                    selfNeighbourPattern += CalculateMeshPattern(entity, backEntity, 16);
                }
            }
            
            //Front
            if (localPosition.z + 1 != 8)
            {
                var frontEntity = data[localPosition.x, localPosition.y, localPosition.z + 1].entity;
                selfNeighbourPattern += CalculateMeshPattern(entity, frontEntity, 32);
            }
            else
            {
                if (GetChunk(Direction.Front, out var frontChunk))
                {
                    var frontEntity = frontChunk.data[localPosition.x, localPosition.y, 0].entity;
                    selfNeighbourPattern += CalculateMeshPattern(entity, frontEntity, 32);
                }
            }

            data[localPosition.x, localPosition.y, localPosition.z].selfNeighbourPattern = selfNeighbourPattern;
        }
        
        private void CalculateLocalPattern()
        {
            var z = 0;

            while (z < 8)
            {
                var y = 0;
                while (y < 8)
                {
                    var x = 0;
                    while (x < 8)
                    {
                        CalculatePatternOfLocalEntity(new Vector3Int(x, y, z));
                        x++;
                    }
                    y++;
                }
                z++;
            }
        }

        /// <summary>
        /// Calculate the pattern.
        /// </summary>
        public void CalculatePatternsAndGroups(bool calculateNeighbourPatternsBefore)
        {
            if (calculateNeighbourPatternsBefore)
            {
                GetChunk(Direction.Left, out var leftChunk);
                leftChunk?.CalculateLocalPattern();

                GetChunk(Direction.Right, out var rightChunk);
                rightChunk?.CalculateLocalPattern();

                GetChunk(Direction.Bottom, out var bottomChunk);
                bottomChunk?.CalculateLocalPattern();

                GetChunk(Direction.Top, out var topChunk);
                topChunk?.CalculateLocalPattern();

                GetChunk(Direction.Back, out var backChunk);
                backChunk?.CalculateLocalPattern();

                GetChunk(Direction.Front, out var frontChunk);
                frontChunk?.CalculateLocalPattern();
            }
            
            foreach (Transform entityGroup in SceneReferenceObject.transform)
            {
                Object.Destroy(entityGroup.gameObject);
            }
                
            entityGroupSceneReference.Clear();
            _entityGroups.Clear();
            
            int x;
            int y;
            var z = 0;
            
            while (z < 8)
            {
                y = 0;
                while (y < 8)
                {
                    x = 0;
                    while (x < 8)
                    {
                        _entityGroups.Add(data[x,y,z].entity.id);
                        CalculatePatternOfLocalEntity(new Vector3Int(x, y, z));
                        x++;
                    }
                    y++;
                }
                z++;
            }
            
            foreach (var entityGroup in _entityGroups)
            {
                if (entityGroup == 0)
                {
                    continue;
                }

                var entityInformation = Planet.planetEntities.GetEntityById(entityGroup);

                var chunkTemplate = Object.Instantiate
                (
                    entityInformation.isFluid ? 
                        Planet.fluidChunkTemplatePrefab : 
                        Planet.nonFluidChunkTemplatePrefab, SceneReferenceObject.transform, true
                );
                
                chunkTemplate.transform.localPosition = Vector3.zero;
                chunkTemplate.name = entityInformation.label;

                entityGroupSceneReference.Add(entityInformation.label, new EntityGroup(chunkTemplate));
            }
            
            z = 0;

            while (z < 8)
            {
                y = 0;
                while (y < 8)
                {
                    x = 0;
                    while (x < 8)
                    {
                        var entityPattern = new NeighbourPatterns
                        {
                            leftPattern = GetRelativeChunkEntity(Direction.Left, new Vector3Int(x, y, z)).selfNeighbourPattern,
                            rightPattern = GetRelativeChunkEntity(Direction.Right, new Vector3Int(x, y, z)).selfNeighbourPattern,
                            bottomPattern = GetRelativeChunkEntity(Direction.Bottom, new Vector3Int(x, y, z)).selfNeighbourPattern,
                            topPattern = GetRelativeChunkEntity(Direction.Top, new Vector3Int(x, y, z)).selfNeighbourPattern,
                            backPattern = GetRelativeChunkEntity(Direction.Back, new Vector3Int(x, y, z)).selfNeighbourPattern,
                            frontPattern = GetRelativeChunkEntity(Direction.Front, new Vector3Int(x, y, z)).selfNeighbourPattern,
                        };

                        data[x, y, z].neighbourPatterns = entityPattern;

                        FillListOfEntityGroup(Planet.planetEntities.GetEntityById(data[x,y,z].entity.id).label, new Vector3Int(x, y, z));
                        x++;
                    }
                    y++;
                }
                z++;
            }
        }

        /// <summary>
        /// Generate the data.
        /// </summary>
        private void GenerateData()
        {
            var air = Planet.planetEntities.GetEntityByLabel("Air");
            var bedrock = Planet.planetEntities.GetEntityByLabel("Bedrock");
            var grass = Planet.planetEntities.GetEntityByLabel("Grass");
            //var water = Planet.planetEntities.GetEntityByLabel("Water");
            //var sand = Planet.planetEntities.GetEntityByLabel("Sand");
            var dirt = Planet.planetEntities.GetEntityByLabel("Dirt");
            //var oakTreeLog = Planet.planetEntities.GetEntityByLabel("Oak Tree Log");

            var z = 0;

            while (z < 8)
            {
                var y = 0;
                while (y < 8)
                {
                    var x = 0;
                    while (x < 8)
                    {
                        var worldX = WorldPosition.x + x;
                        var worldY = WorldPosition.y + y / 2f;
                        var worldZ = WorldPosition.z + z;

                        //Probabilities
                        var grassProbability = Generation.Generate2DGrass(worldX, worldZ, Planet.seed);
                        //var sandProbability = Generation.Generate2DSand(worldX, worldZ, Planet.seed);
                        

                        //Definitions
                        if (Mathf.FloorToInt(worldY) == 0)
                        {
                            data[x, y, z] = new ChunkEntity(bedrock);
                        }
                        else if (Mathf.FloorToInt(worldY) == grassProbability)
                        {
                            data[x,y,z] = new ChunkEntity(grass);
                        }
                        /*else if(worldY < grassProbability && worldY > grassProbability - 10)
                        {
                            Data[x,y,z] = new ChunkEntity(water);
                        }*/
                        else if (worldY < grassProbability)
                        {
                            data[x,y,z] = new ChunkEntity(dirt);
                        }
                        else
                        {
                            data[x,y,z] = new ChunkEntity(air);
                        }
                        x++;
                    }
                    y++;
                }
                z++;
            }
        }
        
        /// <summary>
        /// Save Chunk
        /// </summary>
        public void Save()
        {
            if (!modifiedSinceLastSave)
            {
                return;
            }
            
            var filePath = Application.persistentDataPath + "/save/Planet/Chunks/" + WorldPosition.x + "_" + WorldPosition.y + "_" + WorldPosition.z + ".json";

            if (!File.Exists(filePath))
            {
                // ReSharper disable once AssignNullToNotNullAttribute
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }
            
            var dataToSave = new ChunkDataToSave
            {
                id = new int[512],
                stability = new int[512],
                planetId = Planet.planetId
            };
            
            var index = 0;
            for (var z = 0; z < 8; z++)
            {
                for (var y = 0; y < 8; y++)
                {
                    for (var x = 0; x < 8; x++)
                    {
                        dataToSave.id[index] = data[x, y, z].entity.id;
                        dataToSave.stability[index] = data[x, y, z].stability;
                        index++;
                    }
                }
            }
            
            var jsonString = JsonUtility.ToJson(dataToSave);
            File.WriteAllText(filePath,jsonString);
            
            modifiedSinceLastSave = false;
        }
        
        /// <summary>
        /// Load Chunk
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        private bool Load(out ChunkEntity[,,] entities)
        {
            var filePath = Application.persistentDataPath + "/save/Planet/Chunks/" + WorldPosition.x + "_" + WorldPosition.y + "_" + WorldPosition.z + ".json";

            if (!File.Exists(filePath))
            {
                entities = new ChunkEntity[0,0,0];
                return false;
            }
            
            var dataToLoad = JsonUtility.FromJson<ChunkDataToSave>(File.ReadAllText(filePath));

            entities = new ChunkEntity[8,8,8];

            foreach (var planet in Object.FindObjectsOfType<Planet>())
            {
                if (planet.GetPlanet(dataToLoad.planetId))
                {
                    Planet = planet;
                }
            }

            var index = 0;
            for (var z = 0; z < 8; z++)
            {
                for (var y = 0; y < 8; y++)
                {
                    for (var x = 0; x < 8; x++)
                    {
                        entities[x, y, z] = new ChunkEntity(Planet.planetEntities.GetEntityById(dataToLoad.id[index]))
                        {
                            stability = dataToLoad.stability[index]
                        };
                        index++;
                    }
                }
            }

            return true;
        }
        
        public void Redraw(in bool calculateNeighbourPatternsBefore)
        {
            //loaded = false;

            CalculatePatternsAndGroups(calculateNeighbourPatternsBefore);
            
            foreach (var parent in entityGroupSceneReference)
            {
                CombineMeshes(parent.Key);
            }
            
            //loaded = true;
        }
        
        /// <summary>
        /// Careful about priority. The more conditions the more on top. 
        /// </summary>
        /// <param name="selfPattern"></param>
        /// <param name="np"></param>
        /// <returns></returns>
        
        //Maybe implement chain of command pattern to execute high priority first.
        public static Mesh GetPlanetMesh(in byte selfPattern, in NeighbourPatterns np, in NeighbourPatterns npLevel2)
        {
            switch (selfPattern)
            {
                case 1: return MeshDefinition.RightBottomTopBackFrontQuad;
                
                case 2: return MeshDefinition.LeftBottomTopBackFrontQuad;
                
                case 3: 
                    if (TestOnePattern(np.rightPattern, new byte[]{21,23}))
                    {
                        return MeshDefinition.BottomTopBackFrontQuad_RightPPRectangleTriangle;
                    }
                    
                    
                    return MeshDefinition.BottomTopBackFrontQuad;
                
                case 4: return MeshDefinition.LeftRightTopBackFrontQuad;
                
                case 5:

                    if (TestOnePattern(np.leftPattern, new byte[] {31}))
                    {
                        return MeshDefinition.DiagonalQuadRightFront_TopMMRectangleTriangle_BackQuad;
                    }

                    return MeshDefinition.LeftTopRamp_BackMMRectangleTriangle_FrontMMRectangleTriangle;
                
                case 6:

                    if (TestOnePattern(np.bottomPattern, new byte[]{14}))
                    {
                        return MeshDefinition.DiagonalQuadLeftFront_TopPMRectangleTriangle_BackQuad;
                    }
                    
                    
                    
                    
                    if (TestOnePattern(np.bottomPattern, new byte[]{14,30}))
                    {
                        return MeshDefinition.TriangleUpPM_BackPMRectangleTriangle;
                    }
                    
                    if (TestOnePattern(np.rightPattern, new byte[]{23}))
                    {
                        return MeshDefinition.RightTopRampWithOneVertexDown_BackPMRectangleTriangle;
                    }
                    
                    
                    
                    return MeshDefinition.RightTopRamp_BackPMRectangleTriangle_FrontPMRectangleTriangle;
                
                case 7: return MeshDefinition.TopBackFrontQuad;
                
                case 8: return MeshDefinition.LeftRightBottomBackFrontQuad;
                
                case 9: return MeshDefinition.RightBottomBackFrontQuad;
                
                case 10: return MeshDefinition.LeftBottomBackFrontQuad;
                
                case 11: return MeshDefinition.BottomBackFrontQuad;
                
                case 12: return MeshDefinition.LeftRightBackFrontQuad;
                
                case 13: 
                    
                    if (TestTwoPattern(np.bottomPattern, np.topPattern, new byte[] {13,29}, new byte[] {5,13,29}))
                    {
                        return MeshDefinition.FrontRightDiagonalQuad_BackQuad;
                    }
                    
                    return MeshDefinition.RightBackFrontQuad;
                
                case 14:

                    if (TestTwoPattern(np.bottomPattern, np.topPattern, new byte[] {14,30}, new byte[] {6,14,30}))
                    {
                        return MeshDefinition.FrontLeftDiagonalQuad_BackQuad;
                    }
                    
                    return MeshDefinition.LeftBackFrontQuad;
                
                case 15: return MeshDefinition.BackFrontQuad;
                
                case 16: return MeshDefinition.LeftRightBottomTopFrontQuad;
                
                case 17:
                    if (TestTwoPattern(np.leftPattern, np.backPattern, new byte[]{23,55,63}, new byte[]{55,63}))
                    {
                        return MeshDefinition.MMTriangleUp_BottomMMRectangleTriangle;
                    }
                    break;
                
                case 18:

                    if (TestTwoPattern(np.rightPattern, np.backPattern, new byte[] {21,23,51,55}, new byte[] {54,55}))
                    {
                        return MeshDefinition.TriangleUpPM_BottomPMRectangleTriangle;
                    }
                    break;
                
                case 19:

                    if (TestOnePattern(np.rightPattern, new byte[]{21,23}))
                    {
                        return MeshDefinition.TriangleDownPP_TopMMRectangleTrianlge_BottomQuad_FrontMMRectangleTriangle;
                    }
                    
                    return MeshDefinition.BottomTopFrontQuad;
                
                case 20:
                    if (TestTwoPattern(np.bottomPattern, np.backPattern, new byte[] {29}, new byte[] {52,53,55,61}))
                    {
                        return MeshDefinition.TriangleUpMM_LeftMMTriangleRectangle;
                    }

                    if (TestOnePattern(np.backPattern, new byte[] {53}))
                    {
                        return MeshDefinition.BackTopRampWithOneVertexDown_LeftMMRectangleTriangle;
                    }
                    
                    if (TestOnePattern(np.backPattern, new byte[] {54}))
                    {
                        return MeshDefinition.BackTopRampWithOneVertexDown_RightMMRectangleTriangle;
                    }
                    
                    if (TestOnePattern(np.bottomPattern, new byte[] {61}))
                    {
                        return MeshDefinition.TriangleDownMM;
                    }
          
                    return MeshDefinition.BackTopRamp_LeftMMRectangleTriangle_RightMMRectangleTriangle;
                
                case 21: 
                    
                    if (TestTwoPattern(np.leftPattern, np.backPattern, new byte[] {22,23,31,55,63}, new byte[] {37,53,55,61,63}))
                    {
                        return MeshDefinition.TriangleUpMM;
                    }
                    
                    
                    return MeshDefinition.DiagonalQuadRightFront_TopMMRectangleTriangle;
                
                case 22: 
                    
                    if (TestTwoPattern(np.rightPattern, np.backPattern, new byte[] {21,23,31,55,62,63}, new byte[] {54,55,62,63}))
                    {
                        return MeshDefinition.TriangleUpPM;
                    }
                    
                    
                    return MeshDefinition.DiagonalQuadLeftFront_TopPMRectangleTriangle;
                
                case 23:
                    if (TestOnePattern(np.backPattern, new byte[] {38, 54}))
                    {
                        return MeshDefinition.BackTopRamp_BackMPRectangleTriangle;
                    }

                    if (TestOnePattern(np.backPattern, new byte[] {37, 53}))
                    {
                        return MeshDefinition.BackTopRamp_BackPPRectangleTriangle;
                    }
                    if (TestOnePattern(np.bottomPattern, new byte[] {29}))
                    {
                        return MeshDefinition.BackTopRamp_BottomPPRectangleTriangle;
                    }
                    
                    
                    return MeshDefinition.BackTopRamp;
                
                case 24: return MeshDefinition.LeftRightBottomFrontQuad;
                
                case 25:
                    if (TestOnePattern(np.topPattern, new byte[] {21, 29}))
                    {
                        return MeshDefinition.DiagonalQuadRightFront_BottomMMRectangleTriangle;
                    }
                    break;
                
                case 26:
                    if (TestOnePattern(np.topPattern, new byte[] {22, 30}))
                    {
                        return MeshDefinition.DiagonalQuadLeftFront_BottomPMRectangleTriangle;
                    }
                    break;
                
                case 27: return MeshDefinition.BottomFrontQuad;
                
                case 28:
                    
                    if (TestOnePattern(np.topPattern, new byte[] {30}))
                    {
                        return MeshDefinition.DiagonalQuadLeftFront_RightQuad;
                    }
                    
                    if (TestOnePattern(np.topPattern, new byte[] {29}))
                    {
                        return MeshDefinition.DiagonalQuadRightFront_LeftQuad;
                    }
                    
                    if (TestOnePattern(np.backPattern, new byte[] {54}))
                    {
                        return MeshDefinition.LeftRightFrontQuad_BackMPRectangleTriangle;
                    }

                    return MeshDefinition.LeftRightFrontQuad;
                
                case 29:

                    if (TestTwoPattern(np.bottomPattern, np.backPattern, new byte[]{31}, new byte[]{53}))
                    {
                        return MeshDefinition.DiagonalQuadRightFront_BackPPRectangleTriangle;
                    }
                    
                    /*if (TestTwoPattern(np.LeftPattern, np.BottomPattern, new byte[]{23,28}, new byte[]{29,61}))
                    {
                        return MeshDefinition.DiagonalQuadRightFront_LeftPPRectangleTriangle;
                    }*/

                    if (TestOnePattern(np.leftPattern, new byte[] {23}))
                    {
                        return MeshDefinition.DiagonalQuadRightFront_LeftPPRectangleTriangle;
                    }
                    
                    return MeshDefinition.DiagonalQuadRightFront;
                
                case 30:

                    if (TestOnePattern(np.backPattern, new byte []{54}))
                    {
                        return MeshDefinition.DiagonalQuadLeftFront_BackMPRectangleTriangle;
                    }
                    
                    return MeshDefinition.DiagonalQuadLeftFront;
                
                case 31:

                    if (TestTwoPattern(np.bottomPattern, np.topPattern, new byte[]{29}, new byte[]{21}))
                    {
                        return MeshDefinition.BottomPPRectangleTriangle_TopPPRectangleTriangle_FrontQuad;
                    }

                    if (TestTwoPattern(np.leftPattern, np.topPattern, new byte[] {22,23}, new byte[] {20,22,30}))
                    {
                        return MeshDefinition.MPTriangleDown_PMFrontRectangleTriangle;
                    }
       
                    if (TestTwoPattern(np.rightPattern, np.topPattern, new byte[] {5,21,23}, new byte[] {21,29}))
                    {
                        return MeshDefinition.PPTriangleDown_MMFrontRectangleTriangle;
                    }
                    
                    if (TestOnePattern( np.topPattern, new byte[] {22,30}))
                    {
                        return MeshDefinition.TopMPRectangleTriangle_FrontQuad;
                    }
                    if (TestOnePattern( np.topPattern,  new byte[] {21}))
                    {
                        return MeshDefinition.TopPPRectangleTriangle_FrontQuad;
                    }
                    if (TestOnePattern( np.leftPattern,  new byte[] {23}))
                    {
                        return MeshDefinition.LeftPPRectangleTriangle_FrontQuad;
                    }
                    
                    if (TestOnePattern( np.rightPattern,  new byte[] {21,23}))
                    {
                        return MeshDefinition.RightPPRectangleTriangle_FrontQuad;
                    }
                    
                    

                    break;
                
                case 32: return MeshDefinition.LeftRightBottomTopBackQuad;
                
                case 33:
                    
                    if (TestTwoPattern(np.leftPattern, np.frontPattern, new byte[] {51, 55}, new byte[] {19, 21, 51, 55}))
                    {
                        return MeshDefinition.TriangleUpMP_BottomMPRectangleTriangle;
                    }
                    break;
                
                case 34:
                    
                    if (TestTwoPattern(np.rightPattern, np.frontPattern, new byte[] {39,55}, new byte[] {54,55}))
                    {
                        return MeshDefinition.TriangleUpPP_BottomPPRectangleTriangle;
                    }
                    break;
                
                case 35: return MeshDefinition.BottomTopBackQuad;
                
                case 36: 
                    
                    if(TestOnePattern(np.frontPattern, new byte[] {54}))
                    {
                        return MeshDefinition.FrontTopRampWithOneVertexDown_RightMPRectangleTriangle;
                    }
                    
                    return MeshDefinition.FrontTopRamp_LeftMPRectangleTriangle_RightMPRectangleTriangle;
                
                case 37: 
                    
                    if (TestTwoPattern(np.leftPattern, np.frontPattern, new byte[] {38,39,55}, new byte[] {21,53}))
                    {
                        return MeshDefinition.TriangleUpMP;
                    }
                    return MeshDefinition.DiagonalQuadRightBack_TopMPRectangleTriangle;
                
                case 38: 
                    if (TestTwoPattern(np.rightPattern, np.frontPattern, new byte[] {37,39,47,55,63}, new byte[] {22,23,54,55}))
                    {
                        return MeshDefinition.TriangleUpPP;
                    }
                    
                    return MeshDefinition.DiagonalQuadLeftBack_TopPPRectangleTriangle;
                
                case 39:
                    if(TestOnePattern(np.frontPattern, new byte[] {21}))
                    {
                        return MeshDefinition.FrontTopRamp_FrontPPRectangleTriangle;
                    }
                   
                    if(TestOnePattern(np.frontPattern, new byte[] {22}))
                    {
                        return MeshDefinition.FrontTopRamp_FrontMPRectangleTriangle;
                    }
                    
                    return MeshDefinition.FrontTopRamp;
                
                case 40: return MeshDefinition.LeftRightBottomBackQuad;
                
                case 41:
                    if (TestOnePattern(np.topPattern, new byte[] {37, 45}))
                    {
                        return MeshDefinition.DiagonalQuadRightBack_BottomMPRectangleTriangle;
                    }

                    return MeshDefinition.RightBottomRamp;
                
                case 42:
                    if (TestOnePattern(np.topPattern, new byte[] {38, 46}))
                    {
                        return MeshDefinition.DiagonalQuadLeftBack_BottomPPRectangleTriangle;
                    }
                    if (TestOnePattern(np.topPattern, new byte[] {47}))
                    {
                        return MeshDefinition.LeftBottomRamp_BackPPRectangleTriangle;
                    }
                    return MeshDefinition.LeftBottomRamp;
                
                case 43: return MeshDefinition.BackBottomRamp;
                
                case 44: return MeshDefinition.LeftRightBack;
                
                case 45:
                    
                    
                

                    return MeshDefinition.DiagonalQuadRightBack;

                case 46:
                    if (TestOnePattern(np.topPattern, new byte[] {38,46}))
                    {
                        return MeshDefinition.DiagonalQuadLeftBack;
                    }
                    
                    if (TestOnePattern(np.frontPattern, new byte[] {54}))
                    {
                        return MeshDefinition.LeftBackQuad_FrontMPRectangleTriangle;
                    }
                    
                    break;
                
                case 47:
                    
                    if (TestTwoPattern(np.leftPattern, np.topPattern, new byte[] {38, 39, 47}, new byte[] {38,48, 46}))
                    {
                        return MeshDefinition.MMTriangleDown_PMBackRectangleTriangle;
                    }
                    if (TestTwoPattern(np.rightPattern, np.topPattern, new byte[] {37,39}, new byte[] {37, 45}))
                    {
                        return MeshDefinition.PMTriangleDown_MMBackRectangleTriangle;
                    }

             
                    if (TestOnePattern(np.leftPattern, new byte[] {43}))
                    {
                        return MeshDefinition.LeftMMRectangleTriangle_BackQuad;
                    }
                    
                    if (TestOnePattern(np.bottomPattern, new byte[] {45}))
                    {
                        return MeshDefinition.TriangleUpPMIn_BackMPRectangleTriangle;
                    }
                    
                    break;

                case 48: return MeshDefinition.LeftRightBottomTop;
                
                case 49: return MeshDefinition.RightBottomTop;
                
                case 50: 
                    
                    if (TestTwoPattern(np.backPattern, np.frontPattern, new byte[] {54},new byte[] {54}))
                    {
                        return MeshDefinition.LeftBottomTopQuad_BackMPRectangleTriangle_FrontMPRectangleTriangle;
                    }
                    
                    if (TestOnePattern(np.backPattern, new byte[] {54}))
                    {
                        return MeshDefinition.LeftBottomTopFrontQuad_BackMPRectangleTriangle;
                    }
                    
                    if (TestOnePattern(np.frontPattern, new byte[] {54}))
                    {
                        return MeshDefinition.LeftBottomTopBackQuad_FrontMPRectangleTriangle;
                    }
                    
                    return MeshDefinition.LeftBottomTop;
                
                case 51: return MeshDefinition.BottomTop;
                
                case 52:
                    if(TestOnePattern(np.backPattern, new byte[] {37}))
                    {
                        return MeshDefinition.LeftQuad_RightQuad_TopQuad_BackPPRectangleTriangle;
                    }
        
                    if(TestOnePattern(np.backPattern, new byte[] {38}))
                    {
                        return MeshDefinition.LeftQuad_RightQuad_TopQuad_BackMPRectangleTriangle;
                    }
                    if(TestOnePattern(np.frontPattern, new byte[] {53}))
                    {
                        return MeshDefinition.LeftQuad_RightQuad_TopQuad_FrontPPRectangleTriangle;
                    }
                    if(TestOnePattern(np.frontPattern, new byte[] {54}))
                    {
                        return MeshDefinition.LeftQuad_RightQuad_TopQuad_FrontMPRectangleTriangle;
                    }
                    break;
                
                case 53:
                    if (TestOnePattern(np.leftPattern, new byte[] {23,31}))
                    {
                        return MeshDefinition.LeftTopRamp_LeftPPRectangleTriangle;
                    }
                    
                    return MeshDefinition.LeftTopRamp;
                
                case 54:

                    if (TestTwoPattern(np.rightPattern, np.frontPattern, new byte[] {23},new byte[] {21}))
                    {
                        return MeshDefinition.RightTopRampWithOneTriangleDown;
                    }
                    
                    if (TestOnePattern(np.rightPattern, new byte[] {23}))
                    {
                        return MeshDefinition.RightTopRamp_RightPPRectangleTriangle;
                    }
                    
                    if (TestOnePattern(np.rightPattern, new byte[] {39}))
                    {
                        return MeshDefinition.RightTopRamp_RightPMRectangleTriangle;
                    }
                    
                    
                    return MeshDefinition.RightTopRamp;
                
                case 55:
                    
                    #region Diagonals
                    //Plus
                    if (
                        (np.leftPattern == 38 || 
                         np.leftPattern == 39) && 
                        np.rightPattern == 23 && 
                        (np.backPattern == 38 || 
                         np.backPattern == 54) && 
                        (np.frontPattern == 21 || 
                         np.frontPattern == 53)
                    )
                    {
                        return MeshDefinition.MMTriangleDown_PPTriangleDown;
                    }
                    
                    //Minus
                    if 
                    (
                        (np.leftPattern == 22 || 
                         np.leftPattern == 23) && 
                        (np.rightPattern == 37 || 
                         np.rightPattern == 39) && 
                        (np.backPattern == 37 || 
                         np.backPattern == 53) && 
                        (np.frontPattern == 22 || 
                         np.frontPattern == 54)
                    )
                    {
                        return MeshDefinition.PMTriangleDown_MPTriangleDown;
                    }
                    #endregion



                    if (TestThreePattern(np.rightPattern, np.bottomPattern, np.frontPattern, new byte [] {17}, new byte [] {29}, new byte[] {17}))
                    {
                        return MeshDefinition.TopMMRectangleTriangle_PPTriangleDown_BottomPPRectangleTriangle;
                    }
                    
                    if (TestTwoPattern(np.rightPattern, np.backPattern, new byte [] {33,37,39}, new byte[] {33,37,53}))
                    {
                        return MeshDefinition.TopMPRectangleTriangle_PMTriangleDown;
                    }
                    
                    if (TestTwoPattern(np.leftPattern, np.backPattern, new byte[] {34,38,39}, new byte[] {34,38,54,62}))
                    {
                        return MeshDefinition.TopPPRectangleTriangle_MMTriangleDown;
                    }

                    if (TestTwoPattern(np.leftPattern, np.frontPattern, new byte[] {18,22,23}, new byte[] {18,22,54,62}))
                    {
                        return MeshDefinition.TopPMRectangleTriangle_MPTriangleDown;
                    }
                    
                    if (TestTwoPattern(np.rightPattern, np.frontPattern, new byte[] {17,21,23}, new byte[] {17,21,53}))
                    {
                        return MeshDefinition.TopMMRectangleTriangle_PPTriangleDown;
                    }
                    
                    if (TestTwoPattern(np.backPattern, np.frontPattern, new byte[] {37,53}, new byte[] {21,53}))
                    {
                        return MeshDefinition.TopQuad_BackPPRectangleTriangle_FrontPPRectangleTriangle;
                    }
                    
                    if (TestTwoPattern(np.backPattern, np.frontPattern, new byte[] {38,54}, new byte[] {22,54}))
                    {
                        return MeshDefinition.TopQuad_BackMPRectangleTriangle_FrontMPRectangleTriangle;
                    }
                    
                    if (TestTwoPattern(np.leftPattern, np.rightPattern, new byte[] {23}, new byte[] {23}))
                    {
                        return MeshDefinition.LeftPPRectangleTriangle_RightPPRectangleTriangle_TopQuad;
                    }
                    
                    if (TestTwoPattern(np.leftPattern, np.rightPattern, new byte[] {38,39}, new byte[] {37,39}))
                    {
                        return MeshDefinition.LeftPMRectangleTriangle_RightPMRectangleTriangle_TopQuad;
                    }

                    
                    if (TestOnePattern(np.leftPattern, new byte []{23}))
                    {
                        return MeshDefinition.TopQuad_LeftPPRectangleTriangle;
                    }
                    
                    if (TestOnePattern(np.rightPattern, new byte []{21,23}))
                    {
                        return MeshDefinition.TopQuad_RightPPRectangleTriangle;
                    }
                    if (TestOnePattern(np.frontPattern, new byte []{21,53}))
                    {
                        return MeshDefinition.TopQuad_FrontPPRectangleTriangle;
                    }
                    if (TestOnePattern(np.frontPattern, new byte []{22,54}))
                    {
                        return MeshDefinition.TopQuad_FrontMPRectangleTriangle;
                    }
                    
                    
       
                    return MeshDefinition.TopQuad;
  
                case 56: return MeshDefinition.LeftRightBottomQuad;
                
                case 57: return MeshDefinition.RightBottomQuad;
                
                case 58: return MeshDefinition.LeftBottomQuad;
                
                case 59: return MeshDefinition.BottomQuad;
                
                case 60: return MeshDefinition.LeftRightQuad;
                
                case 61:
                    if (TestTwoPattern(np.leftPattern, np.frontPattern, new byte[]{23}, new byte[]{20}))
                    {
                        return MeshDefinition.LeftPPRectangleTriangle_RightQuad_FrontPPRectangleTriangle;
                    }
                    if (TestTwoPattern(np.topPattern, np.frontPattern, new byte[] {21, 29}, new byte[] {20,21,53}))
                    {
                        return MeshDefinition.PPTriangleDown_RightMMTriangleRectangle;
                    }
                    if (TestTwoPattern(np.topPattern, np.backPattern, new byte[] {37,45}, new byte[] {37,53}))
                    {
                        return MeshDefinition.RightMPRectangleTriangle_TriangleDownPM;
                    }
                    if (TestTwoPattern(np.backPattern, np.frontPattern, new byte[] {53}, new byte[] {53}))
                    {
                        return MeshDefinition.RightQuad_BackPPRectangleTriangle_FrontPPRectangleTriangle;
                    }
                    if(TestOnePattern(np.topPattern, new byte[]{37}))
                    {
                        return MeshDefinition.RightQuad_TopPMRectangleTriangle;
                    }
                    if (TestOnePattern(np.frontPattern, new byte[] {21,53}))
                    {
                        return MeshDefinition.RightQuad_FrontPPRectangleTriangle;
                    }
                    if (TestOnePattern(np.topPattern, new byte[] {21}))
                    {
                        return MeshDefinition.TopPPRectangleTriangle_RightQuad;
                    }
                    if (TestOnePattern(np.backPattern, new byte[] {53}))
                    {
                        return MeshDefinition.RightQuad_BackPPRectangleTriangle;
                    }
                    break;
                
                case 62:
                    if (TestTwoPattern(np.topPattern, np.backPattern, new byte[] {46}, new byte[] {54}))
                    {
                        return MeshDefinition.RightMPRectangleTriangle_TriangleDownMM;
                    }
                    
                    if (TestTwoPattern(np.topPattern, np.backPattern, new byte[] {38}, new byte[] {38,54,55}))
                    {
                        return MeshDefinition.LeftMPRectangleTriangle_TriangleDownMM;
                    }
                    
                    if (TestTwoPattern(np.topPattern, np.frontPattern, new byte[] {21}, new byte[] {54}))
                    {
                        return MeshDefinition.LeftQuad_TopPPRetcangleTriangle_FrontMPRectangleTriangle;
                    }
                    
                    
                    if (TestOnePattern(np.backPattern, new byte[] {38,54}))
                    {
                        return MeshDefinition.LeftQuad_BackMPRectangleTriangle;
                    }
                    
                    if (TestTwoPattern(np.topPattern, np.frontPattern, new byte[] {22,30}, new byte[] {22,54,55}))
                    {
                        return MeshDefinition.MPTriangleDown_LeftMMTriangleRectangle;
                    }

                    if (TestOnePattern(np.rightPattern, new byte[] {21,23}))
                    {
                        return MeshDefinition.LeftQuad_RightPPRectangleTriangle;
                    }
                    
                    if (TestOnePattern(np.frontPattern, new byte[] {54}))
                    {
                        return MeshDefinition.LeftQuad_FrontMPRectangleTriangle;
                    }
                    break;
                
                case 63:

                    if (TestThreePattern(np.rightPattern, np.topPattern, np.frontPattern, new byte[] {17,21,23}, new byte[] {5,20,21,29}, new byte[] {17,21,53}))
                    {
                        return MeshDefinition.TriangleDownPP;
                    }

                    if (TestThreePattern(np.rightPattern, np.topPattern, np.backPattern, new byte[] {37,39},new byte[] {37,45}, new byte[] {37,53}))
                    {
                        return MeshDefinition.TriangleDownPM;
                    }
                    
                    if (TestThreePattern(np.leftPattern, np.topPattern, np.backPattern, new byte[] {38}, new byte[] {38}, new byte[] {38,54}))
                    {
                        return MeshDefinition.MMTriangleDown;
                    }
                    
                    if (TestThreePattern(np.leftPattern, np.topPattern, np.frontPattern, new byte[] {22,23}, new byte[] {22}, new byte[] {22,54}))
                    {
                        return MeshDefinition.MPTriangleDown;
                    }

                    if (TestTwoPattern(np.leftPattern, np.topPattern, new byte[] {39}, new byte[] {30}))
                    {
                        return MeshDefinition.LeftPMRectangleTriangle_TopMPRectangleTriangle;
                    }
                    if (TestTwoPattern(np.backPattern, np.frontPattern, new byte[] {38}, new byte[] {22,54}))
                    {
                        return MeshDefinition.BackMPRectangleTriangle_FrontMPRectangleTriangle;
                    }
                    if (TestTwoPattern(np.backPattern, np.frontPattern, new byte[] {37}, new byte[] {21}))
                    {
                        return MeshDefinition.BackPPRectangleTriangle_FrontPPRectangleTriangle;
                    }
                    

                    
                    
                    
                    
                    if (TestTwoPattern(np.rightPattern, np.frontPattern, new byte[] {21}, new byte[] {21}))
                    {
                        return MeshDefinition.RightPPRectangleTriangle_FrontPPRectangleTriangle;
                    }

                    



                    #region Left & Right

                    if (TestOnePattern(np.rightPattern, new byte[] {23}))
                    {
                        return MeshDefinition.LeftQuad_RightPPRectangleTriangle;
                    }

                    #endregion


                    #region Top & Front
                    if (TestTwoPattern(np.topPattern, np.frontPattern, new byte[] {21,29}, new byte[] {21,53}))
                    {
                        return MeshDefinition.TopPPRectangleTriangle_FrontPPRectangleTriangle;
                    }
                    #endregion
                    
                    
                    
                    
                    //Top & Right
                    if (TestTwoPattern(np.rightPattern, np.topPattern, new byte[] {21}, new byte[] {21}))
                    {
                        return MeshDefinition.RightPPRectangleTriangle_TopPPRectangleTriangle;
                    }
                    
                    //Top & Back
                    if (TestTwoPattern(np.topPattern, np.backPattern, new byte[] {37}, new byte[] {54}))
                    {
                        return MeshDefinition.TopPMRectangleTriangle_BackMPRectangleTriangle;
                    }
          
                    if (TestTwoPattern(np.topPattern, np.backPattern, new byte[] {45}, new byte[] {53}))
                    {
                        return MeshDefinition.TopPMRectangleTriangle_BackPPRectangleTriangle;
                    }
                    
                    //Top & Front
                    if (TestTwoPattern(np.frontPattern, np.topPattern, new byte[] {53}, new byte[] {30}))
                    {
                        return MeshDefinition.TopMPRectangleTriangle_FrontPPRectangleTriangle;
                    }
                    
                    if (TestTwoPattern(np.frontPattern, np.backPattern, new byte[] {30}, new byte[] {21}))
                    {
                        return MeshDefinition.TopMPRectangleTriangle_FrontPPRectangleTriangle;
                    }

                    if (TestTwoPattern(np.leftPattern, np.backPattern, new byte[] {38}, new byte[] {54}))
                    {
                        return MeshDefinition.LeftPMRectangleTriangle_BackMPRectangleTriangle;
                    }
                    
                    
                    if (TestTwoPattern(np.leftPattern, np.frontPattern, new byte[] {22}, new byte[] {54}))
                    {
                        return MeshDefinition.LeftPPRectangleTriangle_FrontMPRectangleTriangle;
                    }
                    
                    
                    
                    


                    
                    
                    #region One Condition
                    
                    #region Left

                    if (TestOnePattern(np.leftPattern, new byte[] {43}))
                    {
                        return MeshDefinition.LeftMMRectangleTriangle;
                    }
                    
                    if (TestOnePattern(np.leftPattern, new byte[] {22,23}))
                    {
                        return MeshDefinition.LeftPPRectangleTriangle;
                    }
                    if (TestOnePattern(np.leftPattern, new byte[] {38,39}))
                    {
                        return MeshDefinition.LeftPMRectangleTriangle;
                    }

                    #endregion
                    
                    #region Right

                    if (TestOnePattern(np.rightPattern, new byte[] {43}))
                    {
                        return MeshDefinition.RightMMRectangleTriangle;
                    }
                    
                    if (TestOnePattern(np.rightPattern, new byte[] {37,39}))
                    {
                        return MeshDefinition.RightPMRectangleTriangle;
                    }
      
                    if (TestOnePattern(np.rightPattern, new byte[] {17,21,23,29}))
                    {
                        return MeshDefinition.RightPPRectangleTriangle;
                    }

                    #endregion

                    #region Top

                    if (TestOnePattern(np.topPattern, new byte[] {37,45}))
                    {
                        return MeshDefinition.TopPMRectangleTriangle;
                    }

                    if (TestOnePattern(np.topPattern, new byte[] {22,30}) || npLevel2.topPattern == 30)
                    {
                        return MeshDefinition.TopMPRectangleTriangle;
                    }
           
                    if (TestOnePattern(np.topPattern, new byte[] {38,46}))
                    {
                        return MeshDefinition.TopMMRectangleTriangle;
                    }
                    
                    if (TestOnePattern(np.topPattern, new byte[] {21,29}) || npLevel2.topPattern == 29)
                    {
                        return MeshDefinition.TopPPRectangleTriangle;
                    }

                    #endregion

                    #region Back
                    
                    if 
                    (
                        np.backPattern == 37 || np.backPattern == 53
                    )
                    {
                        return MeshDefinition.BackPPRectangleTriangle;
                    }
                    
                    if 
                    (
                        np.backPattern == 38 || np.backPattern == 54
                    )
                    {
                        return MeshDefinition.BackMPRectangleTriangle;
                    }
                    
                    if 
                    (
                        np.backPattern == 41
                    )
                    {
                        return MeshDefinition.BackPMRectangleTriangle;
                    }
                    
                    if 
                    (
                        np.backPattern == 42
                    )
                    {
                        return MeshDefinition.BackMMRectangleTriangle;
                    }
                    
                    
                    
                    #endregion

                    #region Front

                    if (TestOnePattern(np.frontPattern, new byte[] {17,21,53}))
                    {
                        return MeshDefinition.FrontPPRectangleTriangle;
                    }
             
                    if (TestOnePattern(np.frontPattern, new byte[] {22,54}))
                    {
                        return MeshDefinition.FrontMPRectangleTriangle;
                    }

                    #endregion
                    
                    #endregion
                    break;
            }
            
            return HalfQuadMeshDefinition.Meshes[selfPattern];
        }
        public static Mesh GetPillarMesh(in byte selfPattern)
        {
            switch (selfPattern)
            {
                case 0: return MeshDefinition.Pillar_0;
                case 1: return MeshDefinition.Pillar_1;
                case 2: return MeshDefinition.Pillar_2;
                case 3: return MeshDefinition.Pillar_3;
                case 4: return MeshDefinition.Pillar_4;
                case 5: return MeshDefinition.Pillar_5;
                case 6: return MeshDefinition.Pillar_6;
                case 7: return MeshDefinition.Pillar_7;
                case 8: return MeshDefinition.Pillar_8;
                case 9: return MeshDefinition.Pillar_9;
                case 10: return MeshDefinition.Pillar_10;
                case 11: return MeshDefinition.Pillar_11;
                case 12: return MeshDefinition.Pillar_12;
                case 13: return MeshDefinition.Pillar_13;
                case 14: return MeshDefinition.Pillar_14;
                case 15: return MeshDefinition.Pillar_15;
                case 16: return MeshDefinition.Pillar_16;
                case 17: return MeshDefinition.Pillar_17;
                case 18: return MeshDefinition.Pillar_18;
                case 19: return MeshDefinition.Pillar_19;
                case 20: return MeshDefinition.Pillar_20;
                case 21: return MeshDefinition.Pillar_21;
                case 22: return MeshDefinition.Pillar_22;
                case 23: return MeshDefinition.Pillar_23;
                case 24: return MeshDefinition.Pillar_24;
                case 25: return MeshDefinition.Pillar_25;
                case 26: return MeshDefinition.Pillar_26;
                case 27: return MeshDefinition.Pillar_27;
                case 28: return MeshDefinition.Pillar_28;
                case 29: return MeshDefinition.Pillar_29;
                case 30: return MeshDefinition.Pillar_30;
                case 31: return MeshDefinition.Pillar_31;
                case 32: return MeshDefinition.Pillar_32;
                case 33: return MeshDefinition.Pillar_33;
                case 34: return MeshDefinition.Pillar_34;
                case 35: return MeshDefinition.Pillar_35;
                case 36: return MeshDefinition.Pillar_36;
                case 37: return MeshDefinition.Pillar_37;
                case 38: return MeshDefinition.Pillar_38;
                case 39: return MeshDefinition.Pillar_39;
                case 40: return MeshDefinition.Pillar_40;
                case 41: return MeshDefinition.Pillar_41;
                case 42: return MeshDefinition.Pillar_42;
                case 43: return MeshDefinition.Pillar_43;
                case 44: return MeshDefinition.Pillar_44;
                case 45: return MeshDefinition.Pillar_45;
                case 46: return MeshDefinition.Pillar_46;
                case 47: return MeshDefinition.Pillar_47;
                case 48: return MeshDefinition.Pillar_48;
                case 49: return MeshDefinition.Pillar_49;
                case 50: return MeshDefinition.Pillar_50;
                case 51: return MeshDefinition.Pillar_51;
                case 52: return MeshDefinition.Pillar_52;
                case 53: return MeshDefinition.Pillar_53;
                case 54: return MeshDefinition.Pillar_54;
                case 55: return MeshDefinition.Pillar_55;
                case 56: return MeshDefinition.Pillar_56;
                case 57: return MeshDefinition.Pillar_57;
                case 58: return MeshDefinition.Pillar_58;
                case 59: return MeshDefinition.Pillar_59;
                case 60: return MeshDefinition.Pillar_60;
                case 61: return MeshDefinition.Pillar_61;
                case 62: return MeshDefinition.Pillar_62;
                case 63: return MeshDefinition.Pillar_63;
            }

            return null;
        }
        
        #region Methods to test the patterns
        private static bool TestOnePattern(byte patternA, byte[] patternsA)
        {
            return patternsA.Any(pattern => pattern == patternA);
        }
        private static bool TestTwoPattern(byte patternA, byte patternB, IEnumerable<byte> patternsA, IEnumerable<byte> patternsB)
        {
            return patternsA.Any(pattern => pattern == patternA) && patternsB.Any(pattern => pattern == patternB);
        }
        private static bool TestThreePattern(byte patternA, byte patternB, byte patternC, IEnumerable<byte> patternsA, IEnumerable<byte> patternsB, IEnumerable<byte> patternsC)
        {
            return patternsA.Any(pattern => pattern == patternA) && patternsB.Any(pattern => pattern == patternB) && patternsC.Any(pattern => pattern == patternC);
        }
        
        private static bool TestFourPattern(byte patternA, byte patternB, byte patternC, byte patternD, IEnumerable<byte> patternsA, IEnumerable<byte> patternsB, IEnumerable<byte> patternsC, IEnumerable<byte> patternsD)
        {
            return 
                patternsA.Any(pattern => pattern == patternA) && 
                patternsB.Any(pattern => pattern == patternB) && 
                patternsC.Any(pattern => pattern == patternC) && 
                patternsD.Any(pattern => pattern == patternD);
        }
        #endregion
    }
}