using System;
using System.Collections.Generic;

class LinkedListEx
{
	public static void Main(String[] ar)
	{ 
		LinkedList<String> link = new LinkedList<String>();

		link.AddFirst("B");
		link.AddFirst("3");
		link.AddFirst("B");

		link.AddLast("2");
		link.AddLast("c");
		link.AddFirst("1");


		Console.WriteLine("LinkedList<String> after adding objects: ");
		foreach (String element in link)
			Console.WriteLine(element);

		link.RemoveFirst();

		Console.WriteLine("After removing first element, LinkedList<String> is: ");
		foreach (String element in link)
			Console.WriteLine(element);	
		link.RemoveLast();

		Console.WriteLine("After removing Last element, LinkedList<String> is: ");
		foreach (String element in link)
			Console.WriteLine(element);


		link.Remove("2");
		Console.WriteLine("After removing 2, from LinkedList<String> is: ");
		foreach (String element in link)
			Console.WriteLine(element);
	}
}