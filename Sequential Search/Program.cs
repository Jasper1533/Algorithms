using System;

namespace Sequential_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[] {4, 1, 8, 2, 7};
            SequentialSearch algorithm = new SequentialSearch();
            Console.WriteLine(algorithm.search(values, 30));
        }
    }
}
