using System;
using System.Collections;

namespace ArrayListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Initial Capacity: " + al.Capacity);

            al.Add(10);
            Console.WriteLine("Capacity after adding first item: " + al.Capacity);

            al.Add("hello");
            al.Add(true);
            al.Add(3.14f);
            Console.WriteLine("Capacity after adding fourth item: " + al.Capacity);

            al.Add('A');
            Console.WriteLine("Capacity after adding 5th element: " + al.Capacity);

            for (int i = 0; i < al.Count; i++)
            {
                Console.Write(al[i] + "  ");
            }
            Console.WriteLine();
            al.Remove(true);

            foreach (object obj in al)
            {
                Console.Write(obj + "  ");
            }
            Console.WriteLine();
            al.Insert(2, false);

            foreach (object obj in al)
            {
                Console.Write(obj + "  ");
            }
            Console.WriteLine();
            ArrayList coll = new ArrayList(al);
            Console.WriteLine("Initial capacity of new array list collection:" + coll.Capacity);
            foreach (object obj in coll)
            {
                Console.Write(obj + "  ");
            }
            Console.ReadKey();
        }
    }
}

//using System.Collections;

//protected void Button1_Click(object sender, EventArgs e)
//{
//    ArrayList al = new ArrayList();
//    string str = "sriya";
//    int x = 7;
//    DateTime d = DateTime.Parse("8-oct-1985");
//    al.Add(str);
//    al.Add(x);
//    al.Add(d);

//    foreach (object o in al)
//    {
//        Response.Write(o);
//        Response.Write("<br>");
//    }
//}