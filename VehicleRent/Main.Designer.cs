namespace VehicleRent
{
    partial class Main
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
            this.listOutput = new System.Windows.Forms.ListBox();
            this.lblTravelled = new System.Windows.Forms.Label();
            this.txtTravelled = new System.Windows.Forms.TextBox();
            this.txtFuel = new System.Windows.Forms.TextBox();
            this.lblFuel = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMakeYear = new System.Windows.Forms.TextBox();
            this.txtRegistration = new System.Windows.Forms.TextBox();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblAllVehicles = new System.Windows.Forms.Label();
            this.listAllInfo = new System.Windows.Forms.ListBox();
            this.lblAllOutput = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listOutput
            // 
            this.listOutput.FormattingEnabled = true;
            this.listOutput.Location = new System.Drawing.Point(361, 33);
            this.listOutput.Name = "listOutput";
            this.listOutput.Size = new System.Drawing.Size(769, 82);
            this.listOutput.TabIndex = 10;
            // 
            // lblTravelled
            // 
            this.lblTravelled.AutoSize = true;
            this.lblTravelled.Location = new System.Drawing.Point(27, 221);
            this.lblTravelled.Name = "lblTravelled";
            this.lblTravelled.Size = new System.Drawing.Size(98, 13);
            this.lblTravelled.TabIndex = 3;
            this.lblTravelled.Text = "Kilometers travelled";
            // 
            // txtTravelled
            // 
            this.txtTravelled.Location = new System.Drawing.Point(138, 221);
            this.txtTravelled.Name = "txtTravelled";
            this.txtTravelled.Size = new System.Drawing.Size(121, 20);
            this.txtTravelled.TabIndex = 7;
            // 
            // txtFuel
            // 
            this.txtFuel.Location = new System.Drawing.Point(138, 257);
            this.txtFuel.Name = "txtFuel";
            this.txtFuel.Size = new System.Drawing.Size(121, 20);
            this.txtFuel.TabIndex = 8;
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(28, 257);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(53, 13);
            this.lblFuel.TabIndex = 6;
            this.lblFuel.Text = "Fuel used";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(271, 290);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(84, 20);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Manufacturer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Make Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Registration";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(143, 22);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(116, 20);
            this.txtManufacturer.TabIndex = 1;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(143, 48);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(116, 20);
            this.txtModel.TabIndex = 2;
            // 
            // txtMakeYear
            // 
            this.txtMakeYear.Location = new System.Drawing.Point(143, 74);
            this.txtMakeYear.Name = "txtMakeYear";
            this.txtMakeYear.Size = new System.Drawing.Size(116, 20);
            this.txtMakeYear.TabIndex = 3;
            // 
            // txtRegistration
            // 
            this.txtRegistration.Location = new System.Drawing.Point(143, 100);
            this.txtRegistration.Name = "txtRegistration";
            this.txtRegistration.Size = new System.Drawing.Size(116, 20);
            this.txtRegistration.TabIndex = 4;
            // 
            // btnVehicle
            // 
            this.btnVehicle.Location = new System.Drawing.Point(271, 100);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(75, 20);
            this.btnVehicle.TabIndex = 5;
            this.btnVehicle.Text = "Add Vehicle";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(28, 187);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(56, 13);
            this.lblId.TabIndex = 19;
            this.lblId.Text = "Vehicle ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(138, 187);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 6;
            // 
            // lblAllVehicles
            // 
            this.lblAllVehicles.AutoSize = true;
            this.lblAllVehicles.Location = new System.Drawing.Point(400, 17);
            this.lblAllVehicles.Name = "lblAllVehicles";
            this.lblAllVehicles.Size = new System.Drawing.Size(61, 13);
            this.lblAllVehicles.TabIndex = 21;
            this.lblAllVehicles.Text = "All Vehicles";
            // 
            // listAllInfo
            // 
            this.listAllInfo.FormattingEnabled = true;
            this.listAllInfo.Location = new System.Drawing.Point(361, 175);
            this.listAllInfo.Name = "listAllInfo";
            this.listAllInfo.Size = new System.Drawing.Size(953, 160);
            this.listAllInfo.TabIndex = 11;
            // 
            // lblAllOutput
            // 
            this.lblAllOutput.AutoSize = true;
            this.lblAllOutput.Location = new System.Drawing.Point(400, 159);
            this.lblAllOutput.Name = "lblAllOutput";
            this.lblAllOutput.Size = new System.Drawing.Size(72, 13);
            this.lblAllOutput.TabIndex = 23;
            this.lblAllOutput.Text = "All information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Days hired";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(138, 290);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(121, 20);
            this.txtDays.TabIndex = 25;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 427);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAllOutput);
            this.Controls.Add(this.listAllInfo);
            this.Controls.Add(this.lblAllVehicles);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnVehicle);
            this.Controls.Add(this.txtRegistration);
            this.Controls.Add(this.txtMakeYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblFuel);
            this.Controls.Add(this.txtFuel);
            this.Controls.Add(this.txtTravelled);
            this.Controls.Add(this.lblTravelled);
            this.Controls.Add(this.listOutput);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listOutput;
        private System.Windows.Forms.Label lblTravelled;
        private System.Windows.Forms.TextBox txtTravelled;
        private System.Windows.Forms.TextBox txtFuel;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMakeYear;
        private System.Windows.Forms.TextBox txtRegistration;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblAllVehicles;
        private System.Windows.Forms.ListBox listAllInfo;
        private System.Windows.Forms.Label lblAllOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDays;
    }
}

