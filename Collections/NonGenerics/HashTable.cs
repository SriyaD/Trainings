using System;
using System.Collections;

namespace HashTableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("EId", 1001); 
            ht.Add("Name", "Sriya"); 
            ht.Add("Job", "Developer");
            ht.Add("Salary", 3500);
            ht.Add("Location", "AP");
            ht.Add("Dept", "IT");
            ht.Add("EmailID", "a@a.com");

            Console.WriteLine("Printing using Foreach loop");
            foreach (object obj in ht.Keys)
            {
                Console.WriteLine(obj + " : " + ht[obj]);
            }

            Console.WriteLine();
            Console.WriteLine("Printing using Keys");
            Console.WriteLine("Location : " + ht["Location"]);
            Console.WriteLine("Emaild ID : " + ht["EmailID"]);

            Console.ReadKey();
        }
    }
}



//using System;
//using System.Collections;

//namespace HasntableExample
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Hashtable ht = new Hashtable();

//            ht.Add("EId", 1001);
//            ht.Add("Name", "Srita"); 
//            ht.Add("Job", "Developer");
//            ht.Add("Salary", 3500);
//            ht.Add("Location", "AP");
//            ht.Add("Dept", "IT");
//            ht.Add("EmailID", "a@a.com");
//            Console.WriteLine("Is EmailID Key Exists : " + ht.ContainsKey("EmailID"));
//            Console.WriteLine("Is Department Key Exists : " + ht.ContainsKey("Department"));

//            Console.WriteLine("Is Mumbai value Exists : " + ht.ContainsValue("Mumbai"));
//            Console.WriteLine("Is Technology value Exists : " + ht.ContainsValue("Technology"));

//            Console.ReadKey();
//        }
//    }
//}