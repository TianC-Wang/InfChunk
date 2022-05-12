using System.Numerics;

namespace InfChunk
{
    /// <summary>
    /// A vector of chunks.
    /// </summary>
    public struct ChunkVec
    {
        /// <summary>
        /// The x-axis value.
        /// </summary>
        public BigInteger x;
        /// <summary>
        /// The y-axis value.
        /// </summary>
        public BigInteger y;
        /// <summary>
        /// The z-axis value.
        /// </summary>
        public BigInteger z;
        /// <summary>
        /// The dimension value.
        /// </summary>
        public BigInteger d;
        
        /// <summary>
        /// Plain constructor initializing all values.
        /// </summary>
        /// <param name="x">The x-axis value.</param>
        /// <param name="y">The y-axis value.</param>
        /// <param name="z">The z-axis value.</param>
        /// <param name="d">The dimension value.</param>
        public ChunkVec(BigInteger x, BigInteger y, BigInteger z, BigInteger d)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.d = d;
        }

        /// <summary>
        /// Get the squared magnitude of this vector.
        /// </summary>
        /// <returns>The squared magnitude of this vector.</returns>
        public BigInteger GetSquaredMagnitude()
        {
            return x * x + y * y + z * z + d * d;
        }

    }
}
