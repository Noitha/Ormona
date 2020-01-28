using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Ormona.Scripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Ormona.Planets.Scripts
{
    public class Planet : MonoBehaviour
    {
        public int planetId;
        
        /// <summary>
        /// Holds all the loaded chunks of the planet.
        /// </summary>
        public ConcurrentDictionary<Vector3Int, Chunk> LoadedChunks { get; private set; }
        
        /// <summary>
        /// Hold all the chunks that needs to be unloaded.
        /// </summary>
        public ConcurrentDictionary<Vector3Int, Chunk> ChunksToUnload { get; private set; }
        
        public Slider progressSlider;
        public TextMeshProUGUI progressInfo;
        public TextMeshProUGUI progressText;
        public GameObject window;
        
        public EntityDatabase planetEntities;

        public Dictionary<string, Material> planetMaterials = new Dictionary<string, Material>();

        public GameObject nonFluidChunkTemplatePrefab;
        public GameObject fluidChunkTemplatePrefab;

        public int xSize;
        public int ySize;
        public int zSize;

        public int xOffset;
        public int yOffset;
        public int zOffset;

        public float seed;
        
        private Planet() {}
        public Player player;


        public bool displayLoad;
        
        private void Start()
        {
            LoadedChunks = new ConcurrentDictionary<Vector3Int, Chunk>();
            
            if (displayLoad)
            {
                window.SetActive(true);
                StartCoroutine(InitializeWorld());
            }
            else
            {
                var allMaterials = Resources.LoadAll<Material>("Materials/Planets");
                foreach (var material in allMaterials)
                {
                    planetMaterials.Add(material.name, material);
                }
                for (var z = zOffset; z < zSize + zOffset; z++)
                {
                    for (var y = yOffset; y < ySize + yOffset; y++)
                    {
                        for (var x = xOffset; x < xSize + xOffset; x++)
                        {
                            StartCoroutine(CreateChunk(new Vector3Int(x * 8, y * 4, z * 8),false));
                        }
                    }
                }
                foreach (var chunk in LoadedChunks)
                {
                    chunk.Value.Redraw(true);
                }
            }
        }



        public bool GetPlanet(int id)
        {
            return planetId == id;
        }


        private IEnumerator InitializeWorld()
        {
            //Loading materials
            var allMaterials = Resources.LoadAll<Material>("Materials/Planets");
            
            progressInfo.text = "Loading Materials.";
            progressSlider.value = 0;
            progressSlider.minValue = 0;
            progressSlider.maxValue = allMaterials.Length;

            var materialsLoaded = 0;
            foreach (var material in allMaterials)
            {
                planetMaterials.Add(material.name, material);
                materialsLoaded++;
                var loaded = materialsLoaded;
                yield return new WaitUntil(() => DisplayProgress(loaded, "Loading: " + material.name));
            }
            
            yield return new WaitForSeconds(0.2f);
            
            //Generating chunks
            var numberOfChunks = xSize * ySize * zSize;

            progressInfo.text = "Generating World.";
            progressSlider.value = 0;
            progressSlider.minValue = 0;
            progressSlider.maxValue = numberOfChunks;

            var chunksGenerated = 0;
            for (var z = zOffset; z < zSize + zOffset; z++)
            {
                for (var y = yOffset; y < ySize + yOffset; y++)
                {
                    for (var x = xOffset; x < xSize + xOffset; x++)
                    {
                        StartCoroutine(CreateChunk(new Vector3Int(x * 8, y * 4, z * 8),false));
                        chunksGenerated++;
                        var generated = chunksGenerated;
                        yield return new WaitUntil(() => DisplayProgress(generated, generated + " out of " + numberOfChunks + "."));
                    }
                }
            }
            
            yield return new WaitForSeconds(0.2f);
            
            //Redrawing 
            progressInfo.text = "Drawing World.";
            progressSlider.value = 0;
            progressSlider.minValue = 0;
            progressSlider.maxValue = numberOfChunks;

            var chunksDrawn = 0;
            foreach (var chunk in LoadedChunks)
            {
                chunk.Value.Redraw(true);
                chunksDrawn++;
                var drawn = chunksDrawn;
                yield return new WaitUntil(() => DisplayProgress(drawn, drawn + " out of " + numberOfChunks + "."));
            }
            
            window.SetActive(false);
        }

        /// <summary>
        /// Get the relative Chunk from a world position.
        /// </summary>
        /// <param name="chunkPosition"></param>
        /// <param name="worldPosition"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Chunk GetRelativeChunk(Direction chunkPosition, Vector3Int worldPosition)
        {
            switch (chunkPosition)
            {
                case Direction.Left:
                    return LoadedChunks.TryGetValue(worldPosition + new Vector3Int(-8,0,0), out var leftChunk) ? leftChunk : null;
                 
                case Direction.Right:
                    return LoadedChunks.TryGetValue(worldPosition + new Vector3Int(8,0,0), out var rightChunk) ? rightChunk : null;
                
                case Direction.Bottom:
                    return LoadedChunks.TryGetValue(worldPosition + new Vector3Int(0,-4,0), out var bottomChunk) ? bottomChunk : null;
              
                case Direction.Top:
                    return LoadedChunks.TryGetValue(worldPosition + new Vector3Int(0,4,0), out var topChunk) ? topChunk : null;
                
                case Direction.Back:
                    return LoadedChunks.TryGetValue(worldPosition + new Vector3Int(0,0,-8), out var backChunk) ? backChunk : null;
               
                case Direction.Front:
                    return LoadedChunks.TryGetValue(worldPosition +  new Vector3Int(0,0,8), out var frontChunk) ? frontChunk : null;
                 
                default:
                    throw new ArgumentOutOfRangeException(nameof(chunkPosition), chunkPosition, null);
            }
        }

        private bool DisplayProgress(in int sliderValue, in string infoText)
        {
            progressSlider.value = sliderValue;
            progressText.text = infoText;
            return true;
        }
        
        
        /// <summary>
        /// Create an instance of a chunk if it not already exists, and add it to the dictionary.
        /// </summary>
        /// <param name="worldPosition">Identifier of the Chunk</param>
        /// <param name="redrawNeighbour"></param>
        public IEnumerator CreateChunk(Vector3Int worldPosition, bool redrawNeighbour)
        {
            //Check if chunk already exists.
            if (LoadedChunks.ContainsKey(worldPosition))
            {
                yield break;
            }

            //Create the scene-reference-gameObject
            var chunkSceneReferenceObject = new GameObject
            {
                name = worldPosition.x + "_" + worldPosition.y + "_" + worldPosition.z,
                tag = "Chunk",
                transform =
                {
                    parent = transform,
                    localPosition = worldPosition
                }
            };

            var sceneChunk = chunkSceneReferenceObject.AddComponent<SceneChunk>();
            sceneChunk.worldPosition = worldPosition;
                
            //Create the chunk-instance.
            var chunk = new Chunk(this, worldPosition, chunkSceneReferenceObject);

            //Destroy the sceneObject in-case the chunk couldn't be added to the dictionary.
            if (!LoadedChunks.TryAdd(worldPosition, chunk))
            {
                Destroy(chunkSceneReferenceObject);
                yield break;
            }
            
            //Initialize the chunk.
            chunk.Initialize();

            chunk.Redraw(true);

            if (!redrawNeighbour)
            {
                yield break;
            }
            
            GetRelativeChunk(Direction.Left, worldPosition)?.Redraw(true);
            GetRelativeChunk(Direction.Right, worldPosition)?.Redraw(true);
            GetRelativeChunk(Direction.Bottom, worldPosition)?.Redraw(true);
            GetRelativeChunk(Direction.Top, worldPosition)?.Redraw(true);
            GetRelativeChunk(Direction.Back, worldPosition)?.Redraw(true);
            GetRelativeChunk(Direction.Front, worldPosition)?.Redraw(true);
        }
        
        /// <summary>
        /// Damage an entity from the chunk.
        /// </summary>
        /// <param name="chunk"></param>
        /// <param name="localPosition"></param>
        public void DamageEntity(Chunk chunk, Vector3Int localPosition)
        {
            if (chunk == null)
            {
                return;
            }
            
            var entityInformation = chunk.data[localPosition.x, localPosition.y, localPosition.z];

            Debug.LogFormat
            (
                "SelfPattern: {0} " +
                "L: {1} " +
                "R: {2} " +
                "B: {3} " +
                "T: {4} " +
                "B: {5} " +
                "F: {6}", 
                entityInformation.selfNeighbourPattern, 
                entityInformation.neighbourPatterns.leftPattern, 
                entityInformation.neighbourPatterns.rightPattern, 
                entityInformation.neighbourPatterns.bottomPattern,
                entityInformation.neighbourPatterns.topPattern, 
                entityInformation.neighbourPatterns.backPattern, 
                entityInformation.neighbourPatterns.frontPattern
            );
            
            chunk.modifiedSinceLastSave = true;
            
            chunk.data[localPosition.x, localPosition.y, localPosition.z].stability--;
            if (chunk.data[localPosition.x, localPosition.y, localPosition.z].stability <= 0)
            {
                chunk.data[localPosition.x, localPosition.y, localPosition.z] =
                    new ChunkEntity(planetEntities.entities[0])
                    {
                        neighbourPatterns = new NeighbourPatterns(0, 0, 0, 0, 0, 0)
                    };
            }
            
            chunk.Redraw(false);
        }

        /// <summary>
        /// Set an entity to the chunk.
        /// </summary>
        /// <param name="chunk"></param>
        /// <param name="chunkEntity"></param>
        /// <param name="localPosition"></param>
        public static void SetEntity(Chunk chunk, ChunkEntity chunkEntity, Vector3Int localPosition)
        {
            if (chunk == null)
            {
                return;
            }
            
            var entityInformation = chunk.data[localPosition.x, localPosition.y, localPosition.z].entity;
            
            if (entityInformation.id != 0 && !entityInformation.isFluid)
            {
                return;
            }
            
            chunk.modifiedSinceLastSave = true;
            chunk.data[localPosition.x, localPosition.y, localPosition.z] = chunkEntity;

            chunk.Redraw(false);
        }
    }
}