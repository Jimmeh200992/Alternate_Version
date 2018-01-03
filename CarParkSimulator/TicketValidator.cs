using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarParkSimulator
{
    class TicketValidator
    {
        //ATTRIBUTES
        private string message;
        private ActiveTickets tickets;
        private CarPark carPark;

        //CONSTRUCTOR
        public TicketValidator(ActiveTickets tickets)
        {
            this.tickets = tickets;
        }
        //OPERATIONS
        public void AssignCarPark(CarPark carPark)   //Machine constructed after CarPark, thus needs an extra function.
        {
            this.carPark = carPark;
        }

        public void CarArrived()
        {
            message = "Please insert your ticket.";
        }

        public TicketPaid TicketEntered(int ticketCode)
        {

            foreach (Ticket ticket in tickets.GetTickets())  //loops through all active tickets
            {
                if (ticket.GetHashCode() == ticketCode)  //checks inputted hashcode against ticket hashcodes
                {
                    if (ticket.IsPaid() == true)  //on success, checks against whether ticket is paid
                    {
                        message = "Thank you, drive safely.";
                        tickets.RemoveTicket(ticketCode);
                        carPark.TicketValidated();
                        return TicketPaid.TICKET_REMOVED;  //presents message and removes ticket if ticket already paid
                    }
                    else //otherwise, requests PIN entry to authorise payment
                    {
                        string PINEntry = Microsoft.VisualBasic.Interaction.InputBox("Please enter your secure parking PIN");
                        int.TryParse(PINEntry, out int PIN);
                        if (ticket.GetPIN() != PIN)
                        {
                            message = "Invalid PIN, please reinsert your ticket";
                            return TicketPaid.NOT_VALID;  //if PIN incorrect, returns system to point where car due to arrive at barrier
                        }
                        else
                        {
                            MessageBoxManager.OK = "Present card"; MessageBoxManager.Cancel = "Pay by cash"; MessageBoxManager.Register();
                            if (MessageBox.Show("Please pay by card.", "PayByCard", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                message = "Thank you, drive safely.";
                                tickets.RemoveTicket(ticketCode);
                                carPark.TicketValidated();
                                MessageBoxManager.Unregister();
                                return TicketPaid.TICKET_REMOVED;  //otherwise requests payment
                            }

                            else
                            {
                                message = "Ticket has not been paid.";
                                MessageBoxManager.Unregister();
                                return TicketPaid.NOT_PAID;  //if ticket unpaid, no change, car needs to approach
                            }
                        }
                    }
                }
            }

            message = "Not valid ticket.";
            return TicketPaid.NOT_VALID;

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

enum TicketPaid //Creates common references within namespace
{
    TICKET_REMOVED,
    NOT_PAID,
    NOT_VALID
}