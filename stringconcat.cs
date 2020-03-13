using System;

class StringTest
{
	public static void Main()
	{
	    Int32 var1 = 10;
		object obj = var1; // boxing 
        
		Int32 var2 = (Int32)obj; // unboxing;
		
		var2 + 1;
	}
}


Queue myqueue = new Queue();

Queue<T> myqueue = new Queue<T>(); 

Queue<Int32> myqueue = new Queue<Int32>();
Queue<string> myqueue = new Queue<string>();

/*
1) Array:- a collection of "homogeneous items" arranged in a sequence.

*/


