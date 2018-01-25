namespace CarParkSimulator
{
    partial class SimulatorInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxEntrySim = new System.Windows.Forms.GroupBox();
            this.btnParkCar = new System.Windows.Forms.Button();
            this.lblChipCoinMachine = new System.Windows.Forms.Label();
            this.btnCarEntersCarPark = new System.Windows.Forms.Button();
            this.btnDriverPressesForChipCoin = new System.Windows.Forms.Button();
            this.btnCarArrivesAtEntrance = new System.Windows.Forms.Button();
            this.groupBoxExitSim = new System.Windows.Forms.GroupBox();
            this.btnCarLeavesSpace = new System.Windows.Forms.Button();
            this.lblChipCoinValidator = new System.Windows.Forms.Label();
            this.btnCarExitsCarPark = new System.Windows.Forms.Button();
            this.btnDriverEntersChipCoin = new System.Windows.Forms.Button();
            this.btnCarArrivesAtExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBoxInternalData = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSpacesByFloor = new System.Windows.Forms.Label();
            this.groupBoxActiveChipCoins = new System.Windows.Forms.GroupBox();
            this.lstActiveChipCoins = new System.Windows.Forms.Label();
            this.groupBoxExitSensors = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblExitBarrier = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblExitSensor = new System.Windows.Forms.Label();
            this.groupBoxEntrySensors = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEntryBarrier = new System.Windows.Forms.Label();
            this.lblEntrySensor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSpaces = new System.Windows.Forms.Label();
            this.lblFullSign = new System.Windows.Forms.Label();
            this.btnAdvanceTimeHour = new System.Windows.Forms.Button();
            this.btnPayForChipCoin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSystemTime = new System.Windows.Forms.Label();
            this.timerSysTime = new System.Windows.Forms.Timer(this.components);
            this.btnAdvanceTime10Min = new System.Windows.Forms.Button();
            this.btnEmergencyServices = new System.Windows.Forms.Button();
            this.btnEmergencySituation = new System.Windows.Forms.Button();
            this.btnEmergencyExit = new System.Windows.Forms.Button();
            this.btnEmergencyExitSensor = new System.Windows.Forms.Button();
            this.btnEmergencyVehicleLeftCarPark = new System.Windows.Forms.Button();
            this.groupBoxFaultPanel = new System.Windows.Forms.GroupBox();
            this.btnPayMachineFaultFix = new System.Windows.Forms.Button();
            this.btnPinFailFix = new System.Windows.Forms.Button();
            this.btnLostCoinFix = new System.Windows.Forms.Button();
            this.btnInvalidCoinFix = new System.Windows.Forms.Button();
            this.btnPayMachineFaulty = new System.Windows.Forms.Button();
            this.btnPinFail = new System.Windows.Forms.Button();
            this.btnCoinLost = new System.Windows.Forms.Button();
            this.btnCoinInvalid = new System.Windows.Forms.Button();
            this.groupBoxEmergency = new System.Windows.Forms.GroupBox();
            this.groupBoxEntrySim.SuspendLayout();
            this.groupBoxExitSim.SuspendLayout();
            this.groupBoxInternalData.SuspendLayout();
            this.groupBoxActiveChipCoins.SuspendLayout();
            this.groupBoxExitSensors.SuspendLayout();
            this.groupBoxEntrySensors.SuspendLayout();
            this.groupBoxFaultPanel.SuspendLayout();
            this.groupBoxEmergency.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEntrySim
            // 
            this.groupBoxEntrySim.Controls.Add(this.btnParkCar);
            this.groupBoxEntrySim.Controls.Add(this.lblChipCoinMachine);
            this.groupBoxEntrySim.Controls.Add(this.btnCarEntersCarPark);
            this.groupBoxEntrySim.Controls.Add(this.btnDriverPressesForChipCoin);
            this.groupBoxEntrySim.Controls.Add(this.btnCarArrivesAtEntrance);
            this.groupBoxEntrySim.Location = new System.Drawing.Point(12, 148);
            this.groupBoxEntrySim.Name = "groupBoxEntrySim";
            this.groupBoxEntrySim.Size = new System.Drawing.Size(200, 299);
            this.groupBoxEntrySim.TabIndex = 1;
            this.groupBoxEntrySim.TabStop = false;
            this.groupBoxEntrySim.Text = "Entrance simulator";
            // 
            // btnParkCar
            // 
            this.btnParkCar.Location = new System.Drawing.Point(6, 237);
            this.btnParkCar.Name = "btnParkCar";
            this.btnParkCar.Size = new System.Drawing.Size(188, 54);
            this.btnParkCar.TabIndex = 6;
            this.btnParkCar.Text = "Car is parked";
            this.btnParkCar.UseVisualStyleBackColor = true;
            this.btnParkCar.Visible = false;
            this.btnParkCar.Click += new System.EventHandler(this.btnParkCar_Click);
            // 
            // lblChipCoinMachine
            // 
            this.lblChipCoinMachine.BackColor = System.Drawing.Color.DimGray;
            this.lblChipCoinMachine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChipCoinMachine.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblChipCoinMachine.Location = new System.Drawing.Point(6, 20);
            this.lblChipCoinMachine.Name = "lblChipCoinMachine";
            this.lblChipCoinMachine.Size = new System.Drawing.Size(188, 31);
            this.lblChipCoinMachine.TabIndex = 1;
            this.lblChipCoinMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCarEntersCarPark
            // 
            this.btnCarEntersCarPark.Location = new System.Drawing.Point(6, 177);
            this.btnCarEntersCarPark.Name = "btnCarEntersCarPark";
            this.btnCarEntersCarPark.Size = new System.Drawing.Size(188, 54);
            this.btnCarEntersCarPark.TabIndex = 3;
            this.btnCarEntersCarPark.Text = "Car enters car park";
            this.btnCarEntersCarPark.UseVisualStyleBackColor = true;
            this.btnCarEntersCarPark.Visible = false;
            this.btnCarEntersCarPark.Click += new System.EventHandler(this.CarEntersCarPark);
            // 
            // btnDriverPressesForChipCoin
            // 
            this.btnDriverPressesForChipCoin.Location = new System.Drawing.Point(6, 117);
            this.btnDriverPressesForChipCoin.Name = "btnDriverPressesForChipCoin";
            this.btnDriverPressesForChipCoin.Size = new System.Drawing.Size(188, 54);
            this.btnDriverPressesForChipCoin.TabIndex = 1;
            this.btnDriverPressesForChipCoin.Text = "Driver presses for ChipCoin";
            this.btnDriverPressesForChipCoin.UseVisualStyleBackColor = true;
            this.btnDriverPressesForChipCoin.Visible = false;
            this.btnDriverPressesForChipCoin.Click += new System.EventHandler(this.DriverPressesForChipCoin);
            // 
            // btnCarArrivesAtEntrance
            // 
            this.btnCarArrivesAtEntrance.Location = new System.Drawing.Point(6, 57);
            this.btnCarArrivesAtEntrance.Name = "btnCarArrivesAtEntrance";
            this.btnCarArrivesAtEntrance.Size = new System.Drawing.Size(188, 54);
            this.btnCarArrivesAtEntrance.TabIndex = 0;
            this.btnCarArrivesAtEntrance.Text = "Car arrives at entrance";
            this.btnCarArrivesAtEntrance.UseVisualStyleBackColor = true;
            this.btnCarArrivesAtEntrance.Visible = false;
            this.btnCarArrivesAtEntrance.Click += new System.EventHandler(this.CarArrivesAtEntrance);
            // 
            // groupBoxExitSim
            // 
            this.groupBoxExitSim.Controls.Add(this.btnCarLeavesSpace);
            this.groupBoxExitSim.Controls.Add(this.lblChipCoinValidator);
            this.groupBoxExitSim.Controls.Add(this.btnCarExitsCarPark);
            this.groupBoxExitSim.Controls.Add(this.btnDriverEntersChipCoin);
            this.groupBoxExitSim.Controls.Add(this.btnCarArrivesAtExit);
            this.groupBoxExitSim.Location = new System.Drawing.Point(226, 148);
            this.groupBoxExitSim.Name = "groupBoxExitSim";
            this.groupBoxExitSim.Size = new System.Drawing.Size(200, 299);
            this.groupBoxExitSim.TabIndex = 2;
            this.groupBoxExitSim.TabStop = false;
            this.groupBoxExitSim.Text = "Exit simulator";
            // 
            // btnCarLeavesSpace
            // 
            this.btnCarLeavesSpace.Location = new System.Drawing.Point(6, 57);
            this.btnCarLeavesSpace.Name = "btnCarLeavesSpace";
            this.btnCarLeavesSpace.Size = new System.Drawing.Size(188, 54);
            this.btnCarLeavesSpace.TabIndex = 7;
            this.btnCarLeavesSpace.Text = "Car leaves space";
            this.btnCarLeavesSpace.UseVisualStyleBackColor = true;
            this.btnCarLeavesSpace.Visible = false;
            this.btnCarLeavesSpace.Click += new System.EventHandler(this.btnCarLeavesSpace_Click);
            // 
            // lblChipCoinValidator
            // 
            this.lblChipCoinValidator.BackColor = System.Drawing.Color.DimGray;
            this.lblChipCoinValidator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChipCoinValidator.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblChipCoinValidator.Location = new System.Drawing.Point(6, 20);
            this.lblChipCoinValidator.Name = "lblChipCoinValidator";
            this.lblChipCoinValidator.Size = new System.Drawing.Size(188, 31);
            this.lblChipCoinValidator.TabIndex = 1;
            this.lblChipCoinValidator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCarExitsCarPark
            // 
            this.btnCarExitsCarPark.Location = new System.Drawing.Point(6, 236);
            this.btnCarExitsCarPark.Name = "btnCarExitsCarPark";
            this.btnCarExitsCarPark.Size = new System.Drawing.Size(188, 54);
            this.btnCarExitsCarPark.TabIndex = 2;
            this.btnCarExitsCarPark.Text = "Car exits car park";
            this.btnCarExitsCarPark.UseVisualStyleBackColor = true;
            this.btnCarExitsCarPark.Visible = false;
            this.btnCarExitsCarPark.Click += new System.EventHandler(this.CarExitsCarPark);
            // 
            // btnDriverEntersChipCoin
            // 
            this.btnDriverEntersChipCoin.Location = new System.Drawing.Point(6, 176);
            this.btnDriverEntersChipCoin.Name = "btnDriverEntersChipCoin";
            this.btnDriverEntersChipCoin.Size = new System.Drawing.Size(188, 54);
            this.btnDriverEntersChipCoin.TabIndex = 1;
            this.btnDriverEntersChipCoin.Text = "Driver enters ChipCoin";
            this.btnDriverEntersChipCoin.UseVisualStyleBackColor = true;
            this.btnDriverEntersChipCoin.Visible = false;
            this.btnDriverEntersChipCoin.Click += new System.EventHandler(this.DriverEntersChipCoin);
            // 
            // btnCarArrivesAtExit
            // 
            this.btnCarArrivesAtExit.Location = new System.Drawing.Point(6, 116);
            this.btnCarArrivesAtExit.Name = "btnCarArrivesAtExit";
            this.btnCarArrivesAtExit.Size = new System.Drawing.Size(188, 54);
            this.btnCarArrivesAtExit.TabIndex = 0;
            this.btnCarArrivesAtExit.Text = "Car arrives at exit";
            this.btnCarArrivesAtExit.UseVisualStyleBackColor = true;
            this.btnCarArrivesAtExit.Visible = false;
            this.btnCarArrivesAtExit.Click += new System.EventHandler(this.CarArrivesAtExit);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 53);
            this.label3.TabIndex = 4;
            this.label3.Text = "Car Park Simulator";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(18, 83);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(402, 54);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Start";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.ResetSystem);
            // 
            // groupBoxInternalData
            // 
            this.groupBoxInternalData.Controls.Add(this.label1);
            this.groupBoxInternalData.Controls.Add(this.lblSpacesByFloor);
            this.groupBoxInternalData.Controls.Add(this.groupBoxActiveChipCoins);
            this.groupBoxInternalData.Controls.Add(this.groupBoxExitSensors);
            this.groupBoxInternalData.Controls.Add(this.groupBoxEntrySensors);
            this.groupBoxInternalData.Controls.Add(this.label9);
            this.groupBoxInternalData.Controls.Add(this.label8);
            this.groupBoxInternalData.Controls.Add(this.lblSpaces);
            this.groupBoxInternalData.Controls.Add(this.lblFullSign);
            this.groupBoxInternalData.Location = new System.Drawing.Point(440, 148);
            this.groupBoxInternalData.Name = "groupBoxInternalData";
            this.groupBoxInternalData.Size = new System.Drawing.Size(428, 356);
            this.groupBoxInternalData.TabIndex = 3;
            this.groupBoxInternalData.TabStop = false;
            this.groupBoxInternalData.Text = "Internal data";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "Spaces by floor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSpacesByFloor
            // 
            this.lblSpacesByFloor.BackColor = System.Drawing.Color.White;
            this.lblSpacesByFloor.Location = new System.Drawing.Point(71, 237);
            this.lblSpacesByFloor.Name = "lblSpacesByFloor";
            this.lblSpacesByFloor.Size = new System.Drawing.Size(70, 54);
            this.lblSpacesByFloor.TabIndex = 9;
            this.lblSpacesByFloor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxActiveChipCoins
            // 
            this.groupBoxActiveChipCoins.Controls.Add(this.lstActiveChipCoins);
            this.groupBoxActiveChipCoins.Location = new System.Drawing.Point(154, 18);
            this.groupBoxActiveChipCoins.Name = "groupBoxActiveChipCoins";
            this.groupBoxActiveChipCoins.Size = new System.Drawing.Size(268, 281);
            this.groupBoxActiveChipCoins.TabIndex = 2;
            this.groupBoxActiveChipCoins.TabStop = false;
            this.groupBoxActiveChipCoins.Text = "Active ChipCoins";
            // 
            // lstActiveChipCoins
            // 
            this.lstActiveChipCoins.BackColor = System.Drawing.Color.White;
            this.lstActiveChipCoins.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lstActiveChipCoins.Location = new System.Drawing.Point(6, 15);
            this.lstActiveChipCoins.Name = "lstActiveChipCoins";
            this.lstActiveChipCoins.Size = new System.Drawing.Size(256, 254);
            this.lstActiveChipCoins.TabIndex = 1;
            // 
            // groupBoxExitSensors
            // 
            this.groupBoxExitSensors.Controls.Add(this.label6);
            this.groupBoxExitSensors.Controls.Add(this.lblExitBarrier);
            this.groupBoxExitSensors.Controls.Add(this.label13);
            this.groupBoxExitSensors.Controls.Add(this.lblExitSensor);
            this.groupBoxExitSensors.Location = new System.Drawing.Point(11, 92);
            this.groupBoxExitSensors.Name = "groupBoxExitSensors";
            this.groupBoxExitSensors.Size = new System.Drawing.Size(141, 67);
            this.groupBoxExitSensors.TabIndex = 1;
            this.groupBoxExitSensors.TabStop = false;
            this.groupBoxExitSensors.Text = "Exit";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sensor";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExitBarrier
            // 
            this.lblExitBarrier.BackColor = System.Drawing.Color.White;
            this.lblExitBarrier.Location = new System.Drawing.Point(60, 41);
            this.lblExitBarrier.Name = "lblExitBarrier";
            this.lblExitBarrier.Size = new System.Drawing.Size(70, 20);
            this.lblExitBarrier.TabIndex = 0;
            this.lblExitBarrier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Barrier";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExitSensor
            // 
            this.lblExitSensor.BackColor = System.Drawing.Color.White;
            this.lblExitSensor.Location = new System.Drawing.Point(60, 16);
            this.lblExitSensor.Name = "lblExitSensor";
            this.lblExitSensor.Size = new System.Drawing.Size(70, 20);
            this.lblExitSensor.TabIndex = 0;
            this.lblExitSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxEntrySensors
            // 
            this.groupBoxEntrySensors.Controls.Add(this.label4);
            this.groupBoxEntrySensors.Controls.Add(this.lblEntryBarrier);
            this.groupBoxEntrySensors.Controls.Add(this.lblEntrySensor);
            this.groupBoxEntrySensors.Controls.Add(this.label5);
            this.groupBoxEntrySensors.Location = new System.Drawing.Point(11, 19);
            this.groupBoxEntrySensors.Name = "groupBoxEntrySensors";
            this.groupBoxEntrySensors.Size = new System.Drawing.Size(141, 67);
            this.groupBoxEntrySensors.TabIndex = 1;
            this.groupBoxEntrySensors.TabStop = false;
            this.groupBoxEntrySensors.Text = "Entry";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sensor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEntryBarrier
            // 
            this.lblEntryBarrier.BackColor = System.Drawing.Color.White;
            this.lblEntryBarrier.Location = new System.Drawing.Point(60, 41);
            this.lblEntryBarrier.Name = "lblEntryBarrier";
            this.lblEntryBarrier.Size = new System.Drawing.Size(70, 20);
            this.lblEntryBarrier.TabIndex = 0;
            this.lblEntryBarrier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntrySensor
            // 
            this.lblEntrySensor.BackColor = System.Drawing.Color.White;
            this.lblEntrySensor.Location = new System.Drawing.Point(60, 16);
            this.lblEntrySensor.Name = "lblEntrySensor";
            this.lblEntrySensor.Size = new System.Drawing.Size(70, 20);
            this.lblEntrySensor.TabIndex = 0;
            this.lblEntrySensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Barrier";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(11, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Spaces";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(11, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Full Sign";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSpaces
            // 
            this.lblSpaces.BackColor = System.Drawing.Color.White;
            this.lblSpaces.Location = new System.Drawing.Point(71, 205);
            this.lblSpaces.Name = "lblSpaces";
            this.lblSpaces.Size = new System.Drawing.Size(70, 20);
            this.lblSpaces.TabIndex = 0;
            this.lblSpaces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullSign
            // 
            this.lblFullSign.BackColor = System.Drawing.Color.White;
            this.lblFullSign.Location = new System.Drawing.Point(71, 172);
            this.lblFullSign.Name = "lblFullSign";
            this.lblFullSign.Size = new System.Drawing.Size(70, 20);
            this.lblFullSign.TabIndex = 0;
            this.lblFullSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdvanceTimeHour
            // 
            this.btnAdvanceTimeHour.Location = new System.Drawing.Point(440, 30);
            this.btnAdvanceTimeHour.Name = "btnAdvanceTimeHour";
            this.btnAdvanceTimeHour.Size = new System.Drawing.Size(145, 54);
            this.btnAdvanceTimeHour.TabIndex = 6;
            this.btnAdvanceTimeHour.Text = "Advance time 1 hour";
            this.btnAdvanceTimeHour.UseVisualStyleBackColor = true;
            this.btnAdvanceTimeHour.Click += new System.EventHandler(this.btnAdvanceTimeHour_Click);
            // 
            // btnPayForChipCoin
            // 
            this.btnPayForChipCoin.Location = new System.Drawing.Point(611, 82);
            this.btnPayForChipCoin.Name = "btnPayForChipCoin";
            this.btnPayForChipCoin.Size = new System.Drawing.Size(145, 54);
            this.btnPayForChipCoin.TabIndex = 0;
            this.btnPayForChipCoin.Text = "Pay for ChipCoin";
            this.btnPayForChipCoin.UseVisualStyleBackColor = true;
            this.btnPayForChipCoin.Visible = false;
            this.btnPayForChipCoin.Click += new System.EventHandler(this.btnPayForChipCoin_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(440, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "System Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSystemTime
            // 
            this.lblSystemTime.BackColor = System.Drawing.Color.White;
            this.lblSystemTime.Location = new System.Drawing.Point(515, 7);
            this.lblSystemTime.Name = "lblSystemTime";
            this.lblSystemTime.Size = new System.Drawing.Size(70, 20);
            this.lblSystemTime.TabIndex = 8;
            this.lblSystemTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerSysTime
            // 
            this.timerSysTime.Interval = 5000;
            this.timerSysTime.Tick += new System.EventHandler(this.timerSysTime_Tick);
            // 
            // btnAdvanceTime10Min
            // 
            this.btnAdvanceTime10Min.Location = new System.Drawing.Point(440, 82);
            this.btnAdvanceTime10Min.Name = "btnAdvanceTime10Min";
            this.btnAdvanceTime10Min.Size = new System.Drawing.Size(145, 54);
            this.btnAdvanceTime10Min.TabIndex = 9;
            this.btnAdvanceTime10Min.Text = "Advance time 10 minutes";
            this.btnAdvanceTime10Min.UseVisualStyleBackColor = true;
            this.btnAdvanceTime10Min.Click += new System.EventHandler(this.btnAdvanceTime10Min_Click);
            // 
            // btnEmergencyServices
            // 
            this.btnEmergencyServices.Location = new System.Drawing.Point(5, 18);
            this.btnEmergencyServices.Name = "btnEmergencyServices";
            this.btnEmergencyServices.Size = new System.Drawing.Size(145, 54);
            this.btnEmergencyServices.TabIndex = 10;
            this.btnEmergencyServices.Text = "Emergency Vehicle At Entrance";
            this.btnEmergencyServices.UseVisualStyleBackColor = true;
            this.btnEmergencyServices.Visible = false;
            this.btnEmergencyServices.Click += new System.EventHandler(this.btnEmergencyServices_Click);
            // 
            // btnEmergencySituation
            // 
            this.btnEmergencySituation.Location = new System.Drawing.Point(156, 18);
            this.btnEmergencySituation.Name = "btnEmergencySituation";
            this.btnEmergencySituation.Size = new System.Drawing.Size(145, 54);
            this.btnEmergencySituation.TabIndex = 11;
            this.btnEmergencySituation.Text = "Emergency Entrance";
            this.btnEmergencySituation.UseVisualStyleBackColor = true;
            this.btnEmergencySituation.Visible = false;
            this.btnEmergencySituation.Click += new System.EventHandler(this.btnEmergencySituation_Click);
            // 
            // btnEmergencyExit
            // 
            this.btnEmergencyExit.Location = new System.Drawing.Point(156, 78);
            this.btnEmergencyExit.Name = "btnEmergencyExit";
            this.btnEmergencyExit.Size = new System.Drawing.Size(145, 54);
            this.btnEmergencyExit.TabIndex = 12;
            this.btnEmergencyExit.Text = "Emergency Exit";
            this.btnEmergencyExit.UseVisualStyleBackColor = true;
            this.btnEmergencyExit.Visible = false;
            this.btnEmergencyExit.Click += new System.EventHandler(this.btnEmergencyExit_Click);
            // 
            // btnEmergencyExitSensor
            // 
            this.btnEmergencyExitSensor.Location = new System.Drawing.Point(5, 78);
            this.btnEmergencyExitSensor.Name = "btnEmergencyExitSensor";
            this.btnEmergencyExitSensor.Size = new System.Drawing.Size(145, 54);
            this.btnEmergencyExitSensor.TabIndex = 13;
            this.btnEmergencyExitSensor.Text = "Emergency Vehicle At Exit";
            this.btnEmergencyExitSensor.UseVisualStyleBackColor = true;
            this.btnEmergencyExitSensor.Visible = false;
            this.btnEmergencyExitSensor.Click += new System.EventHandler(this.btnEmergencyExitSensor_Click);
            // 
            // btnEmergencyVehicleLeftCarPark
            // 
            this.btnEmergencyVehicleLeftCarPark.Location = new System.Drawing.Point(5, 138);
            this.btnEmergencyVehicleLeftCarPark.Name = "btnEmergencyVehicleLeftCarPark";
            this.btnEmergencyVehicleLeftCarPark.Size = new System.Drawing.Size(145, 54);
            this.btnEmergencyVehicleLeftCarPark.TabIndex = 14;
            this.btnEmergencyVehicleLeftCarPark.Text = "Emergency Vehicle Left Car Park";
            this.btnEmergencyVehicleLeftCarPark.UseVisualStyleBackColor = true;
            this.btnEmergencyVehicleLeftCarPark.Visible = false;
            this.btnEmergencyVehicleLeftCarPark.Click += new System.EventHandler(this.btnEmergencyVehicleLeftCarPark_Click);
            // 
            // groupBoxFaultPanel
            // 
            this.groupBoxFaultPanel.Controls.Add(this.btnPayMachineFaultFix);
            this.groupBoxFaultPanel.Controls.Add(this.btnPinFailFix);
            this.groupBoxFaultPanel.Controls.Add(this.btnLostCoinFix);
            this.groupBoxFaultPanel.Controls.Add(this.btnInvalidCoinFix);
            this.groupBoxFaultPanel.Controls.Add(this.btnPayMachineFaulty);
            this.groupBoxFaultPanel.Controls.Add(this.btnPinFail);
            this.groupBoxFaultPanel.Controls.Add(this.btnCoinLost);
            this.groupBoxFaultPanel.Controls.Add(this.btnCoinInvalid);
            this.groupBoxFaultPanel.Location = new System.Drawing.Point(888, 258);
            this.groupBoxFaultPanel.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFaultPanel.Name = "groupBoxFaultPanel";
            this.groupBoxFaultPanel.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFaultPanel.Size = new System.Drawing.Size(307, 200);
            this.groupBoxFaultPanel.TabIndex = 16;
            this.groupBoxFaultPanel.TabStop = false;
            this.groupBoxFaultPanel.Text = "Fault panel";
            // 
            // btnPayMachineFaultFix
            // 
            this.btnPayMachineFaultFix.Location = new System.Drawing.Point(154, 154);
            this.btnPayMachineFaultFix.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayMachineFaultFix.Name = "btnPayMachineFaultFix";
            this.btnPayMachineFaultFix.Size = new System.Drawing.Size(145, 41);
            this.btnPayMachineFaultFix.TabIndex = 10;
            this.btnPayMachineFaultFix.Text = "Faulty Pay Machine Resolution";
            this.btnPayMachineFaultFix.UseVisualStyleBackColor = true;
            this.btnPayMachineFaultFix.Click += new System.EventHandler(this.btnPayMachineFaultFix_Click);
            // 
            // btnPinFailFix
            // 
            this.btnPinFailFix.Location = new System.Drawing.Point(154, 108);
            this.btnPinFailFix.Margin = new System.Windows.Forms.Padding(2);
            this.btnPinFailFix.Name = "btnPinFailFix";
            this.btnPinFailFix.Size = new System.Drawing.Size(145, 41);
            this.btnPinFailFix.TabIndex = 9;
            this.btnPinFailFix.Text = "Invalid Pin Resolution";
            this.btnPinFailFix.UseVisualStyleBackColor = true;
            this.btnPinFailFix.Click += new System.EventHandler(this.btnPinFailFix_Click);
            // 
            // btnLostCoinFix
            // 
            this.btnLostCoinFix.Location = new System.Drawing.Point(154, 63);
            this.btnLostCoinFix.Margin = new System.Windows.Forms.Padding(2);
            this.btnLostCoinFix.Name = "btnLostCoinFix";
            this.btnLostCoinFix.Size = new System.Drawing.Size(145, 41);
            this.btnLostCoinFix.TabIndex = 8;
            this.btnLostCoinFix.Text = "Lost Coin Resolution";
            this.btnLostCoinFix.UseVisualStyleBackColor = true;
            this.btnLostCoinFix.Click += new System.EventHandler(this.btnLostCoinFix_Click);
            // 
            // btnInvalidCoinFix
            // 
            this.btnInvalidCoinFix.Location = new System.Drawing.Point(154, 17);
            this.btnInvalidCoinFix.Margin = new System.Windows.Forms.Padding(2);
            this.btnInvalidCoinFix.Name = "btnInvalidCoinFix";
            this.btnInvalidCoinFix.Size = new System.Drawing.Size(145, 41);
            this.btnInvalidCoinFix.TabIndex = 7;
            this.btnInvalidCoinFix.Text = "Invalid Coin Resolution";
            this.btnInvalidCoinFix.UseVisualStyleBackColor = true;
            this.btnInvalidCoinFix.Click += new System.EventHandler(this.btnInvalidCoinFix_Click);
            // 
            // btnPayMachineFaulty
            // 
            this.btnPayMachineFaulty.Location = new System.Drawing.Point(5, 154);
            this.btnPayMachineFaulty.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayMachineFaulty.Name = "btnPayMachineFaulty";
            this.btnPayMachineFaulty.Size = new System.Drawing.Size(145, 41);
            this.btnPayMachineFaulty.TabIndex = 5;
            this.btnPayMachineFaulty.Text = "Pay Machine Faulty";
            this.btnPayMachineFaulty.UseVisualStyleBackColor = true;
            this.btnPayMachineFaulty.Click += new System.EventHandler(this.btnPayMachineFaulty_Click);
            // 
            // btnPinFail
            // 
            this.btnPinFail.Location = new System.Drawing.Point(5, 108);
            this.btnPinFail.Margin = new System.Windows.Forms.Padding(2);
            this.btnPinFail.Name = "btnPinFail";
            this.btnPinFail.Size = new System.Drawing.Size(145, 41);
            this.btnPinFail.TabIndex = 4;
            this.btnPinFail.Text = "Invalid Pin";
            this.btnPinFail.UseVisualStyleBackColor = true;
            this.btnPinFail.Click += new System.EventHandler(this.btnPinFail_Click);
            // 
            // btnCoinLost
            // 
            this.btnCoinLost.Location = new System.Drawing.Point(5, 63);
            this.btnCoinLost.Margin = new System.Windows.Forms.Padding(2);
            this.btnCoinLost.Name = "btnCoinLost";
            this.btnCoinLost.Size = new System.Drawing.Size(145, 41);
            this.btnCoinLost.TabIndex = 3;
            this.btnCoinLost.Text = "Coin Lost";
            this.btnCoinLost.UseVisualStyleBackColor = true;
            this.btnCoinLost.Click += new System.EventHandler(this.btnCoinLost_Click);
            // 
            // btnCoinInvalid
            // 
            this.btnCoinInvalid.Location = new System.Drawing.Point(5, 17);
            this.btnCoinInvalid.Margin = new System.Windows.Forms.Padding(2);
            this.btnCoinInvalid.Name = "btnCoinInvalid";
            this.btnCoinInvalid.Size = new System.Drawing.Size(145, 41);
            this.btnCoinInvalid.TabIndex = 2;
            this.btnCoinInvalid.Text = "Coin Invalid";
            this.btnCoinInvalid.UseVisualStyleBackColor = true;
            this.btnCoinInvalid.Click += new System.EventHandler(this.btnCoinInvalid_Click);
            // 
            // groupBoxEmergency
            // 
            this.groupBoxEmergency.Controls.Add(this.btnEmergencyServices);
            this.groupBoxEmergency.Controls.Add(this.btnEmergencyVehicleLeftCarPark);
            this.groupBoxEmergency.Controls.Add(this.btnEmergencySituation);
            this.groupBoxEmergency.Controls.Add(this.btnEmergencyExit);
            this.groupBoxEmergency.Controls.Add(this.btnEmergencyExitSensor);
            this.groupBoxEmergency.Location = new System.Drawing.Point(888, 7);
            this.groupBoxEmergency.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxEmergency.Name = "groupBoxEmergency";
            this.groupBoxEmergency.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxEmergency.Size = new System.Drawing.Size(307, 196);
            this.groupBoxEmergency.TabIndex = 15;
            this.groupBoxEmergency.TabStop = false;
            this.groupBoxEmergency.Text = "Emergency simulator";
            this.groupBoxEmergency.Visible = false;
            // 
            // SimulatorInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 532);
            this.Controls.Add(this.groupBoxFaultPanel);
            this.Controls.Add(this.groupBoxEmergency);
            this.Controls.Add(this.btnAdvanceTime10Min);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSystemTime);
            this.Controls.Add(this.btnPayForChipCoin);
            this.Controls.Add(this.btnAdvanceTimeHour);
            this.Controls.Add(this.groupBoxInternalData);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxExitSim);
            this.Controls.Add(this.groupBoxEntrySim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimulatorInterface";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Park Simulator";
            this.groupBoxEntrySim.ResumeLayout(false);
            this.groupBoxExitSim.ResumeLayout(false);
            this.groupBoxInternalData.ResumeLayout(false);
            this.groupBoxActiveChipCoins.ResumeLayout(false);
            this.groupBoxExitSensors.ResumeLayout(false);
            this.groupBoxEntrySensors.ResumeLayout(false);
            this.groupBoxFaultPanel.ResumeLayout(false);
            this.groupBoxEmergency.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEntrySim;
        private System.Windows.Forms.Label lblChipCoinMachine;
        private System.Windows.Forms.Button btnCarEntersCarPark;
        private System.Windows.Forms.Button btnDriverPressesForChipCoin;
        private System.Windows.Forms.Button btnCarArrivesAtEntrance;
        private System.Windows.Forms.GroupBox groupBoxExitSim;
        private System.Windows.Forms.Label lblChipCoinValidator;
        private System.Windows.Forms.Button btnCarExitsCarPark;
        private System.Windows.Forms.Button btnDriverEntersChipCoin;
        private System.Windows.Forms.Button btnCarArrivesAtExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBoxInternalData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEntrySensor;
        private System.Windows.Forms.Label lblFullSign;
        private System.Windows.Forms.Label lblExitSensor;
        private System.Windows.Forms.Label lblSpaces;
        private System.Windows.Forms.GroupBox groupBoxExitSensors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEntryBarrier;
        private System.Windows.Forms.Label lblExitBarrier;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBoxEntrySensors;
        private System.Windows.Forms.GroupBox groupBoxActiveChipCoins;
        private System.Windows.Forms.Label lstActiveChipCoins;
        private System.Windows.Forms.Button btnParkCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSpacesByFloor;
        private System.Windows.Forms.Button btnCarLeavesSpace;
        private System.Windows.Forms.Button btnAdvanceTimeHour;
        private System.Windows.Forms.Button btnPayForChipCoin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSystemTime;
        private System.Windows.Forms.Timer timerSysTime;
        private System.Windows.Forms.Button btnAdvanceTime10Min;
        private System.Windows.Forms.Button btnEmergencyServices;
        private System.Windows.Forms.Button btnEmergencySituation;
        private System.Windows.Forms.Button btnEmergencyExit;
        private System.Windows.Forms.Button btnEmergencyExitSensor;
        private System.Windows.Forms.Button btnEmergencyVehicleLeftCarPark;
        private System.Windows.Forms.GroupBox groupBoxFaultPanel;
        private System.Windows.Forms.Button btnPayMachineFaultFix;
        private System.Windows.Forms.Button btnPinFailFix;
        private System.Windows.Forms.Button btnLostCoinFix;
        private System.Windows.Forms.Button btnInvalidCoinFix;
        private System.Windows.Forms.Button btnPayMachineFaulty;
        private System.Windows.Forms.Button btnPinFail;
        private System.Windows.Forms.Button btnCoinLost;
        private System.Windows.Forms.Button btnCoinInvalid;
        private System.Windows.Forms.GroupBox groupBoxEmergency;
    }
}

