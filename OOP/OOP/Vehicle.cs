using System;


namespace OOP
{
  public abstract class Vehicle
    {
        public int ModelNo { get; set; }
        public string ModelName { get; set; }
        public string Year { get; set; }

        public abstract string StartType { get; set; }
        public Vehicle(int modelNo,string modelName,string year)
        {
            this.ModelNo = modelNo;
            this.ModelName = modelName;
            this.Year = year;
        }

        public string AboutVehicle()
        {
            return $"Model No={this.ModelNo} Name={this.ModelName} Year={this.Year}";
        }
        public string Start()
        {
            return "Start() calling from Vehicle";
        }
        public string Stop()
        {
            return "Stop() calling from Vehicle";
        }

        public abstract string FuelType(string fuleType);
    }

    class TwoWheeler : Vehicle
    {
        private string startType;
        public TwoWheeler(int modelNo, string modelName, string year) :base(modelNo, modelName, year)
        {
            
        }
        /// <summary>
        /// This is implementation of abstract property
        /// </summary>
        public sealed override string StartType 
        { 
            get 
            {
                return startType;
            } 
            set {
                startType = value;
            } 
        }

        /// <summary>
        /// This is implementation of abstract method.
        /// </summary>
        /// <param name="fuelType"></param>
        /// <returns></returns>
        public override string FuelType(string fuelType)
        {
            return $"This two wheeler is {fuelType}";
        }

        public string Stroke(int noOfStroke)
        {
            return $"This is {noOfStroke} Two Twheeler";
        }
    }
    class ThreeWheeler : TwoWheeler
    {
        public ThreeWheeler(int modelNo, string modelName, string year) : base(modelNo, modelName, year)
        {

        }
        public sealed override string FuelType(string fuelType)
        {
            return $"This Three wheeler is {fuelType}";
        }
    }
  sealed  class FourWheeler : ThreeWheeler
    {
        public FourWheeler(int modelNo, string modelName, string year) : base(modelNo, modelName, year)
        {

        }
       
    }

    //Error
    //class SixWheeler : FourWheeler
    //{

    //}
}
