
using System;
using System.Collections;
using System.Collections.Specialized;

public class HybridDictionaryDemo
{

	public static void Main()
	{
        HybridDictionary myDict = new HybridDictionary(10, false); // initail size, case sentivity

        myDict.Add("I", "first");

        // This will not raise exception as the Collection is not case-insensitive
        myDict.Add("i", "first");
        myDict.Add("II", "second");
        myDict.Add("III", "third");
        myDict.Add("IV", "fourth");
        myDict.Add("V", "fifth");

        foreach (DictionaryEntry de in myDict)
            Console.WriteLine(de.Key + " " + de.Value);
    }
}

//IV fourth
//I first
//i first
//II second
//III third
//V fifth