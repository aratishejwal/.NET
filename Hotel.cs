using System;
class program
{
    public void AddDetails()
        {
            Console.WriteLine("Enter serialno:");
            int sr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Item name:");
            string item = Console.ReadLine();

            Console.WriteLine("Enter Quantity:");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter price in Rs for 1 quantity:");
            double price = Convert.ToDouble(Console.ReadLine());

            double Rs=quantity*price;
            
        }
        public void Display()
        {
            Console.WriteLine("|"+"\t"+sr + "\t" + item + "\t" + quantity + "\t\t" + Rs.+"\t"+"|");
        }

    public static void Main()
    {
 
        int choice;
            
        do
        {
            
            Console.WriteLine("1. Add Details\n");
            Console.WriteLine("2. Print Receipt\n");
            Console.WriteLine("-------------------------------------------------------------\n");
            Console.WriteLine("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
            case 1:
                Console.WriteLine("Enter the Number of Items:");
                int n = Convert.ToInt32(Console.ReadLine());

                Program[] p = new Program[n];
                for (int i = 0; i < n; i++)
                {
                    p[i] = new Program();
                    Console.WriteLine("Enter the Item Details " + (i + 1) + ":");
                    p[i].AddDetails();
                }
                break;
            case 2:
                DateTime Current=Date.Now;
                DateTime Current2=Time.Now;
                Console.WriteLine("__________________________________________________________________");
                Console.WriteLine("|                    SAI MUKUNDA HOTEL       Date:- "+ Current+"  |");
                Console.WriteLine("|                                            Time:- "+ Current2+" |");
                Console.WriteLine("|_________________________________________________________________|");
                Display();
                Console.WriteLine("|_________________________________________________________________|");
                Console.WriteLine("|                    Total:                                       |");
                Console.WriteLine("|_________________________________________________________________|");
                Console.WriteLine("|                THANK YOU VISIT AGAIN                            |");
                Console.WriteLine("|_________________________________________________________________|");
                     
                    }
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("\nTHANKS  YOU VISIT AGAIN");
        }while(choice!=2);
        
    }
 }