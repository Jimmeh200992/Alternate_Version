using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CarParkSimulator
{
    public partial class SimulatorInterface : Form
    {
        // Attributes ///        
        private ChipCoinMachine ChipCoinMachine;
        private ActiveChipCoins activeChipCoins;
        private ChipCoinValidator ChipCoinValidator;
        private Barrier entryBarrier;
        private Barrier exitBarrier;
        private FullSign fullSign;
        private CarPark carPark;
        private EntrySensor entrySensor;
        private ExitSensor exitSensor;

        private PayMachine payMachine;

        private string sysTime;
        /////////////////


        // Constructor //
        public SimulatorInterface()
        {
            InitializeComponent();
        }
        /////////////////


        // Operations ///
        private void ResetSystem(object sender, EventArgs e)
        {
            activeChipCoins = new ActiveChipCoins();
            ChipCoinMachine = new ChipCoinMachine(activeChipCoins);
            ChipCoinValidator = new ChipCoinValidator(activeChipCoins);

            payMachine = new PayMachine(activeChipCoins);

            entryBarrier = new Barrier();
            exitBarrier = new Barrier();
            fullSign = new FullSign();
            carPark = new CarPark(ChipCoinMachine, ChipCoinValidator, fullSign, entryBarrier, exitBarrier);//, payMachine);
            entrySensor = new EntrySensor(carPark);
            exitSensor = new ExitSensor(carPark);

            ChipCoinMachine.AssignCarPark(carPark);
            ChipCoinValidator.AssignCarPark(carPark);

            /////////////////////////////////////////

            btnCarArrivesAtEntrance.Visible = true;
            btnDriverPressesForChipCoin.Visible = false;
            btnCarEntersCarPark.Visible = false;
            btnCarArrivesAtExit.Visible = false;
            btnDriverEntersChipCoin.Visible = false;
            btnCarExitsCarPark.Visible = false;
            btnParkCar.Visible = false;
            btnCarLeavesSpace.Visible = false;

            sysTime = (DateTime.Now).ToString("HH:mm");
            lblSystemTime.Text = sysTime;

            UpdateDisplay();
        }

        private void CarArrivesAtEntrance(object sender, EventArgs e)
        {
            entrySensor.CarDetected();                  //Calls the entry class, allowing process to start.
            btnCarArrivesAtEntrance.Visible = false;    //Disables button clicked.
            btnDriverPressesForChipCoin.Visible = true;   //Enables next step.
            UpdateDisplay();
        }

        private void DriverPressesForChipCoin(object sender, EventArgs e)
        {
            ChipCoinMachine.DispenseChipCoin(sysTime);                //Calls the ChipCoin dispenser, creating the ChipCoin.
            btnDriverPressesForChipCoin.Visible = false;  //Disables button clicked.
            btnCarEntersCarPark.Visible = true;         //Enables next step.
            UpdateDisplay();
        }

        private void CarEntersCarPark(object sender, EventArgs e)
        {
            entrySensor.CarLeftSensor();                //Detects that the car has moved, changes spaces and signs accordingly
            btnCarEntersCarPark.Visible = false;        //Disables button clicked.
            if (carPark.IsFull() == false)              //Only enables entry button if car park is not full.
            {
                btnCarArrivesAtEntrance.Visible = true;
            }
            btnParkCar.Visible = true;
            UpdateDisplay();
        }
        
        private void btnParkCar_Click(object sender, EventArgs e)
        {
            string ChipCoinCode = Microsoft.VisualBasic.Interaction.InputBox("Enter your ChipCoin HASH:  (This is a simulation of scanning the ChipCoin code");
            Convert.ToInt32(ChipCoinCode);
            foreach (ChipCoin ChipCoin in activeChipCoins.GetChipCoins())
            {
                if (Convert.ToInt32(ChipCoinCode) == ChipCoin.GetHashCode())
                    {
                        ChipCoin.SetCurrentFloor(carPark.parkCar(Convert.ToInt32(ChipCoinCode)));
                        break;
                    }
            }
            btnParkCar.Visible = false;
            btnCarLeavesSpace.Visible = true;         //Enables exit button.
            UpdateDisplay();
        }

        private void CarArrivesAtExit(object sender, EventArgs e)
        {
            exitSensor.CarDetected();                   //Calls the entry class, allowing validation process to start.
            btnCarArrivesAtExit.Visible = false;        //Disables button clicked.
            btnDriverEntersChipCoin.Visible = true;       //Enables next step.
            UpdateDisplay();
        }

        private void DriverEntersChipCoin(object sender, EventArgs e)
        {
            //int ChipCoinCode = activeChipCoins.GetChipCoins()[0].GetHashCode();       //Generates the inputted ChipCoin's hashcode.
            string ChipCoinCode = Microsoft.VisualBasic.Interaction.InputBox("Enter your ChipCoin HASH:  (This is a simulation of scanning the ChipCoin code");

            ChipCoinPaid paid = ChipCoinValidator.ChipCoinEntered(Convert.ToInt32(ChipCoinCode));  //Validates and removes the ChipCoin.
                //ABOVE REMOVES ONLY IF ChipCoin IS PAID
            switch (paid)
            {
                case ChipCoinPaid.ChipCoin_REMOVED:
                    btnCarExitsCarPark.Visible = true;
                    break;
                case ChipCoinPaid.NOT_PAID:
                    btnCarArrivesAtExit.Visible = true;
                    break;
                case ChipCoinPaid.NOT_VALID:
                    btnCarArrivesAtExit.Visible = true;
                    break;
                default:
                    break;
            }
            btnDriverEntersChipCoin.Visible = false;      //Disables button clicked.
            UpdateDisplay();
        }

        private void CarExitsCarPark(object sender, EventArgs e)
        {
            exitSensor.CarLeftSensor();                 //Dectects that the car has moved and edits spaces and signs accordingly.
            btnCarExitsCarPark.Visible = false;         //Disables button clicked.
            if (carPark.IsEmpty() == false)             //Only enables exit button if carpark is not empty
            {
                btnCarArrivesAtExit.Visible = true;
            }
            if (carPark.IsFull() == false)              //Only enables entry button if carpark is not full.
            {
                btnCarArrivesAtEntrance.Visible = true;
            }
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            lblChipCoinMachine.Text = ChipCoinMachine.GetMessage();
            lblChipCoinValidator.Text = ChipCoinValidator.GetMessage();
            lblEntrySensor.Text = Convert.ToString(entrySensor.IsCarOnSensor());
            lblEntryBarrier.Text = Convert.ToString(entryBarrier.IsLifted());
            lblExitSensor.Text = Convert.ToString(exitSensor.IsCarOnSensor());
            lblExitBarrier.Text = Convert.ToString(exitBarrier.IsLifted());
            lblFullSign.Text = Convert.ToString(fullSign.IsLit());
            lblSpaces.Text = Convert.ToString(carPark.getCurrentSpaces());
            lblSpacesByFloor.Text = carPark.getAllSpaces();

            string ChipCoinList = "";
            foreach (ChipCoin ChipCoin in activeChipCoins.GetChipCoins())
            {
                ChipCoinList = ChipCoinList + "#" + Convert.ToString(ChipCoin.GetHashCode()) + ": " + Convert.ToString(ChipCoin.IsPaid()) + ": " + Convert.ToString(ChipCoin.GetCurrentFloor()) + ": " + ChipCoin.GetRegPlate() + "\n";
            }
            lstActiveChipCoins.Text = ChipCoinList;
        }

        //PAYMENT FUNCTIONALITY
        private void btnPayForChipCoin_Click(object sender, EventArgs e)
        {
            string ChipCoinCode = Microsoft.VisualBasic.Interaction.InputBox("Enter your ChipCoin HASH:  (This is a simulation of scanning the ChipCoin code");
            payMachine.PayForChipCoin(Convert.ToInt32(ChipCoinCode));
            UpdateDisplay();
        }

        private void btnCarLeavesSpace_Click(object sender, EventArgs e)
        {
            string ChipCoinCode = Microsoft.VisualBasic.Interaction.InputBox("Enter your ChipCoin HASH:  (This is a simulation of scanning the ChipCoin code");
            Convert.ToInt32(ChipCoinCode);
            foreach (ChipCoin ChipCoin in activeChipCoins.GetChipCoins())
            {
                if (Convert.ToInt32(ChipCoinCode) == ChipCoin.GetHashCode())
                {
                    carPark.carLeavesParkingSpace(Convert.ToInt32(ChipCoinCode));
                    break;
                }
            }
            btnCarLeavesSpace.Visible = false;
            btnCarArrivesAtExit.Visible = true;         //Enables exit button.
            UpdateDisplay();
        }

        private void btnAdvanceTime_Click(object sender, EventArgs e)
        {
            lblSystemTime.Text = sysTime;
        }

        private void timerSysTime_Tick(object sender, EventArgs e)
        {
            sysTime = "0";
            lblSystemTime.Text = sysTime;
        }
    }
}
