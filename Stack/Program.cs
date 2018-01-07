using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<String> stack = new Stack<String>(4);
            Console.WriteLine(stack.isEmpty());
            stack.push("HTMl");
            stack.push("CSS");
            stack.push("JavaScript");
            stack.push("C#");
            Console.WriteLine(stack.peek());
            stack.pop();
            Console.WriteLine(stack.peek());
            Console.WriteLine(stack.isEmpty());
        }
    }
}
