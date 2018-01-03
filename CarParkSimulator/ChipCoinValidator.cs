using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarParkSimulator
{
    class ChipCoinValidator
    {
        //ATTRIBUTES
        private string message;
        private ActiveChipCoins ChipCoins;
        private CarPark carPark;

        //CONSTRUCTOR
        public ChipCoinValidator(ActiveChipCoins ChipCoins)
        {
            this.ChipCoins = ChipCoins;
        }
        //OPERATIONS
        public void AssignCarPark(CarPark carPark)   //Machine constructed after CarPark, thus needs an extra function.
        {
            this.carPark = carPark;
        }

        public void CarArrived()
        {
            message = "Please insert your ChipCoin.";
        }

        public ChipCoinPaid ChipCoinEntered(int ChipCoinCode)
        {

            foreach (ChipCoin ChipCoin in ChipCoins.GetChipCoins())  //loops through all active ChipCoins
            {
                if (ChipCoin.GetHashCode() == ChipCoinCode)  //checks inputted hashcode against ChipCoin hashcodes
                {
                    if (ChipCoin.IsPaid() == true)  //on success, checks against whether ChipCoin is paid
                    {
                        message = "Thank you, drive safely.";
                        ChipCoins.RemoveChipCoin(ChipCoinCode);
                        carPark.ChipCoinValidated();
                        return ChipCoinPaid.ChipCoin_REMOVED;  //presents message and removes ChipCoin if ChipCoin already paid
                    }
                    else //otherwise, requests PIN entry to authorise payment
                    {
                        string PINEntry = Microsoft.VisualBasic.Interaction.InputBox("Please enter your secure parking PIN");
                        int.TryParse(PINEntry, out int PIN);
                        if (ChipCoin.GetPIN() != PIN)
                        {
                            message = "Invalid PIN, please reinsert your ChipCoin";
                            return ChipCoinPaid.NOT_VALID;  //if PIN incorrect, returns system to point where car due to arrive at barrier
                        }
                        else
                        {
                            MessageBoxManager.OK = "Present card"; MessageBoxManager.Cancel = "Pay by cash"; MessageBoxManager.Register();
                            if (MessageBox.Show("Please pay by card.", "PayByCard", MessageBoxButtons.OKCancel) == DialogResult.OK)
                            {
                                message = "Thank you, drive safely.";
                                ChipCoins.RemoveChipCoin(ChipCoinCode);
                                carPark.ChipCoinValidated();
                                MessageBoxManager.Unregister();
                                return ChipCoinPaid.ChipCoin_REMOVED;  //otherwise requests payment
                            }

                            else
                            {
                                message = "ChipCoin has not been paid.";
                                MessageBoxManager.Unregister();
                                return ChipCoinPaid.NOT_PAID;  //if ChipCoin unpaid, no change, car needs to approach
                            }
                        }
                    }
                }
            }

            message = "Not valid ChipCoin.";
            return ChipCoinPaid.NOT_VALID;

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

enum ChipCoinPaid //Creates common references within namespace
{
    ChipCoin_REMOVED,
    NOT_PAID,
    NOT_VALID
}