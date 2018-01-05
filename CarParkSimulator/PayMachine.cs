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

        public void AssignCarPark(CarPark carPark)  //Machine constructed after CarPark, thus needs an extra function.
        {
            this.carPark = carPark;
        }

        //OPERATIONS
        public void PayForChipCoin(int ChipCoinCode, int sysHours, int sysMinutes)
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
                            MessageBox.Show("You have stayed for " + getTimeParked(ChipCoin.ExtractHours(), ChipCoin.ExtractMinutes(), sysHours, sysMinutes) + " minutes.");
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
        public int getTimeParked(int chipCoinHours, int chipCoinMinutes, int sysHours, int sysMinutes)
        {
            int hoursStayed = sysHours - chipCoinHours;
            if (hoursStayed < 0)
                hoursStayed = 24 - hoursStayed;
            int minutesStayed = sysMinutes - chipCoinMinutes;
            hoursStayed = hoursStayed * 60;
            if (minutesStayed < 0)
                minutesStayed = hoursStayed + minutesStayed;
            else
                minutesStayed = hoursStayed - minutesStayed;
            return minutesStayed;
        }
    }
}
