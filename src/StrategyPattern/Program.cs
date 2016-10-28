using System;

namespace StrategyPattern
{
    /// <summary>
    /// The Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            var array = new int[] {2, 5, 6, 1, 32, 21};
            var sorter = new Sorter(new InsertionSorting())
                ;
            sorter.Sort(ref array);
            sorter.PrintResult(array);
            Console.ReadLine();
        }
    }
}
