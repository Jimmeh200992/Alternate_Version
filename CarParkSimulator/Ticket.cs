using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Ticket
    {
        //ATTRIBUTES
        private bool paid;
        private int PIN = 99999999;

        //CONSTRUCTORS
        public Ticket()
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
    }
}
