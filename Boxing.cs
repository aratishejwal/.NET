using System;
namespace Boxing
{

class Box{

   static void Main()
    {
        //Boxing
        int num=24;

        object obj=num;

        Console.WriteLine("Boxing:");
        Console.WriteLine("ValueType:" + num);
        Console.WriteLine("BoxedValue:" +obj);

        //Unboxing

        object obj2=56;
        int num2=(int)obj2;
        Console.WriteLine("UnBoxing:");
        Console.WriteLine("Boxed Value:"+obj2);
        Console.WriteLine("UnBoxed Value:"+num2);


    }
}
}