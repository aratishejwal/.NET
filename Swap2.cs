using System; 

class Swap { 
	public static void Main() 
	{ 
        Console.WriteLine("Enter the two number for swapping:");
		int p = Convert.ToInt32(Console.ReadLine()); 
		int q = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Before Swapping:");
        Console.WriteLine("P="+p);
        Console.WriteLine("Q="+q);

		p = p + q; 
		q = p - q; 
		p = p - q; 
		Console.WriteLine("After swapping: P= " + p 
						+ ", Q = " + q); 
	} 
} 


