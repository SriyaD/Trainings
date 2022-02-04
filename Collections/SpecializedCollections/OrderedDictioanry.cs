using System;
using System.Collections;
using System.Collections.Specialized;

public class OrderedDictionaryDemo
{
    public static void Main(string[] args)
    {
        OrderedDictionary od = new OrderedDictionary();
        od.Add(false, "One");
        od.Add(1, "One");
        od.Add("3", "Three");
        od.Add("Four", 4);
        od.Add("Five", "Five");
        od.Add("sriya", null);

        //od.Add(null, "Sriya");//error

        for (int i = 0; i < od.Count; i++)
        {
            Console.WriteLine(od[i]);
        }
        foreach (DictionaryEntry item in od)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}

//One
//One
//Three
//4
//Five

//False : One
//1 : One
//3 : Three
//Four : 4
//Five: Five
//sriya :