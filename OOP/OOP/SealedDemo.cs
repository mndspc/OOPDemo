using System;


namespace OOP
{
    //  This program demo. how to use sealed class.
    class SealedDemo
    {
        static void Main()
        {
            FourWheeler tata = new FourWheeler(2344,"Indica","2000");
            Console.WriteLine(tata.AboutVehicle());
            Console.ReadLine();
        }

    }
}
