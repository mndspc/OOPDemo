using System;


namespace OOP
{
    //  This program demo. how to call shadowed Functions.
    class FunctionShadowing
    {
        static void Main()
        {
            MyMath1 myMath1 = new MyMath1();
            Console.WriteLine(myMath1.Add(30.3, 20.6));
            Console.ReadLine();
        }
    }
}
