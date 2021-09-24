using System;

namespace OOP
{
    //  This program demo. how to use static class.
    class StaticDemo
    {
        static void Main()
        {
            //  Errror
            //GstUtility gstUtility = new GstUtility();
            GstUtility.CalculateGst(10000, 8);
            Console.WriteLine($"Total Product Amount is:{GstUtility.TotalProAmount} and GST Amount is:{GstUtility.GstAmount}");
            Console.ReadLine();
        }
    }
}
