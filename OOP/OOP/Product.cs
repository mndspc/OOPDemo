using System;

namespace OOP
{
    //  This class demo. how to create properties.
    class Product
    {
        private int proCode;
        /// <summary>
        /// Gets or Sets Product Name
        /// </summary>
        public int ProCode
        {
            get
            {
                return proCode;
            }
            set
            {
                if (value > 0)
                {
                    proCode = value;
                }
                else
                {
                    Console.WriteLine("Invalid Product Code");
                }
            }
        }

        /// <summary>
        /// Gets or Sets Product Name
        /// </summary>
        private string proName;

        public string ProName 
        {
            get {
                return proName;
            }
            set {
                proName = value;
            }
        }

        /// <summary>
        /// Gets Category
        /// </summary>
        public string Category
        {
            get
            {
                return "Grocery";
            }
        }

        /// <summary>
        /// Gets or Sets Hsn
        /// </summary>
        public  int ProHsn { get; set; }

        public ProType ProType { get; set; }


    }

    enum ProType
    {
        Commercial,NonCommerical
    }

    class Order
    {
        public int CustomerId { get; set; }

        public string OrderStatus { get; set; }
       
    }

    class Delivery
    {
        public int OrderNo { get; set; }

        public string PaymentType { get; set; }

        public Order OrderInfo { get; set; }
    }
}
