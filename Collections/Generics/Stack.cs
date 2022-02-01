

using System;
using System.Collections.Generic;

class StackEx
{
	public static void Main(String[] ar)
	{
		Stack<int> st = new Stack<int>();
		st.Push(10);
		st.Push(32);
		st.Push(12);
		st.Push(3);
		st.Push(27);

		Console.WriteLine("The contents of Stack<int>: ");
		foreach (int element in st)
			Console.WriteLine(element);


		Console.WriteLine("Popping out the top element = " + st.Pop());
		Console.WriteLine("Popping out the next top element = " + st.Pop());

		Console.WriteLine("Peeking at the current top element = " + st.Peek());

		Console.WriteLine("The updated contents of Stack<int>: ");
		foreach (int element in st)
			Console.WriteLine(element);
	}
}