namespace InfChunk.Interface
{
    /// <summary>
    /// An interface provides saving to bytes and loading from bytes operations.
    /// </summary>
    public interface ISaveLoad
    {
        /// <summary>
        /// Save the data to bytes.
        /// </summary>
        /// <param name="data">The data.</param>
        void SaveData(out byte[] data);

        /// <summary>
        /// Load the data from bytes.
        /// </summary>
        /// <param name="data">The data.</param>
        void LoadData(byte[] data);
    }
}
