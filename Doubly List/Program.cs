using System;

namespace Doubly_List
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();
            //list.insertBeginning(313);
            list.insertBefore(8, 0);
            list.insertBefore(6, 8);
            list.insertBefore(16, 8);
            list.insertBefore(77, 8);
            list.insertBefore(44, 16);
            list.insertBefore(44, 222);
            // list.insertAfter(97, 8);
            // list.insertAfter(103, 23);
            // list.insertAfter(30, 16);
            // list.insertAfter(45, 44);
            // list.insertAfter(69, 103);
            // list.insertBeginning(317);
            // list.insertBeginning(399);
            // list.insertEnd(20);
            // list.delete(97);
            list.print();
        }
    }
}
