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
        private TicketMachine ticketMachine;
        private ActiveTickets activeTickets;
        private TicketValidator ticketValidator;
        private Barrier entryBarrier;
        private Barrier exitBarrier;
        private FullSign fullSign;
        private CarPark carPark;
        private EntrySensor entrySensor;
        private ExitSensor exitSensor;

        private PayMachine payMachine;
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
            activeTickets = new ActiveTickets();
            ticketMachine = new TicketMachine(activeTickets);
            ticketValidator = new TicketValidator(activeTickets);

            payMachine = new PayMachine(activeTickets);

            entryBarrier = new Barrier();
            exitBarrier = new Barrier();
            fullSign = new FullSign();
            carPark = new CarPark(ticketMachine, ticketValidator, fullSign, entryBarrier, exitBarrier);//, payMachine);
            entrySensor = new EntrySensor(carPark);
            exitSensor = new ExitSensor(carPark);

            ticketMachine.AssignCarPark(carPark);
            ticketValidator.AssignCarPark(carPark);

            /////////////////////////////////////////

            btnCarArrivesAtEntrance.Visible = true;
            btnDriverPressesForTicket.Visible = false;
            btnCarEntersCarPark.Visible = false;
            btnCarArrivesAtExit.Visible = false;
            btnDriverEntersTicket.Visible = false;
            btnCarExitsCarPark.Visible = false;
            btnParkCar.Visible = false;
            btnCarLeavesSpace.Visible = false;

            UpdateDisplay();
        }

        private void CarArrivesAtEntrance(object sender, EventArgs e)
        {
            entrySensor.CarDetected();                  //Calls the entry class, allowing process to start.
            btnCarArrivesAtEntrance.Visible = false;    //Disables button clicked.
            btnDriverPressesForTicket.Visible = true;   //Enables next step.
            UpdateDisplay();
        }

        private void DriverPressesForTicket(object sender, EventArgs e)
        {
            ticketMachine.PrintTicket();                //Calls the ticket dispenser, creating the ticket.
            btnDriverPressesForTicket.Visible = false;  //Disables button clicked.
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
            string ticketCode = Microsoft.VisualBasic.Interaction.InputBox("Enter your ticket HASH:  (This is a simulation of scanning the ticket code");
            Convert.ToInt32(ticketCode);
            foreach (Ticket ticket in activeTickets.GetTickets())
            {
                if (Convert.ToInt32(ticketCode) == ticket.GetHashCode())
                    {
                        carPark.parkCar(Convert.ToInt32(ticketCode));
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
            btnDriverEntersTicket.Visible = true;       //Enables next step.
            UpdateDisplay();
        }

        private void DriverEntersTicket(object sender, EventArgs e)
        {
            //int ticketCode = activeTickets.GetTickets()[0].GetHashCode();       //Generates the inputted ticket's hashcode.
            string ticketCode = Microsoft.VisualBasic.Interaction.InputBox("Enter your ticket HASH:  (This is a simulation of scanning the ticket code");

            TicketPaid paid = ticketValidator.TicketEntered(Convert.ToInt32(ticketCode));  //Validates and removes the ticket.
                //ABOVE REMOVES ONLY IF TICKET IS PAID
            switch (paid)
            {
                case TicketPaid.TICKET_REMOVED:
                    btnCarExitsCarPark.Visible = true;
                    break;
                case TicketPaid.NOT_PAID:
                    btnCarArrivesAtExit.Visible = true;
                    break;
                case TicketPaid.NOT_VALID:
                    btnCarArrivesAtExit.Visible = true;
                    break;
                default:
                    break;
            }
            btnDriverEntersTicket.Visible = false;      //Disables button clicked.
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
            lblTicketMachine.Text = ticketMachine.GetMessage();
            lblTicketValidator.Text = ticketValidator.GetMessage();
            lblEntrySensor.Text = Convert.ToString(entrySensor.IsCarOnSensor());
            lblEntryBarrier.Text = Convert.ToString(entryBarrier.IsLifted());
            lblExitSensor.Text = Convert.ToString(exitSensor.IsCarOnSensor());
            lblExitBarrier.Text = Convert.ToString(exitBarrier.IsLifted());
            lblFullSign.Text = Convert.ToString(fullSign.IsLit());
            lblSpaces.Text = Convert.ToString(carPark.getCurrentSpaces());
            lblSpacesByFloor.Text = carPark.getAllSpaces();

            string TicketList = "";
            foreach (Ticket ticket in activeTickets.GetTickets())
            {
                TicketList = TicketList + "#" + Convert.ToString(ticket.GetHashCode()) + ": " + Convert.ToString(ticket.IsPaid()) + "\n";
            }
            lstActiveTickets.Text = TicketList;
        }

        //PAYMENT FUNCTIONALITY
        private void btnPayForTicket_Click(object sender, EventArgs e)
        {
            string ticketCode = Microsoft.VisualBasic.Interaction.InputBox("Enter your ticket HASH:  (This is a simulation of scanning the ticket code");
            payMachine.PayForTicket(Convert.ToInt32(ticketCode));
            UpdateDisplay();
        }

        private void btnCarLeavesSpace_Click(object sender, EventArgs e)
        {
            string ticketCode = Microsoft.VisualBasic.Interaction.InputBox("Enter your ticket HASH:  (This is a simulation of scanning the ticket code");
            Convert.ToInt32(ticketCode);
            foreach (Ticket ticket in activeTickets.GetTickets())
            {
                if (Convert.ToInt32(ticketCode) == ticket.GetHashCode())
                {
                    carPark.carLeavesParkingSpace(Convert.ToInt32(ticketCode));
                    break;
                }
            }
            btnCarLeavesSpace.Visible = false;
            btnCarArrivesAtExit.Visible = true;         //Enables exit button.
            UpdateDisplay();
        }
    }
}
