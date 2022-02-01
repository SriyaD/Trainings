using System;
using System.Collections;

namespace StackCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();

            s.Push(10);
            s.Push("hello");
            s.Push(3.14f);
            s.Push(true);
            s.Push(67.8);
            s.Push('A');
            foreach (object obj in s)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();

            Console.WriteLine(s.Pop());
            Console.WriteLine();

            foreach (object obj in s)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();

            Console.WriteLine(s.Peek());
            Console.WriteLine();

            foreach (object obj in s)
            {
                Console.Write(obj + " ");
            }

            Console.ReadKey();
        }
    }
}
