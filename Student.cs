using System;
namespace Students
{
    public struct Student
    {
        public int sr,sem;
        public string Branch,Name,Collage;
    }
    public class Record{
        static void Main(string[] args){
            Student[] s = new Student[100];
            int c,n,sc=0;
            do{
                Console.WriteLine("Enter:\n1.Add Student \n2.Delete Student\n3.Display Record\n4.Modify Record");
                c=Convert.ToInt32(Console.ReadLine());
                switch(c){
                    
                    case 1:
                        Console.WriteLine("How many records do you want to enter:");
                        n=Convert.ToInt32(Console.ReadLine());
                        
                        for(int i=0;i<n;i++){
                            Console.WriteLine("Enter Detail:"+(sc+1));
                            s[sc].sr=Convert.ToInt32(Console.ReadLine());
                            s[sc].Name=Console.ReadLine();
                            s[sc].Branch=Console.ReadLine();
                            s[sc].sem=Convert.ToInt32(Console.ReadLine());
                            s[sc].Collage=Console.ReadLine();
                            sc++;
                        }
                        break;
                    case 2:
                        Console.WriteLine("-------------------------Student Record----------------------");
                        Console.WriteLine("Srno\t\tName\t\tBranch\t\tSem\t\tCollage");
                        for(int i=0;i<sc;i++)
                        {
                            Console.WriteLine(s[i].sr+ "\t\t" +s[i].Name+ "\t\t" +s[i].Branch+ "\t\t" +s[i].sem+ "\t\t" +s[i].Collage);
                        }
                        break;

                    }
            
                    


            }while(c!=5);
            
        }
    }
}
