using System;

namespace StrategyPattern
{
    /// <summary>
    /// InsertionSorting.
    /// </summary>
    /// <seealso cref="StrategyPattern.ISorting" />
    public class InsertionSorting: ISorting
    {
        /// <summary>
        /// Sorts the specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        public void Sort(ref int[] array)
        {
            Console.WriteLine("InsertionSort");
            for (int i = 1; i < array.Length; i++)
            {
                int j = 0;
                int buffer = array[i];
                for (j = i - 1; j >= 0; j--)
                {
                    if (array[j] < buffer)
                        break;
                    array[j + 1] = array[j];
                }
                array[j + 1] = buffer;
            }
        }
    }
}
