
using System;
using System.Collections;
using System.Collections.Specialized;

public class StringDictionaryDemo
{
	public static void Main()
	{
		StringDictionary myDict = new StringDictionary();

		myDict.Add("Sriya", "Datla");
		myDict.Add("Ajay", "Varma");
		myDict.Add("Sagun", "Jaiswal");
		myDict.Add("Salman", "Tella");

		foreach (DictionaryEntry item in myDict)
		{
			Console.WriteLine(item.Key + " : " + item.Value);
		}

		Console.WriteLine("Total key/value pairs in myDict are : "
											+ myDict.Count);
	}
}

//sriya: Datla
//salman : Tella
//ajay : Varma
//sagun : Jaiswal
//Total key/value pairs in myDict are : 4