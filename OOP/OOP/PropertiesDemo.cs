using System;


namespace OOP
{
    //  This program demo. how to use properties.
    class PropertiesDemo
    {
        static void Main()
        {
            Product product1 = new Product {ProCode=0,ProName="HDD",ProHsn=34324234,ProType=ProType.Commercial };
            Console.WriteLine($"Code={product1.ProCode}\nName={product1.ProName}\nCategory={product1.Category}\nHsn={product1.ProHsn}\nPro-Type={product1.ProType}");

            
            Order order1 = new Order {CustomerId=123,OrderStatus="Confirmed" };
            Delivery delivery1 = new Delivery {OrderNo=123,PaymentType="COD",OrderInfo= order1};
            Console.ReadLine();
        }
    }
}
