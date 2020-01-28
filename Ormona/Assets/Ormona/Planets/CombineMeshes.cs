using UnityEngine;

namespace Ormona.Planets
{
    public static class CombineMeshes
    {
        public static Mesh CombineWithSecondMeshAtDifferentPosition(Mesh a, Mesh b, Vector3 position)
        {
            var newMesh = new Mesh();
            var combineInstance = new CombineInstance[2];

            combineInstance[0].mesh = a;
            combineInstance[0].transform = Matrix4x4.identity;
            
            combineInstance[1].mesh = b;
            combineInstance[1].transform = Matrix4x4.Translate(position);
            
            newMesh.CombineMeshes(combineInstance);
            newMesh.RecalculateBounds();
            newMesh.RecalculateNormals();
            newMesh.RecalculateTangents();
            
            return newMesh;
        }

        public static Mesh CombineAllAtOrigin(params Mesh[] meshes)
        {
            var newMesh = new Mesh();
            var combineInstance = new CombineInstance[meshes.Length];

            for (var i = 0; i < meshes.Length; i++)
            {
                combineInstance[i].mesh = meshes[i];
                combineInstance[i].transform = Matrix4x4.identity;
            }
            
            newMesh.CombineMeshes(combineInstance);
            newMesh.RecalculateBounds();
            newMesh.RecalculateNormals();
            newMesh.RecalculateTangents();
            
            return newMesh;
        }
    }
}