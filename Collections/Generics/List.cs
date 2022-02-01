// C# Program to remove the element at
// the specified index of the List<T>
using System;
using System.Collections.Generic;

class Geeks
{

	// Main Method
	public static void Main(String[] args)
	{
		List<int> firstlist = new List<int>();

		firstlist.Add(17);
		firstlist.Add(19);
		firstlist.Add(21);
		firstlist.Add(9);
		firstlist.Add(75);
		firstlist.Add(19);
		firstlist.Add(73);

		Console.WriteLine("Elements Present in List:\n");

		int p = 0;
		foreach (int k in firstlist)
		{
			Console.Write("At Position {0}: ", p);
			Console.WriteLine(k);
			p++;
		}

		Console.WriteLine(" ");
		Console.WriteLine("Removing the element at index 3\n");
		firstlist.RemoveAt(3);

		int p1 = 0;
		foreach (int n in firstlist)
		{
			Console.Write("At Position {0}: ", p1);
			Console.WriteLine(n);
			p1++;
		}
	}
}
