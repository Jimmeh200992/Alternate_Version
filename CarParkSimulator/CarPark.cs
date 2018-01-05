﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarParkSimulator
{
    class CarPark
    {
        //ATTRIBUTES
        private int currentSpaces;
        private const int maxSpaces = carParkFloors * spacesPerFloor;
        private const int carParkFloors = 3;
        private const int spacesPerFloor = 10;
        int[] carParkSpaces = new int[carParkFloors];
        int[,] carParkLayout = new int[carParkFloors, spacesPerFloor];

        private int sysTime;
        private int sysTimeHours;
        private int sysTimeMinutes;
        private string sysTimeString;

        private ChipCoinMachine ChipCoinMachine;
        private ChipCoinValidator ChipCoinValidator;
        private Barrier entryBarrier;
        private Barrier exitBarrier;
        private FullSign fullSign;

        //CONSTRUCTOR
        public CarPark (ChipCoinMachine ChipCoinMachine, ChipCoinValidator ChipCoinValidator, FullSign fullSign, Barrier entryBarrier, Barrier exitBarrier)
        {
            this.ChipCoinMachine = ChipCoinMachine;
            this.ChipCoinValidator = ChipCoinValidator;
            this.fullSign = fullSign;
            this.entryBarrier = entryBarrier;
            this.exitBarrier = exitBarrier;
            currentSpaces = maxSpaces;
            for (int i = 0; i < carParkFloors; i++)
                carParkSpaces[i] = spacesPerFloor;
        }

        //OPERATIONS
        public void CarArrivedAtEntrance()
        {
            ChipCoinMachine.CarArrived();
        }

        public void ChipCoinDispensed()
        {
            entryBarrier.Raise();
        }

        public void CarEnteredCarpark()
        {
            entryBarrier.Lower();
            ChipCoinMachine.ClearMessage();
            currentSpaces = currentSpaces - 1;      //A car takes up a parking space.
            fullSign.SetLit(IsFull());
        }

        public void CarArrivedAtExit()
        {
            ChipCoinValidator.CarArrived();
        }

        public void ChipCoinValidated()
        {
            exitBarrier.Raise();
        }

        public void CarExitedCarpark()
        {
            exitBarrier.Lower();
            ChipCoinValidator.ClearMessage();
            currentSpaces = currentSpaces + 1;      //A parking space is now free.
            fullSign.SetLit(IsFull());
        }

        public bool IsFull()
        {
            if (currentSpaces == 0)
            {
                return true;
            }
            else
                return false;
            
        }

        public bool IsEmpty()
        {
            if (currentSpaces == maxSpaces)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasSpace()
        {
            if (currentSpaces > 0)
            {
                return true;
            }
            else
                return false;
        }

        public int getCurrentSpaces()
        {
            return currentSpaces;
        }

        public int parkCar(int ChipCoinCode)
        {
            bool parked = false;
            int floor = selectFloor();
            while (parked == false)
            {
                if (floor >= 0 && floor < carParkFloors)
                    if (carParkSpaces[floor] > 0)
                    {
                        carParkSpaces[floor] = (carParkSpaces[floor] - 1);
                        for (int i = 0; i < spacesPerFloor; i++)
                        {
                            
                            if (carParkLayout[floor, i] == 0)
                            {
                                carParkLayout[floor, i] = ChipCoinCode;
                                parked = true;
                                break;
                            }
                        }
                    }
            }
            if (parked == true)
                return floor;
            else
                return carParkFloors;
        }

        public int selectFloor()
        {
            bool floorValid = false;
            while (floorValid == false)
                {
                    string floorEntry = Microsoft.VisualBasic.Interaction.InputBox("Enter the floor to park on (0 is ground)");
                    int.TryParse(floorEntry, out int floor);  //validates PIN entry as numeric
                    if (floor >= 0 && floor < carParkFloors)
                    {
                        floorValid = true;
                        return floor;
                    }
                    else
                        MessageBox.Show("Invalid floor.  Please select a valid floor");
                }
            return carParkFloors;
        }

        public int getSpacesOnFloor()
        {
            return carParkSpaces[selectFloor()];
        }

        public string getAllSpaces()
        {
            string allSpaces = "";
            for (int i = 0; i < carParkFloors; i++)
            {
                allSpaces = allSpaces + "Floor " + i + " : " + carParkSpaces[i] + "\n";
            }
            return allSpaces;
        }

        public void carLeavesParkingSpace(int ChipCoinCode)
        {
            bool parked = true;
            while (parked == true)
            {
                int floor = selectFloor();
                if (floor >= 0 && floor < carParkFloors)
                    if (carParkSpaces[floor] < spacesPerFloor)
                    {
                        carParkSpaces[floor] = (carParkSpaces[floor] + 1);
                        while (parked == true)
                        {
                            for (int i = 0; i < spacesPerFloor; i++)
                            {
                                if (carParkLayout[floor, i] == ChipCoinCode)
                                {
                                    carParkLayout[floor, i] = 0;
                                    parked = false;
                                }
                            }
                        }
                    }
            }
        }

        public string setSystemTime()
        {
            sysTimeHours = Convert.ToInt32((DateTime.Now).ToString("HH"));
            sysTimeMinutes = Convert.ToInt32((DateTime.Now).ToString("mm"));
            sysTime = (sysTimeHours * 100) + sysTimeMinutes;
            sysTimeString = String.Format("{0,00}:{1,00}", sysTimeHours, sysTimeMinutes);
            return sysTimeString;
        }

        public string advanceSystemTimeHour()
        {
            sysTimeHours++;
            if (sysTimeHours / 24 == 1)
                sysTimeHours = 0;

            sysTime = (sysTimeHours * 100) + sysTimeMinutes;
            sysTimeString = String.Format("{0:00}:{1:00}", sysTimeHours, sysTimeMinutes);
            return sysTimeString;
        }

        public string advanceSystemTimeMinutes()
        {
            sysTimeMinutes = sysTimeMinutes + 10;
            if (sysTimeMinutes / 60 == 1)
            {
                sysTimeMinutes = sysTimeMinutes % 60;
                sysTimeHours++;
                if (sysTimeHours / 24 == 1)
                    sysTimeHours = 0;
            }
            sysTime = (sysTimeHours * 100) + sysTimeMinutes;
            sysTimeString = String.Format("{0:00}:{1:00}", sysTimeHours, sysTimeMinutes);
            return sysTimeString;
        }

        public string tickSystemTime()
        {
            sysTimeMinutes = sysTimeMinutes + 1;
            if (sysTimeMinutes / 60 == 1)
            {
                sysTimeMinutes = sysTimeMinutes % 60;
                sysTimeHours++;
                if (sysTimeHours / 24 == 1)
                    sysTimeHours = 0;
            }
            sysTime = (sysTimeHours * 100) + sysTimeMinutes;
            sysTimeString = String.Format("{0:00}:{1:00}", sysTimeHours, sysTimeMinutes);
            return sysTimeString;
        }

        public int getSysMinutes()
        {
            return sysTimeMinutes;
        }
        
        public int getSysHours()
        {
            return sysTimeHours;
        }

        public int getSysTime()
        {
            return sysTime;
        }
    }
}