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

        /// <summary>
        /// Plain addition, add each axis value alone.
        /// </summary>
        /// <param name="left">Chunk vector A.</param>
        /// <param name="right">Chunk vector B.</param>
        /// <returns>The result chunk vector.</returns>
        public static ChunkVec operator+(ChunkVec left, ChunkVec right)
        {
            return new ChunkVec(left.x + right.x, left.y + right.y, left.z + right.z, left.d + right.d);
        }

        /// <summary>
        /// Plain subtraction, subtract each axis value alone.
        /// </summary>
        /// <param name="left">Chunk vector A.</param>
        /// <param name="right">Chunk vector B.</param>
        /// <returns>The result chunk vector.</returns>
        public static ChunkVec operator-(ChunkVec left, ChunkVec right)
        {
            return new ChunkVec(left.x - right.x, left.y - right.y, left.z - right.z, left.d - right.d);
        }

        /// <summary>
        /// Plain multiply, multiply a number with each axis value alone.
        /// </summary>
        /// <param name="left">The vector.</param>
        /// <param name="right">The number.</param>
        /// <returns>The result chunk vector.</returns>
        public static ChunkVec operator*(ChunkVec left, BigInteger right)
        {
            return new ChunkVec(left.x * right, left.y * right, left.z * right, left.d * right);
        }

        /// <summary>
        /// Plain multiply, multiply a number with each axis value alone.
        /// </summary>
        /// <param name="left">The number.</param>
        /// <param name="right">The vector.</param>
        /// <returns>The result chunk vector.</returns>
        public static ChunkVec operator*(BigInteger left, ChunkVec right)
        {
            return right * left;
        }
    }
}
