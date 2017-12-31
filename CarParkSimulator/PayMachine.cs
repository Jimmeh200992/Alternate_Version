using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace CarParkSimulator
{
    class PayMachine
    {
        //ATTRIBUTES
        private ActiveTickets tickets;
        private CarPark carPark;

        //CONSTRUCTOR
        public PayMachine(ActiveTickets tickets)
        {
            this.tickets = tickets;
        }

        //OPERATIONS
        public void PayForTicket(int ticketCode)
        {
            if (tickets.GetTickets().Count() > 0)
            {
                //Checks every active ticket
                foreach (Ticket ticket in tickets.GetTickets())
                {
                    //Checks if the Hashcodes match.
                    if (ticketCode == ticket.GetHashCode())
                    {
                        string PINEntry = Microsoft.VisualBasic.Interaction.InputBox("Please enter your secure parking PIN");
                        int.TryParse(PINEntry, out int PIN);
                        if (ticket.GetPIN() != PIN)
                        {
                            MessageBox.Show("Invalid PIN, please reinsert coin");
                            break;
                        }
                        else
                        {
                            //Removes that ticket from the list
                            MessageBoxManager.OK = "Cash"; MessageBoxManager.Cancel = "Card"; MessageBoxManager.Register();

                            //ask to select a payment, if cash is pressed set paid to true
                            if (MessageBox.Show("Please select payment method. \n\nCard payments will be processed at the barrier.", "Payment type", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                ticket.SetPaid(true);

                            }
                            MessageBoxManager.Unregister();
                            break;
                        }
                    }
                }
            }
        }
    }
}
