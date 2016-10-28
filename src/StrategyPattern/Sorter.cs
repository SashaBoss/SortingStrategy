using System;

namespace StrategyPattern
{
    /// <summary>
    /// The Sorter.
    /// </summary>
    public class Sorter
    {
        /// <summary>
        /// The _sorter
        /// </summary>
        private readonly ISorting _sorter;

        /// <summary>
        /// Initializes a new instance of the <see cref="Sorter"/> class.
        /// </summary>
        /// <param name="sorting">The sorting.</param>
        public Sorter(ISorting sorting)
        {
            _sorter = sorting;
        }

        /// <summary>
        /// Sorts the specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        public void Sort(ref int[] array)
        {
            _sorter.Sort(ref array);
        }

        /// <summary>
        /// Prints the result.
        /// </summary>
        /// <param name="array">The array.</param>
        public void PrintResult(int[] array)
        {
            foreach (int el in array)
            {
                Console.WriteLine("Element=" + el + "\n");
            }
        }
    }
}
