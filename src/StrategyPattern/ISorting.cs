namespace StrategyPattern
{
    /// <summary>
    /// The sorting interface.
    /// </summary>
    public interface ISorting
    {
        /// <summary>
        /// Sorts the specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        void Sort(ref int[] array);
    }
}
