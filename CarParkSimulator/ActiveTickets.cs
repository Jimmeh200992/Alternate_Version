using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ActiveTickets
    {
        //ATTRIBUTES
        private List<Ticket> tickets;       //List to hold all tickets.

        //CONSTRUCTOR
        public ActiveTickets()
        {
            tickets = new List<Ticket>();      //Creates a new list.
        }
        
        //OPERATIONS
        public void AddTicket(int PIN)
        {
            tickets.Add(new Ticket());          //Creates a new ticket and adds to list.
            SetTicketPIN(PIN);
        }

        public List<Ticket> GetTickets()
        {
            return tickets;                     //Returns the list.
        }

        public void RemoveTicket(int ticketCode)
        {
            //Checks all tickets currenty active.
            foreach (Ticket ticket in tickets)
            {
                //Checks if the Hashcodes match.
                if (ticketCode == ticket.GetHashCode())                        
                {
                    //Removes that ticket from the list
                    tickets.Remove(ticket);
                    break;
                }
            }
        }

        public void SetTicketPIN(int PIN)
        {
            foreach (Ticket ticket in tickets)
            {
                int checkValue = ticket.GetPIN();
                if (checkValue == 99999999)
                    ticket.SetPIN(PIN);
            }
        }
    }
}
