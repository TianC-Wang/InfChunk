using System;
using System.Numerics;

namespace InfChunk
{
    /// <summary>
    /// A chunk model.
    /// </summary>
    public class Chunk : ISaveLoad
    {
        /// <summary>
        /// The size of each chunk in each axis.
        /// </summary>
        public static BigInteger Size = 16;

        /// <summary>
        /// The position of this chunk.
        /// </summary>
        private ChunkVec position;

        /// <summary>
        /// The position of this chunk.
        /// </summary>
        public ChunkVec Position => position;

        public void SaveData(out byte[] data)
        {
            throw new NotImplementedException();
        }

        public void LoadData(byte[] data)
        {
            throw new NotImplementedException();
        }
    }
}
