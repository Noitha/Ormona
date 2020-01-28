using System;
using UnityEngine;

namespace Ormona.Planets
{
    [Serializable]
    public struct MeshData
    {
        public Vector3[] vertices;
        public Vector3[] normals;
        public Vector2[] uvs;
        public int[] triangles;
    }
}