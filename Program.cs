using System;
using System.Collections.Generic;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> items = new Stack<string>();
            items.Push("Laptop-001");
            items.Push("Laptop-002");
            items.Push("Laptop-003");

            Console.WriteLine(items.Pop());
            Console.WriteLine(items.Pop());
            Console.WriteLine(items.Pop());
        }
    }
}
