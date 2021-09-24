using System;


namespace OOP
{
    //  This program demo. how to use abstract class.
    class AbstractDemo
    {
        static void Main()
        {
            //  Error
            //Vehicle vehicle = new Vehicle();
            TwoWheeler yamaha = new TwoWheeler(123,"Rx-100","1995");
            Console.WriteLine(yamaha.AboutVehicle());
            Console.WriteLine(yamaha.Start());
            Console.WriteLine(yamaha.Stop());
            Console.WriteLine(yamaha.FuelType("Petrol"));
            yamaha.StartType = "Self";
            Console.WriteLine($"This two wheeler has {yamaha.StartType} start");
            Console.ReadLine();
        }
    }
}
