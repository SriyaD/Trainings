using System;
using System.Collections.Generic;

class QueueEx
{
	public static void Main(String[] ar)
	{
		Queue<int> dq = new Queue<int>();

		dq.Enqueue(10);
		dq.Enqueue(23);
		dq.Enqueue(16);
		dq.Enqueue(5);
		dq.Enqueue(29);
		Console.WriteLine("The contents of Queue<int>: ");
		foreach (int element in dq)
			Console.WriteLine(element);

		Console.WriteLine("Removing the front element = " + dq.Dequeue());
		Console.WriteLine("Removing the next front element = " + dq.Dequeue());

		Console.WriteLine("Peeking at the current front element = " + dq.Peek());


		Console.WriteLine("Updated contents of Queue<int>: ");
		foreach (int element in dq)
			Console.WriteLine(element);
	}
}