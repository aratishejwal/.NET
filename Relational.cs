using System;

namespace MyApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your age:");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you have voter Id?yes or no:");
            string Voter=Console.ReadLine();
            if(age>0){
                if(age==18&&Voter=="no"){
                Console.WriteLine("Allow for Voter Id Card issue");
                }
                else if(age!=18&&Voter=="no")
                {
                    Console.WriteLine("Not Allowed for Voter Id card issue");
                }
                else if(age>=18&&Voter=="yes"){
                    Console.WriteLine("Allowed for Voting");
                }
                else if(age<=18)
                {
                    Console.WriteLine("Not allowed for Voting");
                }
            }
            else{
                Console.WriteLine("Invalid Age");
            }
        }
    }
}