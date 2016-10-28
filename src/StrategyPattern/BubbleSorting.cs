using System;

namespace StrategyPattern
{
    /// <summary>
    /// BubbleSorting
    /// </summary>
    /// <seealso cref="StrategyPattern.ISorting" />
    public class BubbleSorting : ISorting
    {
        /// <summary>
        /// Sorts the specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        public void Sort(ref int[] array)
        {
            Console.WriteLine("BubbleSort");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
        }
    }
}
