using System;

namespace Ormona.Scripts
{
    [Serializable]
    public struct ChunkDataToSave
    {
        public int[] id;
        public int[] stability;
        public int planetId;
    }
}