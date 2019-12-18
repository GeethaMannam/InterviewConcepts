using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewConcepts.Classes_Model
{
    public class Vehicle
    {
        public int WheelCount { get; set; }

        public int SeatCount { get; set; }

        public string color { get; set; }
        // Constructors will not have return types

        public string EngineType { get; set; }

        // We can set the " get only" properties inside the class but not outside the class.
        // we can use private fields to implement  get or set eloborately.
        public string  FuelType { get;  }
        public  Vehicle()
        {

        }

        public Vehicle(int WheelCount)
        {
            this.WheelCount = WheelCount;
        }

        public Vehicle(int WheelCount, string EngineType)
        {
            this.WheelCount = WheelCount;
            this.EngineType = EngineType;
            this.FuelType = EngineType;
        }

        public void DisplayMilage(int mileInfo)
        {
            // Some code interact with Screen to display Milage 

        }

    }
}
