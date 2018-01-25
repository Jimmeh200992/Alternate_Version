using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ChipCoin
    {
        //ATTRIBUTES
        private bool paid, lost, faulty;
        private int PIN = 99999999;  //default value used, made unreachable by standard entry
        private string regPlate = "";
        private int floor = 0;
        int timeStamp = 0;
        private bool parked = false;

        //CONSTRUCTORS
        public ChipCoin()
        {
            paid = false;
            lost = false;
            faulty = false;
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

        public int GetTimeStamp()
        {
            return timeStamp;
        }

        public void SetTimeStamp(int timeStamp)
        {
            this.timeStamp = timeStamp;
        }

        public int ExtractMinutes()
        {
            int coinMinutes = timeStamp % 100;
            return coinMinutes;
        }

        public int ExtractHours()
        {
            int coinHours = timeStamp / 100;
            return coinHours;
        }

        public bool IsParked()
        {
            return parked;
        }

        public void SetParked(bool parked)
        {
            this.parked = parked;
        }

        public bool IsLost()
        {
            return lost;
        }
        public void SetLost(bool lost)
        {
            this.lost = lost;
        }
        public bool IsFaulty()
        {
            return faulty;
        }
        public void SetFaulty(bool faulty)
        {
            this.faulty = faulty;
        }
    }
}
