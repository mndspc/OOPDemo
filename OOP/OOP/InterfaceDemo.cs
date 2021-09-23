using System;


namespace OOP
{
    //  This program demo. how to call interface with explicit and implicit implementation.
    class InterfaceDemo
    {
        static void Main()
        {
            //  Calling Explicite implementation
            //IWifi wifi = new NokiaLumia();
            //Console.WriteLine(wifi.StartWifi());
            //Console.WriteLine(wifi.StopWifi());

            //  Calling Implicit implementation

            NokiaLumia nokiaLumia = new NokiaLumia();
            Console.WriteLine(nokiaLumia.Calling());
            Console.WriteLine(nokiaLumia.SMS());
            Console.WriteLine(nokiaLumia.StartWifi());
            Console.WriteLine(nokiaLumia.StopWifi());
            Console.WriteLine(nokiaLumia.PushMessage());
            //nokiaLumia.TrubleShoot();
            Console.ReadLine();
        }
    }
}
