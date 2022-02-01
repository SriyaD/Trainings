using System;
using System.Collections.Generic;

class SortedListDemo
{
	public static void Main(String[] ar)
	{
		SortedList<String, int> sl = new SortedList<String, int>();

		sl.Add("Max", 1000);
		sl.Add("John", 4000);
		sl.Add("Tom", 2000);
		sl.Add("Ana", 6000);
		sl.Add("Rick", 5000);

		ICollection<String> c = sl.Keys;
		Console.WriteLine("The sorted key-value pairs of SortedList<String, Key>:");
		foreach (String str in c)
			Console.WriteLine(str + ": " + sl[str]);

		Console.WriteLine("Value at the key, Tom is " + sl["Tom"]);
		Console.WriteLine("Value at the key, Ana is " + sl["Ana"]);
	}
}