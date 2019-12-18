using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewConcepts.Classes_Model
{
    public class Car : Vehicle
    {
        public int DoorCount { get; set; }
        public Car() :base()
        {
            
        }

        // Constructors are not class members , so can't be inherited , 
        //so have to call them using base keyword if needed
        public Car(int wheelCount, string EngineType) : base( wheelCount,EngineType)
        {

        }
    }
}
