using System;
using System.Collections;
using System.Collections.Specialized;

class istDictionary
{

	public static void Main()
	{

		ListDictionary myDict = new ListDictionary();

		myDict.Add("I", "first");
		myDict.Add("II", "second");
		myDict.Add("III", "third");
		myDict.Add("IV", "fourth");
		myDict.Add("V", "fifth");
		Console.WriteLine("Total key/value pairs in myDict are : "
												+ myDict.Count);

		Console.WriteLine("The key/value pairs in myDict are : ");

		foreach (DictionaryEntry de in myDict)
		{
			Console.WriteLine(de.Key + " " + de.Value);
		}

		myDict.Clear();
		Console.WriteLine("Total key/value pairs in myDict are : "
												+ myDict.Count);
		Console.WriteLine("The key/value pairs in myDict are : ");

		foreach (DictionaryEntry de in myDict)
		{
			Console.WriteLine(de.Key + " " + de.Value);
		}
	}
}

//Total key/value pairs in myDict are : 5
//The key/value pairs in myDict are :
//I first
//II second
//III third
//IV fourth
//V fifth
//Total key/value pairs in myDict are : 0
//The key/value pairs in myDict are
