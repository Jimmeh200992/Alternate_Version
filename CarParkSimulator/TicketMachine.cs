using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;

namespace CarParkSimulator
{
    class TicketMachine
    {
        //ATTRIBUTES
        private string message;
        private ActiveTickets tickets;
        private CarPark carPark;

        //CONSTRUCTOR
        public TicketMachine(ActiveTickets tickets)
        {
            this.tickets = tickets;
        }
        //OPERATIONS
        public void AssignCarPark(CarPark carPark)  //Machine constructed after CarPark, thus needs an extra function.
        {
            this.carPark = carPark;
        }

        public void CarArrived()
        {
            message = "Please press to get a ticket.";
        }

        public void PrintTicket()
        {
            string PINEntry = Microsoft.VisualBasic.Interaction.InputBox("Please enter a PIN for your secure parking");  //requests PIN entry
            int.TryParse(PINEntry, out int PIN);  //parses string to int
            message = "Thank you, enjoy your stay.";
            tickets.AddTicket(PIN);  //creates ticket, passing PIN
            carPark.TicketDispensed();
        }

        public void ClearMessage()
        {
            message = "";
        }

        public string GetMessage()
        {
            return message;
        }
    }
}
