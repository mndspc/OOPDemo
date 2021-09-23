using System;

namespace OOP
{
    //  This program demo. how to call overloaded functions.
    class FunctionOverloading
    {
        static void Main()
        {
            MyMath myMath = new MyMath();
            Console.WriteLine(myMath.Add(10, 30));
           Console.WriteLine( myMath.Add("Function ","Overloading"));
            Console.ReadLine();
        }
    }
}
