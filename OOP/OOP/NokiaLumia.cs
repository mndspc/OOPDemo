using System;

namespace OOP
{
    //  This class demo. how to implement multiple inheritance.
    class NokiaLumia : MobilePhone, IWifi
    {
        #region Explicit Emplmentation
        //string IWifi.StartWifi()
        //{
        //    return "Startting WIFI";
        //}

        //string IWifi.StopWifi()
        //{
        //    return "Stopping Wifi";
        //}

        //string IWifi.TrubleShoot()
        //{
        //    throw new NotImplementedException();
        //}
        #endregion

        #region Implicit Implementation
            public string StartWifi()
            {
                return "Startting WIFI";
            }

            public string StopWifi()
            {
                return "Stopping Wifi";
            }

            public string TrubleShoot()
            {
                throw new NotImplementedException();
            }
        #endregion
        public string PushMessage()
        {
            return "PushMessage() calling from NokiaLumia";
        }

        
    }
}
