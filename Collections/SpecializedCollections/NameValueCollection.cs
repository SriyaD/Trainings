using System;
using System.Collections;
using System.Collections.Specialized;

public class NameValueCollectionDemo
{ 
    public static void Main()
    {

        NameValueCollection myCol = new NameValueCollection();
        
        myCol.Add("sriya", "Varma");
        myCol.Add("sriya", "Datla");
        myCol.Add("Sriya", "Varma");
        myCol.Add("Ajay", "Varma");
        
        for (int i = 0; i < myCol.Count; i++)
            Console.WriteLine( i+" " + myCol.GetKey(i)+" " +myCol.Get(i));
        Console.WriteLine();
    }
}

//0 sriya Varma, Datla, Varma
//1 Ajay Varma
