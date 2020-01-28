using System.Collections.Generic;
using UnityEngine;

namespace Ormona.Planets
{
    public struct EntityGroup
    {
        public readonly GameObject parent;
        public readonly List<MeshAndPosition> meshAndPosition;
        
        public EntityGroup(GameObject parent)
        {
            this.parent = parent;
            meshAndPosition = new List<MeshAndPosition>();
        }
    }
}