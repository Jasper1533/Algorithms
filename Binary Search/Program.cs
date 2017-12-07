using System;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[] {1, 6, 9, 10, 15, 30};
            BinarySearch algorithm = new BinarySearch();
            Console.WriteLine(algorithm.search(values, 1));
        }
    }
}
