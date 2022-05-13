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
        public BigInteger X { get; set; }
        /// <summary>
        /// The y-axis value.
        /// </summary>
        public BigInteger Y { get; set; }
        /// <summary>
        /// The z-axis value.
        /// </summary>
        public BigInteger Z { get; set; }
        /// <summary>
        /// The dimension value.
        /// </summary>
        public BigInteger D { get; set; }
        
        /// <summary>
        /// Plain constructor initializing all values.
        /// </summary>
        /// <param name="x">The x-axis value.</param>
        /// <param name="y">The y-axis value.</param>
        /// <param name="z">The z-axis value.</param>
        /// <param name="d">The dimension value.</param>
        public ChunkVec(BigInteger x, BigInteger y, BigInteger z, BigInteger d)
        {
            X = x;
            Y = y;
            Z = z;
            D = d;
        }

        /// <summary>
        /// Get the squared magnitude of this vector.
        /// </summary>
        /// <returns>The squared magnitude of this vector.</returns>
        public BigInteger GetSquaredMagnitude()
        {
            return X * X + Y * Y + Z * Z + D * D;
        }

        /// <summary>
        /// Plain addition, add each axis value alone.
        /// </summary>
        /// <param name="left">Chunk vector A.</param>
        /// <param name="right">Chunk vector B.</param>
        /// <returns>The result chunk vector.</returns>
        public static ChunkVec operator+(ChunkVec left, ChunkVec right)
        {
            return new ChunkVec(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.D + right.D);
        }

        /// <summary>
        /// Plain subtraction, subtract each axis value alone.
        /// </summary>
        /// <param name="left">Chunk vector A.</param>
        /// <param name="right">Chunk vector B.</param>
        /// <returns>The result chunk vector.</returns>
        public static ChunkVec operator-(ChunkVec left, ChunkVec right)
        {
            return new ChunkVec(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.D - right.D);
        }

        /// <summary>
        /// Plain multiply, multiply a number with each axis value alone.
        /// </summary>
        /// <param name="left">The vector.</param>
        /// <param name="right">The number.</param>
        /// <returns>The result chunk vector.</returns>
        public static ChunkVec operator*(ChunkVec left, BigInteger right)
        {
            return new ChunkVec(left.X * right, left.Y * right, left.Z * right, left.D * right);
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
