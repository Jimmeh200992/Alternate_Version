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
        public void AddChipCoin(int PIN, string regPlate, int sysTime)
        {
            ChipCoins.Add(new ChipCoin());          //Creates a new ChipCoin and adds to list.
            SetChipCoinPIN(PIN);                  //Assigns PIN to newly created ChipCoin
            SetChipCoinPlate(regPlate);
            SetChipCoinTime(sysTime);
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

        public void SetChipCoinTime(int sysTime)
        {
            foreach (ChipCoin ChipCoin in ChipCoins)
            {
                int checkValue = ChipCoin.GetTimeStamp();
                if (checkValue == 0)
                    ChipCoin.SetTimeStamp(sysTime);
            }
        }

        public void SetChipCoinLost(int ChipCoinCode)
        {
            foreach (ChipCoin ChipCoin in ChipCoins)
            {
                if (ChipCoin.GetHashCode() == ChipCoinCode)
                {
                    ChipCoin.SetLost(true);
                }
            }
        }
        public void SetChipCoinFound(string RegPlate, int PIN)
        {
            foreach (ChipCoin ChipCoin in ChipCoins)
            {
                if (ChipCoin.GetRegPlate() == RegPlate)
                    if (ChipCoin.GetPIN() == PIN)
                        {
                            ChipCoin.SetLost(false);
                        }
            }
        }

        public void SetChipCoinFaulty(int ChipCoinCode)
        {
            foreach (ChipCoin ChipCoin in ChipCoins)
            {
                if (ChipCoin.GetHashCode() == ChipCoinCode)
                {
                    ChipCoin.SetFaulty(true);
                }
            }
        }
        public void SetChipCoinFixed(string RegPlate, int PIN)
        {
            foreach (ChipCoin ChipCoin in ChipCoins)
            {
                if (ChipCoin.GetRegPlate() == RegPlate)
                    if (ChipCoin.GetPIN() == PIN)
                    {
                        ChipCoin.SetFaulty(false);
                    }
            }
        }

        public void BlankChipCoinPIN(int ChipCoinCode)
        {
            foreach (ChipCoin ChipCoin in ChipCoins)
            {
                if (ChipCoin.GetHashCode() == ChipCoinCode)
                {
                    ChipCoin.SetPIN(11111111);
                }
            }
        }
        public void RestoreChipCoinPIN(int ChipCoinCode, string RegPlate)
        {
            foreach (ChipCoin ChipCoin in ChipCoins)
            {
                if (ChipCoin.GetHashCode() == ChipCoinCode)
                    if (ChipCoin.GetRegPlate() == RegPlate)
                    {
                        ChipCoin.SetPIN(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter a new PIN")));
                    }
            }
        }
    }
}
