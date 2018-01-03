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
        private ActiveChipCoins ChipCoins;
        private CarPark carPark;

        //CONSTRUCTOR
        public PayMachine(ActiveChipCoins ChipCoins)
        {
            this.ChipCoins = ChipCoins;
        }

        //OPERATIONS
        public void PayForChipCoin(int ChipCoinCode)
        {
            if (ChipCoins.GetChipCoins().Count() > 0)  //only valid when there are ChipCoins in the system
            {
                //Checks every active ChipCoin
                foreach (ChipCoin ChipCoin in ChipCoins.GetChipCoins())  //checks against active ChipCoins
                {
                    //Checks if the Hashcodes match.
                    if (ChipCoinCode == ChipCoin.GetHashCode())  //compares hashcode
                    {
                        string PINEntry = Microsoft.VisualBasic.Interaction.InputBox("Please enter your secure parking PIN");
                        int.TryParse(PINEntry, out int PIN);  //validates PIN entry as numeric
                        if (ChipCoin.GetPIN() != PIN) //checks against registered PIN
                        {
                            MessageBox.Show("Invalid PIN, please reinsert coin");
                            break;  //breaks operation if PIN invalid
                        }
                        else
                        {
                            MessageBoxManager.OK = "Cash"; MessageBoxManager.Cancel = "Card"; MessageBoxManager.Register();  //Removes that ChipCoin from the list
                            
                            if (MessageBox.Show("Please select payment method. \n\nCard payments will be processed at the barrier.", "Payment type", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                ChipCoin.SetPaid(true);

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
