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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnParkCar = new System.Windows.Forms.Button();
            this.lblChipCoinMachine = new System.Windows.Forms.Label();
            this.btnCarEntersCarPark = new System.Windows.Forms.Button();
            this.btnDriverPressesForChipCoin = new System.Windows.Forms.Button();
            this.btnCarArrivesAtEntrance = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnPayForChipCoin = new System.Windows.Forms.Button();
            this.btnCarLeavesSpace = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnParkCar);
            this.groupBox1.Controls.Add(this.lblChipCoinMachine);
            this.groupBox1.Controls.Add(this.btnCarEntersCarPark);
            this.groupBox1.Controls.Add(this.btnDriverPressesForChipCoin);
            this.groupBox1.Controls.Add(this.btnCarArrivesAtEntrance);
            this.groupBox1.Location = new System.Drawing.Point(12, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 299);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrance simulator";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCarLeavesSpace);
            this.groupBox2.Controls.Add(this.lblChipCoinValidator);
            this.groupBox2.Controls.Add(this.btnCarExitsCarPark);
            this.groupBox2.Controls.Add(this.btnDriverEntersChipCoin);
            this.groupBox2.Controls.Add(this.btnCarArrivesAtExit);
            this.groupBox2.Location = new System.Drawing.Point(226, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 299);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exit simulator";
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
            this.btnReset.Text = "Reset";
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
            this.groupBox3.Location = new System.Drawing.Point(440, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 356);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Internal data";
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lstActiveChipCoins);
            this.groupBox6.Location = new System.Drawing.Point(171, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(144, 211);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Active ChipCoins";
            // 
            // lstActiveChipCoins
            // 
            this.lstActiveChipCoins.BackColor = System.Drawing.Color.White;
            this.lstActiveChipCoins.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lstActiveChipCoins.Location = new System.Drawing.Point(6, 15);
            this.lstActiveChipCoins.Name = "lstActiveChipCoins";
            this.lstActiveChipCoins.Size = new System.Drawing.Size(132, 189);
            this.lstActiveChipCoins.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.lblExitBarrier);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.lblExitSensor);
            this.groupBox5.Location = new System.Drawing.Point(11, 92);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(141, 67);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Exit";
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lblEntryBarrier);
            this.groupBox4.Controls.Add(this.lblEntrySensor);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(11, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(141, 67);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Entry";
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
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnPayForChipCoin);
            this.groupBox7.Location = new System.Drawing.Point(568, 54);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 82);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Pay Machine simulator";
            // 
            // btnPayForChipCoin
            // 
            this.btnPayForChipCoin.Location = new System.Drawing.Point(6, 19);
            this.btnPayForChipCoin.Name = "btnPayForChipCoin";
            this.btnPayForChipCoin.Size = new System.Drawing.Size(188, 54);
            this.btnPayForChipCoin.TabIndex = 0;
            this.btnPayForChipCoin.Text = "Pay for ChipCoin";
            this.btnPayForChipCoin.UseVisualStyleBackColor = true;
            this.btnPayForChipCoin.Click += new System.EventHandler(this.btnPayForChipCoin_Click);
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
            // SimulatorInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 532);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.groupBox7.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnPayForChipCoin;
        private System.Windows.Forms.Button btnParkCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSpacesByFloor;
        private System.Windows.Forms.Button btnCarLeavesSpace;
    }
}

