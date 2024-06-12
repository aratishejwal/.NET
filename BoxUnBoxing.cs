using System;
namespace boxing
{
    class box
    {
        public static void Main(string[] args){
        int r=2;
        object o=r;
        object ob="Arati";

        String n=Convert.ToString(ob);
        Console.WriteLine("Roll:"+r);
        Console.WriteLine("Name:"+n);
        }
    }
}
