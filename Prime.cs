using System;
	
class Prime 
{

//function to check if a given number is prime
    static bool isPrime(int n){
        if(n==1||n==0)return false;

	    
	    for(int i=2; i<=n/2; i++){
		
		if(n%i==0)return false;
	    }
    
    return true;
    }

 
    public static void Main (String[] args) 
    { 
        Console.WriteLine("Enter number upto which you want prime number:");
	    int N =Convert.ToInt32(Console.ReadLine()); 
	    //check for every number from 1 to N
	    for(int i=1; i<=N; i++){
	    //check if current number is prime
	    if(isPrime(i)) {
		    Console.Write(i + " "); 
	    }
	    }
	
    }
}

