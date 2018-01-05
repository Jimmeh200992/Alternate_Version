using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;

namespace CarParkSimulator
{
    class ChipCoinMachine
    {
        //ATTRIBUTES
        private string message;
        private ActiveChipCoins ChipCoins;
        private CarPark carPark;

        //CONSTRUCTOR
        public ChipCoinMachine(ActiveChipCoins ChipCoins)
        {
            this.ChipCoins = ChipCoins;
        }
        //OPERATIONS
        public void AssignCarPark(CarPark carPark)  //Machine constructed after CarPark, thus needs an extra function.
        {
            this.carPark = carPark;
        }

        public void CarArrived()
        {
            message = "Please press to get a ChipCoin.";
        }

        public void DispenseChipCoin(string sysTime)
        {
            string regPlate = Microsoft.VisualBasic.Interaction.InputBox("Please enter vehicle registration plate (Simulates camera reading plate)");
            string PINEntry = Microsoft.VisualBasic.Interaction.InputBox("Please enter a PIN for your secure parking");  //requests PIN entry
            int.TryParse(PINEntry, out int PIN);  //parses string to int
            message = "Thank you, enjoy your stay.";
            ChipCoins.AddChipCoin(PIN, regPlate, sysTime);  //creates ChipCoin, passing PIN and regPlate
            carPark.ChipCoinDispensed();
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
