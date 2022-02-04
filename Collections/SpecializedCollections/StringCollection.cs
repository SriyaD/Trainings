// C# code to create a StringCollection
using System;
using System.Collections;
using System.Collections.Specialized;

class StringCollectionDemo
{

	public static void Main()
	{
		StringCollection myCol = new StringCollection();

		myCol.Add("A");
		myCol.Add("sriya");
		myCol.Add(null);
		myCol.Add("sriya");
		myCol.Add("b");

		foreach (Object obj in myCol)
		{
			Console.WriteLine(obj);
		}
	}
}

//A
//sriya

//sriya
//b
