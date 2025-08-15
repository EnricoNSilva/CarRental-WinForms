namespace CarRental
{
    partial class Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ExitCustomer = new Button();
            DtgRentList = new DataGridView();
            RentalList = new Label();
            panel5 = new Panel();
            TxtCarID = new TextBox();
            label8 = new Label();
            TxtRentId = new TextBox();
            label5 = new Label();
            label2 = new Label();
            TxtCustID = new TextBox();
            TxtFineReturn = new MaskedTextBox();
            TxtReturnNameCustomer = new MaskedTextBox();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            Placa = new Label();
            TxtReturnFee = new MaskedTextBox();
            FeeRent = new Label();
            RentalBack = new Button();
            ReturnAdd = new Button();
            BrandCar = new Label();
            label9 = new Label();
            DtgReturnList = new DataGridView();
            label10 = new Label();
            label11 = new Label();
            TxtDelayReturn = new TextBox();
            TxtCarModelReturn = new MaskedTextBox();
            TxtPlacaReturn = new MaskedTextBox();
            label12 = new Label();
            TxtRentalDate = new MaskedTextBox();
            TxtExpectedReturn = new MaskedTextBox();
            TimeReturnDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ReturnReturns = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtgRentList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtgReturnList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(ReturnReturns);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ExitCustomer);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 144);
            panel1.TabIndex = 81;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(605, 83);
            label3.Name = "label3";
            label3.Size = new Size(231, 38);
            label3.TabIndex = 1;
            label3.Text = "Manage Returns";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label4.Location = new Point(512, 0);
            label4.Name = "label4";
            label4.Size = new Size(469, 70);
            label4.TabIndex = 0;
            label4.Text = "Car Rental System";
            // 
            // ExitCustomer
            // 
            ExitCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitCustomer.BackColor = Color.Firebrick;
            ExitCustomer.FlatStyle = FlatStyle.Flat;
            ExitCustomer.Location = new Point(3548, 12);
            ExitCustomer.Name = "ExitCustomer";
            ExitCustomer.Size = new Size(40, 40);
            ExitCustomer.TabIndex = 19;
            ExitCustomer.Text = "X";
            ExitCustomer.UseVisualStyleBackColor = false;
            // 
            // DtgRentList
            // 
            DtgRentList.AllowUserToAddRows = false;
            DtgRentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgRentList.Location = new Point(615, 220);
            DtgRentList.Name = "DtgRentList";
            DtgRentList.RowHeadersWidth = 72;
            DtgRentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtgRentList.Size = new Size(858, 324);
            DtgRentList.TabIndex = 94;
            DtgRentList.CellContentClick += DtgRentList_CellContentClick;
            // 
            // RentalList
            // 
            RentalList.AutoSize = true;
            RentalList.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            RentalList.Location = new Point(949, 171);
            RentalList.Name = "RentalList";
            RentalList.Size = new Size(186, 38);
            RentalList.TabIndex = 93;
            RentalList.Text = "Cars On Rent";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlDark;
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 980);
            panel5.Name = "panel5";
            panel5.Size = new Size(1500, 20);
            panel5.TabIndex = 96;
            // 
            // TxtCarID
            // 
            TxtCarID.Location = new Point(441, 508);
            TxtCarID.Name = "TxtCarID";
            TxtCarID.ReadOnly = true;
            TxtCarID.Size = new Size(134, 35);
            TxtCarID.TabIndex = 146;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(323, 505);
            label8.Name = "label8";
            label8.Size = new Size(98, 38);
            label8.TabIndex = 145;
            label8.Text = "Car ID";
            // 
            // TxtRentId
            // 
            TxtRentId.Location = new Point(441, 329);
            TxtRentId.Name = "TxtRentId";
            TxtRentId.ReadOnly = true;
            TxtRentId.Size = new Size(134, 35);
            TxtRentId.TabIndex = 144;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(323, 325);
            label5.Name = "label5";
            label5.Size = new Size(115, 38);
            label5.TabIndex = 143;
            label5.Text = "Rent ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(35, 445);
            label2.Name = "label2";
            label2.Size = new Size(152, 38);
            label2.TabIndex = 140;
            label2.Text = "Car Model";
            // 
            // TxtCustID
            // 
            TxtCustID.Location = new Point(501, 622);
            TxtCustID.Name = "TxtCustID";
            TxtCustID.ReadOnly = true;
            TxtCustID.Size = new Size(74, 35);
            TxtCustID.TabIndex = 136;
            // 
            // TxtFineReturn
            // 
            TxtFineReturn.Location = new Point(122, 789);
            TxtFineReturn.Name = "TxtFineReturn";
            TxtFineReturn.ReadOnly = true;
            TxtFineReturn.Size = new Size(168, 35);
            TxtFineReturn.TabIndex = 135;
            // 
            // TxtReturnNameCustomer
            // 
            TxtReturnNameCustomer.Location = new Point(202, 622);
            TxtReturnNameCustomer.Name = "TxtReturnNameCustomer";
            TxtReturnNameCustomer.ReadOnly = true;
            TxtReturnNameCustomer.Size = new Size(177, 35);
            TxtReturnNameCustomer.TabIndex = 134;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(38, 785);
            label7.Name = "label7";
            label7.Size = new Size(72, 38);
            label7.TabIndex = 133;
            label7.Text = "Fine";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(35, 619);
            label6.Name = "label6";
            label6.Size = new Size(160, 38);
            label6.TabIndex = 132;
            label6.Text = "Cust Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(384, 618);
            label1.Name = "label1";
            label1.Size = new Size(112, 38);
            label1.TabIndex = 130;
            label1.Text = "Cust ID";
            // 
            // Placa
            // 
            Placa.AutoSize = true;
            Placa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Placa.Location = new Point(35, 501);
            Placa.Name = "Placa";
            Placa.Size = new Size(85, 38);
            Placa.TabIndex = 129;
            Placa.Text = "Placa";
            Placa.Click += Placa_Click;
            // 
            // TxtReturnFee
            // 
            TxtReturnFee.Location = new Point(103, 329);
            TxtReturnFee.Name = "TxtReturnFee";
            TxtReturnFee.ReadOnly = true;
            TxtReturnFee.Size = new Size(214, 35);
            TxtReturnFee.TabIndex = 128;
            // 
            // FeeRent
            // 
            FeeRent.AutoSize = true;
            FeeRent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            FeeRent.Location = new Point(35, 329);
            FeeRent.Name = "FeeRent";
            FeeRent.Size = new Size(62, 38);
            FeeRent.TabIndex = 127;
            FeeRent.Text = "Fee";
            // 
            // RentalBack
            // 
            RentalBack.FlatStyle = FlatStyle.Flat;
            RentalBack.Location = new Point(311, 887);
            RentalBack.Name = "RentalBack";
            RentalBack.Size = new Size(264, 50);
            RentalBack.TabIndex = 126;
            RentalBack.Text = "Back";
            RentalBack.UseVisualStyleBackColor = true;
            RentalBack.Click += RentalBack_Click;
            // 
            // ReturnAdd
            // 
            ReturnAdd.FlatStyle = FlatStyle.Flat;
            ReturnAdd.Location = new Point(35, 887);
            ReturnAdd.Name = "ReturnAdd";
            ReturnAdd.Size = new Size(255, 50);
            ReturnAdd.TabIndex = 124;
            ReturnAdd.Text = "Return Car";
            ReturnAdd.UseVisualStyleBackColor = true;
            ReturnAdd.Click += ReturnAdd_Click;
            // 
            // BrandCar
            // 
            BrandCar.AutoSize = true;
            BrandCar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BrandCar.Location = new Point(35, 223);
            BrandCar.Name = "BrandCar";
            BrandCar.Size = new Size(170, 38);
            BrandCar.TabIndex = 123;
            BrandCar.Text = "Rental Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(949, 569);
            label9.Name = "label9";
            label9.Size = new Size(200, 38);
            label9.TabIndex = 147;
            label9.Text = "Cars Returned";
            // 
            // DtgReturnList
            // 
            DtgReturnList.AllowUserToAddRows = false;
            DtgReturnList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgReturnList.Location = new Point(615, 622);
            DtgReturnList.Name = "DtgReturnList";
            DtgReturnList.RowHeadersWidth = 72;
            DtgReturnList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtgReturnList.Size = new Size(858, 315);
            DtgReturnList.TabIndex = 148;
            DtgReturnList.CellContentClick += DtgReturnList_CellContentClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(35, 275);
            label10.Name = "label10";
            label10.Size = new Size(231, 38);
            label10.TabIndex = 149;
            label10.Text = "Expected Return";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.Location = new Point(311, 785);
            label11.Name = "label11";
            label11.Size = new Size(91, 38);
            label11.TabIndex = 151;
            label11.Text = "Delay";
            // 
            // TxtDelayReturn
            // 
            TxtDelayReturn.Location = new Point(408, 789);
            TxtDelayReturn.Name = "TxtDelayReturn";
            TxtDelayReturn.ReadOnly = true;
            TxtDelayReturn.Size = new Size(167, 35);
            TxtDelayReturn.TabIndex = 152;
            // 
            // TxtCarModelReturn
            // 
            TxtCarModelReturn.Location = new Point(225, 448);
            TxtCarModelReturn.Name = "TxtCarModelReturn";
            TxtCarModelReturn.ReadOnly = true;
            TxtCarModelReturn.Size = new Size(350, 35);
            TxtCarModelReturn.TabIndex = 153;
            // 
            // TxtPlacaReturn
            // 
            TxtPlacaReturn.Location = new Point(140, 508);
            TxtPlacaReturn.Name = "TxtPlacaReturn";
            TxtPlacaReturn.ReadOnly = true;
            TxtPlacaReturn.Size = new Size(177, 35);
            TxtPlacaReturn.TabIndex = 154;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(38, 728);
            label12.Name = "label12";
            label12.Size = new Size(167, 38);
            label12.TabIndex = 155;
            label12.Text = "ReturnDate";
            label12.Click += label12_Click;
            // 
            // TxtRentalDate
            // 
            TxtRentalDate.Location = new Point(225, 227);
            TxtRentalDate.Name = "TxtRentalDate";
            TxtRentalDate.ReadOnly = true;
            TxtRentalDate.Size = new Size(350, 35);
            TxtRentalDate.TabIndex = 157;
            // 
            // TxtExpectedReturn
            // 
            TxtExpectedReturn.Location = new Point(272, 279);
            TxtExpectedReturn.Name = "TxtExpectedReturn";
            TxtExpectedReturn.ReadOnly = true;
            TxtExpectedReturn.Size = new Size(303, 35);
            TxtExpectedReturn.TabIndex = 158;
            // 
            // TimeReturnDate
            // 
            TimeReturnDate.Checked = true;
            TimeReturnDate.CustomizableEdges = customizableEdges1;
            TimeReturnDate.FillColor = SystemColors.ControlDark;
            TimeReturnDate.Font = new Font("Segoe UI", 9F);
            TimeReturnDate.Format = DateTimePickerFormat.Long;
            TimeReturnDate.Location = new Point(225, 728);
            TimeReturnDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            TimeReturnDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            TimeReturnDate.Name = "TimeReturnDate";
            TimeReturnDate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TimeReturnDate.Size = new Size(350, 38);
            TimeReturnDate.TabIndex = 174;
            TimeReturnDate.Value = new DateTime(2025, 8, 8, 9, 46, 16, 996);
            // 
            // ReturnReturns
            // 
            ReturnReturns.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ReturnReturns.BackColor = Color.OliveDrab;
            ReturnReturns.FlatStyle = FlatStyle.Flat;
            ReturnReturns.Location = new Point(1434, 12);
            ReturnReturns.Name = "ReturnReturns";
            ReturnReturns.Size = new Size(54, 40);
            ReturnReturns.TabIndex = 175;
            ReturnReturns.Text = "<-";
            ReturnReturns.UseVisualStyleBackColor = false;
            ReturnReturns.Click += ReturnReturns_Click;
            // 
            // Return
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 1000);
            Controls.Add(TimeReturnDate);
            Controls.Add(TxtExpectedReturn);
            Controls.Add(TxtRentalDate);
            Controls.Add(label12);
            Controls.Add(TxtPlacaReturn);
            Controls.Add(TxtCarModelReturn);
            Controls.Add(TxtDelayReturn);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(DtgReturnList);
            Controls.Add(label9);
            Controls.Add(TxtCarID);
            Controls.Add(label8);
            Controls.Add(TxtRentId);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(TxtCustID);
            Controls.Add(TxtFineReturn);
            Controls.Add(TxtReturnNameCustomer);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(Placa);
            Controls.Add(TxtReturnFee);
            Controls.Add(FeeRent);
            Controls.Add(RentalBack);
            Controls.Add(ReturnAdd);
            Controls.Add(BrandCar);
            Controls.Add(panel5);
            Controls.Add(DtgRentList);
            Controls.Add(RentalList);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Return";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Return";
            Load += Return_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtgRentList).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtgReturnList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        //private Button BtnExitRental;
        //private Button button1;
        private PictureBox pictureBox1;
        //private Button ExitUser;
        //private Button Exit;
        private Label label3;
        private Label label4;
        private Button ExitCustomer;
        private DataGridView DtgRentList;
        private Label RentalList;
        private Panel panel5;
        private TextBox TxtCarID;
        private Label label8;
        private TextBox TxtRentId;
        private Label label5;
        private Label label2;
        private TextBox TxtCustID;
        private MaskedTextBox TxtFineReturn;
        private MaskedTextBox TxtReturnNameCustomer;
        private Label label7;
        private Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker TimeRetalDate;
        private Label label1;
        private Label Placa;
        private MaskedTextBox TxtReturnFee;
        private Label FeeRent;
        private Button RentalBack;
        private Button ReturnAdd;
        private Label BrandCar;
        private Label label9;
        private DataGridView DtgReturnList;
        private Guna.UI2.WinForms.Guna2DateTimePicker TimeReturnDate;
        private Label label10;
        private Label label11;
        private TextBox TxtDelayReturn;
        private MaskedTextBox TxtCarModelReturn;
        private MaskedTextBox TxtPlacaReturn;
        private Label label12;
        private MaskedTextBox TxtRentalDate;
        private MaskedTextBox TxtExpectedReturn;
        private Button ReturnReturns;
    }
}