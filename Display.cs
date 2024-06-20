using System;
using System.Collections.Generic;

namespace SchoolManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Student Name:");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter Prn Number:");
            string prnNumber = Console.ReadLine();

            Console.WriteLine("Enter Branch:");
            string branch = Console.ReadLine();

            Console.WriteLine("Enter Year:");
            string Year = Console.ReadLine();

            Console.WriteLine("Enter Sem:");
            string sem=Console.ReadLine();

            
            string currentDate = DateTime.Now.ToString("dd-MM-yyyy");
            string currentTime = DateTime.Now.ToString("HH:mm:ss");

            
            string collegeName = "SANJIVANI COLLEGE OF ENGINEERING";
            string heading = "Academic Fees Receipt";

            
            var menu = new Dictionary<string,decimal>
            {
                { "Entrance",20000},
                { "Exams",15000},
                { "Library",20000},
                { "Hostel",35000},
                { "Laboratory",25000},
                {"Project&classes",25000}
            };

           
            
            string input;
            do
            {
                Console.WriteLine("Enter 'done' if fee is payed):");
                foreach(KeyValuePair<string,decimal> ele1 in menu)
                {
                    Console.WriteLine("{0}  {1}Rs",ele1.Key,ele1.Value);
                }
                input=Console.ReadLine();
                
                if (input.ToLower() != "done")
                {
                    Console.WriteLine("Invalid menu item.");
                }
            }
            while (input.ToLower() != "done");

            
            decimal totalBill = CalculateTotalBill(menu);
            decimal gstAmount = totalBill * 0.18m;
            decimal finalBill = totalBill + gstAmount;

            
            PrintBill(collegeName, currentDate, currentTime, heading, studentName, prnNumber, menu, totalBill, gstAmount, finalBill,branch,Year,sem);
        }

        static decimal CalculateTotalBill(Dictionary<string,decimal> menu)
        {
            decimal total = 0;
            foreach(KeyValuePair<string,decimal> ele2 in menu)
            {
                total += ele2.Value;
            }
            return total;
        }

        static void PrintBill(string collegeName, string currentDate, string currentTime, string heading, string studentName, string prnNumber, Dictionary<string,decimal> menu, decimal totalBill, decimal gstAmount, decimal finalBill,string branch,string Year,string sem)
        {
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("              "+collegeName+"               ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("              "+heading+"                   ");
            Console.WriteLine("Date: "+currentDate+"          Time: "+currentTime);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Customer Name: "+studentName);
            Console.WriteLine("Table Number: "+prnNumber);
            Console.WriteLine("Branch: "+branch);
            Console.WriteLine("Year/Sem:{0}/{1} ",Year,sem);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("{0,-15} {1,5}", "Title", "FEE");
            Console.WriteLine("------------------------------------------");

            foreach (var item in menu)
            {
                string itemName = item.Key;
                decimal price = menu[itemName];
                Console.WriteLine("{0,-15} {1,5}", itemName, price);
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("{0,-20} {1,20}", "Total (without GST):", totalBill+"Rs");
            Console.WriteLine("{0,-20} {1,20}", "GST @ 18%:", gstAmount+"Rs");
            Console.WriteLine("{0,-20} {1,20}", "Grand Total(with GST):", finalBill+"Rs");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("------------------------------------------");
        }
    }
}