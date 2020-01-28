using System;

namespace Ormona.Planets.Scripts
{
    [Serializable]
    public class ChunkEntity
    {
        public int stability;
        
        public byte selfNeighbourPattern;
        public NeighbourPatterns neighbourPatterns;
        public BaseEntity entity;
        
        public ChunkEntity(BaseEntity entity)
        {
            this.entity = entity;
            stability = entity.stability;
        }
    }
}