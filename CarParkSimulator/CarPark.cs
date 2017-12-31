using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class CarPark
    {
        //ATTRIBUTES
        private int currentSpaces;
        private const int maxSpaces = 5;

        private TicketMachine ticketMachine;
        private TicketValidator ticketValidator;
        private Barrier entryBarrier;
        private Barrier exitBarrier;
        private FullSign fullSign;

        //CONSTRUCTOR
        public CarPark (TicketMachine ticketMachine, TicketValidator ticketValidator, FullSign fullSign, Barrier entryBarrier, Barrier exitBarrier)
        {
            this.ticketMachine = ticketMachine;
            this.ticketValidator = ticketValidator;
            this.fullSign = fullSign;
            this.entryBarrier = entryBarrier;
            this.exitBarrier = exitBarrier;
            currentSpaces = maxSpaces;
        }

        //OPERATIONS
        public void CarArrivedAtEntrance()
        {
            ticketMachine.CarArrived();
        }

        public void TicketDispensed()
        {
            entryBarrier.Raise();
        }

        public void CarEnteredCarpark()
        {
            entryBarrier.Lower();
            ticketMachine.ClearMessage();
            currentSpaces = currentSpaces - 1;      //A car takes up a parking space.
            fullSign.SetLit(IsFull());
        }

        public void CarArrivedAtExit()
        {
            ticketValidator.CarArrived();
        }

        public void TicketValidated()
        {
            exitBarrier.Raise();
        }

        public void CarExitedCarpark()
        {
            exitBarrier.Lower();
            ticketValidator.ClearMessage();
            currentSpaces = currentSpaces + 1;      //A parking space is now free.
            fullSign.SetLit(IsFull());
        }

        public bool IsFull()
        {
            if (currentSpaces == 0)
            {
                return true;
            }
            else
                return false;
            
        }

        public bool IsEmpty()
        {
            if (currentSpaces == maxSpaces)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasSpace()
        {
            if (currentSpaces > 0)
            {
                return true;
            }
            else
                return false;
        }

        public int getCurrentSpaces()
        {
            return currentSpaces;
        }
    }
}
