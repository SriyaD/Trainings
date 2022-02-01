
using System;
using System.Collections.Generic;

class HashSetEx
{
	public static void Main(String[] ar)
	{
		HashSet<String> hash = new HashSet<String>();

		hash.Add("B");
		hash.Add("3");
		hash.Add("G");
		hash.Add("C");
		hash.Add("1");

		Console.WriteLine("The contents of HashSet<String>: ");
		foreach (string element in hash)
			Console.WriteLine(element);
		Console.WriteLine("Size of HashSet<String> = " + hash.Count);

		hash.Remove("G");

		Console.WriteLine("After removing element G, HashSet<String>: ");
		foreach (string element in hash)
			Console.WriteLine(element);
		Console.WriteLine("Size of updated HashSet<String> = " + hash.Count);
		HashSet<String> hash2 = new HashSet<String>(hash);

		Console.WriteLine("The contents of new HashSet<String> created from the first HashSet<String>: ");
		foreach (string element in hash2)
			Console.WriteLine(element);
		Console.WriteLine("Size of the newly created HashSet<String> = " + hash.Count);
	}
}