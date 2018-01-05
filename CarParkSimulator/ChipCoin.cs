using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ChipCoin
    {
        //ATTRIBUTES
        private bool paid;
        private int PIN = 99999999;  //default value used, made unreachable by standard entry
        private string regPlate = "";
        private int floor = 0;
        string timeStamp = "00:00";

        //CONSTRUCTORS
        public ChipCoin()
        {
            paid = false;
        }
        //FUNCTIONS
        public bool IsPaid()
        {
            return paid;
        }

        public void SetPaid(bool paid)
        {
            this.paid = paid;
        }

        public int GetPIN()
        {
            return PIN;
        }

        public void SetPIN(int PIN)
        {
            this.PIN = PIN;
        }

        public string GetRegPlate()
        {
            return regPlate;
        }

        public void SetRegPlate(string regPlate)
        {
            this.regPlate = regPlate;
        }

        public int GetCurrentFloor()
        {
            return floor;
        }

        public void SetCurrentFloor(int floor)
        {
            this.floor = floor;
        }

        public string GetTimeStamp()
        {
            return timeStamp;
        }

        public void SetTimeStamp(string timeStamp)
        {
            this.timeStamp = timeStamp;
        }
    }
}
