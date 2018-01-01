using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.insert(12);
            list.insert(34);
            list.insert(22);
            list.insert(66);
            list.insert(6);
            list.delete(6);
            list.print();
            Console.WriteLine(list.search(6));
        }
    }
}
