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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnParkCar = new System.Windows.Forms.Button();
            this.lblChipCoinMachine = new System.Windows.Forms.Label();
            this.btnCarEntersCarPark = new System.Windows.Forms.Button();
            this.btnDriverPressesForChipCoin = new System.Windows.Forms.Button();
            this.btnCarArrivesAtEntrance = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCarLeavesSpace = new System.Windows.Forms.Button();
            this.lblChipCoinValidator = new System.Windows.Forms.Label();
            this.btnCarExitsCarPark = new System.Windows.Forms.Button();
            this.btnDriverEntersChipCoin = new System.Windows.Forms.Button();
            this.btnCarArrivesAtExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSpacesByFloor = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lstActiveChipCoins = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblExitBarrier = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblExitSensor = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnParkCar);
            this.groupBox1.Controls.Add(this.lblChipCoinMachine);
            this.groupBox1.Controls.Add(this.btnCarEntersCarPark);
            this.groupBox1.Controls.Add(this.btnDriverPressesForChipCoin);
            this.groupBox1.Controls.Add(this.btnCarArrivesAtEntrance);
            this.groupBox1.Location = new System.Drawing.Point(16, 182);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 368);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrance simulator";
            // 
            // btnParkCar
            // 
            this.btnParkCar.Location = new System.Drawing.Point(8, 292);
            this.btnParkCar.Margin = new System.Windows.Forms.Padding(4);
            this.btnParkCar.Name = "btnParkCar";
            this.btnParkCar.Size = new System.Drawing.Size(251, 66);
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
            this.lblChipCoinMachine.Location = new System.Drawing.Point(8, 25);
            this.lblChipCoinMachine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChipCoinMachine.Name = "lblChipCoinMachine";
            this.lblChipCoinMachine.Size = new System.Drawing.Size(250, 38);
            this.lblChipCoinMachine.TabIndex = 1;
            this.lblChipCoinMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCarEntersCarPark
            // 
            this.btnCarEntersCarPark.Location = new System.Drawing.Point(8, 218);
            this.btnCarEntersCarPark.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarEntersCarPark.Name = "btnCarEntersCarPark";
            this.btnCarEntersCarPark.Size = new System.Drawing.Size(251, 66);
            this.btnCarEntersCarPark.TabIndex = 3;
            this.btnCarEntersCarPark.Text = "Car enters car park";
            this.btnCarEntersCarPark.UseVisualStyleBackColor = true;
            this.btnCarEntersCarPark.Visible = false;
            this.btnCarEntersCarPark.Click += new System.EventHandler(this.CarEntersCarPark);
            // 
            // btnDriverPressesForChipCoin
            // 
            this.btnDriverPressesForChipCoin.Location = new System.Drawing.Point(8, 144);
            this.btnDriverPressesForChipCoin.Margin = new System.Windows.Forms.Padding(4);
            this.btnDriverPressesForChipCoin.Name = "btnDriverPressesForChipCoin";
            this.btnDriverPressesForChipCoin.Size = new System.Drawing.Size(251, 66);
            this.btnDriverPressesForChipCoin.TabIndex = 1;
            this.btnDriverPressesForChipCoin.Text = "Driver presses for ChipCoin";
            this.btnDriverPressesForChipCoin.UseVisualStyleBackColor = true;
            this.btnDriverPressesForChipCoin.Visible = false;
            this.btnDriverPressesForChipCoin.Click += new System.EventHandler(this.DriverPressesForChipCoin);
            // 
            // btnCarArrivesAtEntrance
            // 
            this.btnCarArrivesAtEntrance.Location = new System.Drawing.Point(8, 70);
            this.btnCarArrivesAtEntrance.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarArrivesAtEntrance.Name = "btnCarArrivesAtEntrance";
            this.btnCarArrivesAtEntrance.Size = new System.Drawing.Size(251, 66);
            this.btnCarArrivesAtEntrance.TabIndex = 0;
            this.btnCarArrivesAtEntrance.Text = "Car arrives at entrance";
            this.btnCarArrivesAtEntrance.UseVisualStyleBackColor = true;
            this.btnCarArrivesAtEntrance.Visible = false;
            this.btnCarArrivesAtEntrance.Click += new System.EventHandler(this.CarArrivesAtEntrance);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCarLeavesSpace);
            this.groupBox2.Controls.Add(this.lblChipCoinValidator);
            this.groupBox2.Controls.Add(this.btnCarExitsCarPark);
            this.groupBox2.Controls.Add(this.btnDriverEntersChipCoin);
            this.groupBox2.Controls.Add(this.btnCarArrivesAtExit);
            this.groupBox2.Location = new System.Drawing.Point(301, 182);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 368);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exit simulator";
            // 
            // btnCarLeavesSpace
            // 
            this.btnCarLeavesSpace.Location = new System.Drawing.Point(8, 70);
            this.btnCarLeavesSpace.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarLeavesSpace.Name = "btnCarLeavesSpace";
            this.btnCarLeavesSpace.Size = new System.Drawing.Size(251, 66);
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
            this.lblChipCoinValidator.Location = new System.Drawing.Point(8, 25);
            this.lblChipCoinValidator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChipCoinValidator.Name = "lblChipCoinValidator";
            this.lblChipCoinValidator.Size = new System.Drawing.Size(250, 38);
            this.lblChipCoinValidator.TabIndex = 1;
            this.lblChipCoinValidator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCarExitsCarPark
            // 
            this.btnCarExitsCarPark.Location = new System.Drawing.Point(8, 290);
            this.btnCarExitsCarPark.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarExitsCarPark.Name = "btnCarExitsCarPark";
            this.btnCarExitsCarPark.Size = new System.Drawing.Size(251, 66);
            this.btnCarExitsCarPark.TabIndex = 2;
            this.btnCarExitsCarPark.Text = "Car exits car park";
            this.btnCarExitsCarPark.UseVisualStyleBackColor = true;
            this.btnCarExitsCarPark.Visible = false;
            this.btnCarExitsCarPark.Click += new System.EventHandler(this.CarExitsCarPark);
            // 
            // btnDriverEntersChipCoin
            // 
            this.btnDriverEntersChipCoin.Location = new System.Drawing.Point(8, 217);
            this.btnDriverEntersChipCoin.Margin = new System.Windows.Forms.Padding(4);
            this.btnDriverEntersChipCoin.Name = "btnDriverEntersChipCoin";
            this.btnDriverEntersChipCoin.Size = new System.Drawing.Size(251, 66);
            this.btnDriverEntersChipCoin.TabIndex = 1;
            this.btnDriverEntersChipCoin.Text = "Driver enters ChipCoin";
            this.btnDriverEntersChipCoin.UseVisualStyleBackColor = true;
            this.btnDriverEntersChipCoin.Visible = false;
            this.btnDriverEntersChipCoin.Click += new System.EventHandler(this.DriverEntersChipCoin);
            // 
            // btnCarArrivesAtExit
            // 
            this.btnCarArrivesAtExit.Location = new System.Drawing.Point(8, 143);
            this.btnCarArrivesAtExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarArrivesAtExit.Name = "btnCarArrivesAtExit";
            this.btnCarArrivesAtExit.Size = new System.Drawing.Size(251, 66);
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
            this.label3.Location = new System.Drawing.Point(20, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(510, 65);
            this.label3.TabIndex = 4;
            this.label3.Text = "Car Park Simulator";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(24, 102);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(536, 66);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Start";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.ResetSystem);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblSpacesByFloor);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblSpaces);
            this.groupBox3.Controls.Add(this.lblFullSign);
            this.groupBox3.Location = new System.Drawing.Point(587, 182);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(571, 438);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Internal data";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 66);
            this.label1.TabIndex = 8;
            this.label1.Text = "Spaces by floor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSpacesByFloor
            // 
            this.lblSpacesByFloor.BackColor = System.Drawing.Color.White;
            this.lblSpacesByFloor.Location = new System.Drawing.Point(95, 292);
            this.lblSpacesByFloor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpacesByFloor.Name = "lblSpacesByFloor";
            this.lblSpacesByFloor.Size = new System.Drawing.Size(93, 66);
            this.lblSpacesByFloor.TabIndex = 9;
            this.lblSpacesByFloor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lstActiveChipCoins);
            this.groupBox6.Location = new System.Drawing.Point(228, 25);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(335, 260);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Active ChipCoins";
            // 
            // lstActiveChipCoins
            // 
            this.lstActiveChipCoins.BackColor = System.Drawing.Color.White;
            this.lstActiveChipCoins.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lstActiveChipCoins.Location = new System.Drawing.Point(8, 18);
            this.lstActiveChipCoins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lstActiveChipCoins.Name = "lstActiveChipCoins";
            this.lstActiveChipCoins.Size = new System.Drawing.Size(319, 233);
            this.lstActiveChipCoins.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.lblExitBarrier);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.lblExitSensor);
            this.groupBox5.Location = new System.Drawing.Point(15, 113);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(188, 82);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Exit";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sensor";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExitBarrier
            // 
            this.lblExitBarrier.BackColor = System.Drawing.Color.White;
            this.lblExitBarrier.Location = new System.Drawing.Point(80, 50);
            this.lblExitBarrier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExitBarrier.Name = "lblExitBarrier";
            this.lblExitBarrier.Size = new System.Drawing.Size(93, 25);
            this.lblExitBarrier.TabIndex = 0;
            this.lblExitBarrier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(8, 50);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Barrier";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExitSensor
            // 
            this.lblExitSensor.BackColor = System.Drawing.Color.White;
            this.lblExitSensor.Location = new System.Drawing.Point(80, 20);
            this.lblExitSensor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExitSensor.Name = "lblExitSensor";
            this.lblExitSensor.Size = new System.Drawing.Size(93, 25);
            this.lblExitSensor.TabIndex = 0;
            this.lblExitSensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lblEntryBarrier);
            this.groupBox4.Controls.Add(this.lblEntrySensor);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(15, 23);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(188, 82);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Entry";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sensor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEntryBarrier
            // 
            this.lblEntryBarrier.BackColor = System.Drawing.Color.White;
            this.lblEntryBarrier.Location = new System.Drawing.Point(80, 50);
            this.lblEntryBarrier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntryBarrier.Name = "lblEntryBarrier";
            this.lblEntryBarrier.Size = new System.Drawing.Size(93, 25);
            this.lblEntryBarrier.TabIndex = 0;
            this.lblEntryBarrier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntrySensor
            // 
            this.lblEntrySensor.BackColor = System.Drawing.Color.White;
            this.lblEntrySensor.Location = new System.Drawing.Point(80, 20);
            this.lblEntrySensor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntrySensor.Name = "lblEntrySensor";
            this.lblEntrySensor.Size = new System.Drawing.Size(93, 25);
            this.lblEntrySensor.TabIndex = 0;
            this.lblEntrySensor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Barrier";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(15, 252);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Spaces";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(15, 212);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Full Sign";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSpaces
            // 
            this.lblSpaces.BackColor = System.Drawing.Color.White;
            this.lblSpaces.Location = new System.Drawing.Point(95, 252);
            this.lblSpaces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpaces.Name = "lblSpaces";
            this.lblSpaces.Size = new System.Drawing.Size(93, 25);
            this.lblSpaces.TabIndex = 0;
            this.lblSpaces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullSign
            // 
            this.lblFullSign.BackColor = System.Drawing.Color.White;
            this.lblFullSign.Location = new System.Drawing.Point(95, 212);
            this.lblFullSign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullSign.Name = "lblFullSign";
            this.lblFullSign.Size = new System.Drawing.Size(93, 25);
            this.lblFullSign.TabIndex = 0;
            this.lblFullSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdvanceTimeHour
            // 
            this.btnAdvanceTimeHour.Location = new System.Drawing.Point(587, 37);
            this.btnAdvanceTimeHour.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdvanceTimeHour.Name = "btnAdvanceTimeHour";
            this.btnAdvanceTimeHour.Size = new System.Drawing.Size(193, 66);
            this.btnAdvanceTimeHour.TabIndex = 6;
            this.btnAdvanceTimeHour.Text = "Advance time 1 hour";
            this.btnAdvanceTimeHour.UseVisualStyleBackColor = true;
            this.btnAdvanceTimeHour.Click += new System.EventHandler(this.btnAdvanceTimeHour_Click);
            // 
            // btnPayForChipCoin
            // 
            this.btnPayForChipCoin.Location = new System.Drawing.Point(815, 101);
            this.btnPayForChipCoin.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayForChipCoin.Name = "btnPayForChipCoin";
            this.btnPayForChipCoin.Size = new System.Drawing.Size(193, 66);
            this.btnPayForChipCoin.TabIndex = 0;
            this.btnPayForChipCoin.Text = "Pay for ChipCoin";
            this.btnPayForChipCoin.UseVisualStyleBackColor = true;
            this.btnPayForChipCoin.Visible = false;
            this.btnPayForChipCoin.Click += new System.EventHandler(this.btnPayForChipCoin_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(587, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "System Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSystemTime
            // 
            this.lblSystemTime.BackColor = System.Drawing.Color.White;
            this.lblSystemTime.Location = new System.Drawing.Point(687, 9);
            this.lblSystemTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSystemTime.Name = "lblSystemTime";
            this.lblSystemTime.Size = new System.Drawing.Size(93, 25);
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
            this.btnAdvanceTime10Min.Location = new System.Drawing.Point(587, 101);
            this.btnAdvanceTime10Min.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdvanceTime10Min.Name = "btnAdvanceTime10Min";
            this.btnAdvanceTime10Min.Size = new System.Drawing.Size(193, 66);
            this.btnAdvanceTime10Min.TabIndex = 9;
            this.btnAdvanceTime10Min.Text = "Advance time 10 minutes";
            this.btnAdvanceTime10Min.UseVisualStyleBackColor = true;
            this.btnAdvanceTime10Min.Click += new System.EventHandler(this.btnAdvanceTime10Min_Click);
            // 
            // btnEmergencyServices
            // 
            this.btnEmergencyServices.Location = new System.Drawing.Point(1205, 37);
            this.btnEmergencyServices.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmergencyServices.Name = "btnEmergencyServices";
            this.btnEmergencyServices.Size = new System.Drawing.Size(193, 66);
            this.btnEmergencyServices.TabIndex = 10;
            this.btnEmergencyServices.Text = "Emergency Services Only";
            this.btnEmergencyServices.UseVisualStyleBackColor = true;
            this.btnEmergencyServices.Visible = false;
            this.btnEmergencyServices.Click += new System.EventHandler(this.btnEmergencyServices_Click);
            // 
            // btnEmergencySituation
            // 
            this.btnEmergencySituation.Location = new System.Drawing.Point(1406, 37);
            this.btnEmergencySituation.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmergencySituation.Name = "btnEmergencySituation";
            this.btnEmergencySituation.Size = new System.Drawing.Size(193, 66);
            this.btnEmergencySituation.TabIndex = 11;
            this.btnEmergencySituation.Text = "Emergency Entrance";
            this.btnEmergencySituation.UseVisualStyleBackColor = true;
            this.btnEmergencySituation.Visible = false;
            this.btnEmergencySituation.Click += new System.EventHandler(this.btnEmergencySituation_Click);
            // 
            // btnEmergencyExit
            // 
            this.btnEmergencyExit.Location = new System.Drawing.Point(1406, 111);
            this.btnEmergencyExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmergencyExit.Name = "btnEmergencyExit";
            this.btnEmergencyExit.Size = new System.Drawing.Size(193, 66);
            this.btnEmergencyExit.TabIndex = 12;
            this.btnEmergencyExit.Text = "Emergency Exit";
            this.btnEmergencyExit.UseVisualStyleBackColor = true;
            this.btnEmergencyExit.Visible = false;
            this.btnEmergencyExit.Click += new System.EventHandler(this.btnEmergencyExit_Click);
            // 
            // btnEmergencyExitSensor
            // 
            this.btnEmergencyExitSensor.Location = new System.Drawing.Point(1205, 111);
            this.btnEmergencyExitSensor.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmergencyExitSensor.Name = "btnEmergencyExitSensor";
            this.btnEmergencyExitSensor.Size = new System.Drawing.Size(193, 66);
            this.btnEmergencyExitSensor.TabIndex = 13;
            this.btnEmergencyExitSensor.Text = "Emergency Vehicle At Exit";
            this.btnEmergencyExitSensor.UseVisualStyleBackColor = true;
            this.btnEmergencyExitSensor.Visible = false;
            this.btnEmergencyExitSensor.Click += new System.EventHandler(this.btnEmergencyExitSensor_Click);
            // 
            // btnEmergencyVehicleLeftCarPark
            // 
            this.btnEmergencyVehicleLeftCarPark.Location = new System.Drawing.Point(1205, 185);
            this.btnEmergencyVehicleLeftCarPark.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmergencyVehicleLeftCarPark.Name = "btnEmergencyVehicleLeftCarPark";
            this.btnEmergencyVehicleLeftCarPark.Size = new System.Drawing.Size(193, 66);
            this.btnEmergencyVehicleLeftCarPark.TabIndex = 14;
            this.btnEmergencyVehicleLeftCarPark.Text = "Emergency Vehicle Left Car Park";
            this.btnEmergencyVehicleLeftCarPark.UseVisualStyleBackColor = true;
            this.btnEmergencyVehicleLeftCarPark.Visible = false;
            this.btnEmergencyVehicleLeftCarPark.Click += new System.EventHandler(this.btnEmergencyVehicleLeftCarPark_Click);
            // 
            // SimulatorInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 655);
            this.Controls.Add(this.btnEmergencyVehicleLeftCarPark);
            this.Controls.Add(this.btnEmergencyExitSensor);
            this.Controls.Add(this.btnEmergencyExit);
            this.Controls.Add(this.btnEmergencySituation);
            this.Controls.Add(this.btnEmergencyServices);
            this.Controls.Add(this.btnAdvanceTime10Min);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSystemTime);
            this.Controls.Add(this.btnPayForChipCoin);
            this.Controls.Add(this.btnAdvanceTimeHour);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimulatorInterface";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Park Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblChipCoinMachine;
        private System.Windows.Forms.Button btnCarEntersCarPark;
        private System.Windows.Forms.Button btnDriverPressesForChipCoin;
        private System.Windows.Forms.Button btnCarArrivesAtEntrance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblChipCoinValidator;
        private System.Windows.Forms.Button btnCarExitsCarPark;
        private System.Windows.Forms.Button btnDriverEntersChipCoin;
        private System.Windows.Forms.Button btnCarArrivesAtExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEntrySensor;
        private System.Windows.Forms.Label lblFullSign;
        private System.Windows.Forms.Label lblExitSensor;
        private System.Windows.Forms.Label lblSpaces;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEntryBarrier;
        private System.Windows.Forms.Label lblExitBarrier;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
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
    }
}

