using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Sensor
    {
        //ATTRIBUTES
        protected bool CarOnSensor;
        protected CarPark carPark;
        private bool faulty;

        // CONSTRUCTORS
        public Sensor()
        {
            CarOnSensor = false;
        }

        // OPERATIONS
        public bool IsCarOnSensor()
        {
            return CarOnSensor;
        }

        public virtual void CarDetected()
        {
            this.CarOnSensor = true;
        }

        public virtual void CarLeftSensor()
        {
            this.CarOnSensor = false;
        }
    }
}
