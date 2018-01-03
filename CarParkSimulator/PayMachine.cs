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
            if (tickets.GetTickets().Count() > 0)  //only valid when there are tickets in the system
            {
                //Checks every active ticket
                foreach (Ticket ticket in tickets.GetTickets())  //checks against active tickets
                {
                    //Checks if the Hashcodes match.
                    if (ticketCode == ticket.GetHashCode())  //compares hashcode
                    {
                        string PINEntry = Microsoft.VisualBasic.Interaction.InputBox("Please enter your secure parking PIN");
                        int.TryParse(PINEntry, out int PIN);  //validates PIN entry as numeric
                        if (ticket.GetPIN() != PIN) //checks against registered PIN
                        {
                            MessageBox.Show("Invalid PIN, please reinsert coin");
                            break;  //breaks operation if PIN invalid
                        }
                        else
                        {
                            MessageBoxManager.OK = "Cash"; MessageBoxManager.Cancel = "Card"; MessageBoxManager.Register();  //Removes that ticket from the list
                            
                            if (MessageBox.Show("Please select payment method. \n\nCard payments will be processed at the barrier.", "Payment type", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                ticket.SetPaid(true);

                            }
                            MessageBoxManager.Unregister();
                            break;  //ask to select a payment, if cash is pressed, set paid to true, breaks loop
                        }
                    }
                }
            }
        }
    }
}
