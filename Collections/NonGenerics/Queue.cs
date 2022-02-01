using System;
using System.Collections;

namespace QueueCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue(10);
            q.Enqueue("hi");
            q.Enqueue(3.14f);
            q.Enqueue(true);
            q.Enqueue(67.8);
            q.Enqueue('A');

            foreach (object obj in q)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"No of Elements Present in the Collection : {q.Count}");
            Console.WriteLine();

            Console.WriteLine($"Is the value hi present in the collection : {q.Contains("hi")}");
            Console.WriteLine();

            q.Clear();
            Console.WriteLine($"No of Elements in the Collection after Clear() method : {q.Count}");

            Console.ReadKey();
        }
    }
}