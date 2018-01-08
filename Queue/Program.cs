using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<String> queue = new Queue<String>(4);
            Console.WriteLine(queue.isEmpty());
            queue.enqueue("HTMl");
            queue.enqueue("CSS");
            queue.enqueue("JavaScript");
            queue.enqueue("C#");
            Console.WriteLine(queue.peek());
            queue.dequeue();
            queue.enqueue("PHP");
            Console.WriteLine(queue.peek());
            Console.WriteLine(queue.isEmpty());
        }
    }
}
