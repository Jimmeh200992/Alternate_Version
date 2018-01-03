using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class ActiveChipCoins
    {
        //ATTRIBUTES
        private List<ChipCoin> ChipCoins;       //List to hold all ChipCoins.

        //CONSTRUCTOR
        public ActiveChipCoins()
        {
            ChipCoins = new List<ChipCoin>();      //Creates a new list.
        }
        
        //OPERATIONS
        public void AddChipCoin(int PIN, string regPlate)
        {
            ChipCoins.Add(new ChipCoin());          //Creates a new ChipCoin and adds to list.
            SetChipCoinPIN(PIN);                  //Assigns PIN to newly created ChipCoin
            SetChipCoinPlate(regPlate);
        }

        public List<ChipCoin> GetChipCoins()
        {
            return ChipCoins;                     //Returns the list.
        }

        public void RemoveChipCoin(int ChipCoinCode)
        {
            //Checks all ChipCoins currenty active.
            foreach (ChipCoin ChipCoin in ChipCoins)
            {
                //Checks if the Hashcodes match.
                if (ChipCoinCode == ChipCoin.GetHashCode())                        
                {
                    //Removes that ChipCoin from the list
                    ChipCoins.Remove(ChipCoin);
                    break;
                }
            }
        }

        public void SetChipCoinPIN(int PIN)
        {
            foreach (ChipCoin ChipCoin in ChipCoins)
            {
                int checkValue = ChipCoin.GetPIN();
                if (checkValue == 99999999)
                    ChipCoin.SetPIN(PIN);
            }
        }

        public void SetChipCoinPlate(string regPlate)
        {
            foreach (ChipCoin ChipCoin in ChipCoins)
            {
                string checkValue = ChipCoin.GetRegPlate();
                if (checkValue == "")
                    ChipCoin.SetRegPlate(regPlate);
            }
        }
    }
}
