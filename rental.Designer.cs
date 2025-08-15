namespace CarRental
{
    partial class rental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rental));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DtgRentList = new DataGridView();
            RentalList = new Label();
            RentalBack = new Button();
            RentalDelete = new Button();
            RentalAdd = new Button();
            ModelCar = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            panel5 = new Panel();
            TimeReturnDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label10 = new Label();
            TxtCarID = new TextBox();
            label8 = new Label();
            TxtRentId = new TextBox();
            label5 = new Label();
            TxtCPFPesquisa = new MaskedTextBox();
            CboCarReg = new ComboBox();
            label2 = new Label();
            CboCarModel = new ComboBox();
            btnPesquisar = new Button();
            CPFRent = new Label();
            TxtCustID = new TextBox();
            TxtRentalAddress = new MaskedTextBox();
            TxtRentalNameCustomer = new MaskedTextBox();
            label7 = new Label();
            label6 = new Label();
            TimeRetalDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label1 = new Label();
            Placa = new Label();
            TxtRentalFee = new MaskedTextBox();
            FeeRent = new Label();
            BrandCar = new Label();
            CboFilterList = new ComboBox();
            BtnRefresh = new Button();
            ReturnRentals = new Button();
            ((System.ComponentModel.ISupportInitialize)DtgRentList).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DtgRentList
            // 
            DtgRentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgRentList.Location = new Point(605, 235);
            DtgRentList.Name = "DtgRentList";
            DtgRentList.RowHeadersWidth = 72;
            DtgRentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtgRentList.Size = new Size(858, 716);
            DtgRentList.TabIndex = 92;
            DtgRentList.SelectionChanged += DtgRentList_SelectionChanged;
            // 
            // RentalList
            // 
            RentalList.AutoSize = true;
            RentalList.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            RentalList.Location = new Point(969, 144);
            RentalList.Name = "RentalList";
            RentalList.Size = new Size(125, 38);
            RentalList.TabIndex = 91;
            RentalList.Text = "Cars List";
            // 
            // RentalBack
            // 
            RentalBack.FlatStyle = FlatStyle.Flat;
            RentalBack.Location = new Point(420, 901);
            RentalBack.Name = "RentalBack";
            RentalBack.Size = new Size(152, 50);
            RentalBack.TabIndex = 90;
            RentalBack.Text = "Back";
            RentalBack.UseVisualStyleBackColor = true;
            RentalBack.Click += RentalBack_Click;
            // 
            // RentalDelete
            // 
            RentalDelete.FlatStyle = FlatStyle.Flat;
            RentalDelete.Location = new Point(231, 901);
            RentalDelete.Name = "RentalDelete";
            RentalDelete.Size = new Size(152, 50);
            RentalDelete.TabIndex = 89;
            RentalDelete.Text = "Delete";
            RentalDelete.UseVisualStyleBackColor = true;
            RentalDelete.Click += RentalDelete_Click;
            // 
            // RentalAdd
            // 
            RentalAdd.FlatStyle = FlatStyle.Flat;
            RentalAdd.Location = new Point(41, 901);
            RentalAdd.Name = "RentalAdd";
            RentalAdd.Size = new Size(152, 50);
            RentalAdd.TabIndex = 87;
            RentalAdd.Text = "Add";
            RentalAdd.UseVisualStyleBackColor = true;
            RentalAdd.Click += RentalAdd_Click;
            // 
            // ModelCar
            // 
            ModelCar.AutoSize = true;
            ModelCar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ModelCar.Location = new Point(41, 638);
            ModelCar.Name = "ModelCar";
            ModelCar.Size = new Size(0, 38);
            ModelCar.TabIndex = 85;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(ReturnRentals);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 144);
            panel1.TabIndex = 80;
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
            label3.Size = new Size(226, 38);
            label3.TabIndex = 1;
            label3.Text = "Manage Rentals";
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
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlDark;
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 980);
            panel5.Name = "panel5";
            panel5.Size = new Size(1500, 20);
            panel5.TabIndex = 95;
            // 
            // TimeReturnDate
            // 
            TimeReturnDate.Checked = true;
            TimeReturnDate.CustomizableEdges = customizableEdges1;
            TimeReturnDate.FillColor = SystemColors.ControlDark;
            TimeReturnDate.Font = new Font("Segoe UI", 9F);
            TimeReturnDate.Format = DateTimePickerFormat.Long;
            TimeReturnDate.Location = new Point(231, 521);
            TimeReturnDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            TimeReturnDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            TimeReturnDate.Name = "TimeReturnDate";
            TimeReturnDate.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TimeReturnDate.Size = new Size(350, 38);
            TimeReturnDate.TabIndex = 173;
            TimeReturnDate.Value = new DateTime(2025, 8, 8, 9, 46, 16, 996);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(41, 521);
            label10.Name = "label10";
            label10.Size = new Size(175, 38);
            label10.TabIndex = 172;
            label10.Text = "Return Date";
            // 
            // TxtCarID
            // 
            TxtCarID.Location = new Point(159, 771);
            TxtCarID.Name = "TxtCarID";
            TxtCarID.ReadOnly = true;
            TxtCarID.Size = new Size(152, 35);
            TxtCarID.TabIndex = 171;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(41, 771);
            label8.Name = "label8";
            label8.Size = new Size(98, 38);
            label8.TabIndex = 170;
            label8.Text = "Car ID";
            // 
            // TxtRentId
            // 
            TxtRentId.Location = new Point(438, 813);
            TxtRentId.Name = "TxtRentId";
            TxtRentId.ReadOnly = true;
            TxtRentId.Size = new Size(134, 35);
            TxtRentId.TabIndex = 169;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(317, 809);
            label5.Name = "label5";
            label5.Size = new Size(115, 38);
            label5.TabIndex = 168;
            label5.Text = "Rent ID";
            // 
            // TxtCPFPesquisa
            // 
            TxtCPFPesquisa.Location = new Point(222, 354);
            TxtCPFPesquisa.Name = "TxtCPFPesquisa";
            TxtCPFPesquisa.Size = new Size(350, 35);
            TxtCPFPesquisa.TabIndex = 167;
            // 
            // CboCarReg
            // 
            CboCarReg.DropDownStyle = ComboBoxStyle.DropDownList;
            CboCarReg.FormattingEnabled = true;
            CboCarReg.Items.AddRange(new object[] { "Yes", "No" });
            CboCarReg.Location = new Point(222, 295);
            CboCarReg.Name = "CboCarReg";
            CboCarReg.Size = new Size(350, 38);
            CboCarReg.TabIndex = 166;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(41, 235);
            label2.Name = "label2";
            label2.Size = new Size(152, 38);
            label2.TabIndex = 165;
            label2.Text = "Car Model";
            // 
            // CboCarModel
            // 
            CboCarModel.DropDownStyle = ComboBoxStyle.DropDownList;
            CboCarModel.FormattingEnabled = true;
            CboCarModel.Items.AddRange(new object[] { "Yes", "No" });
            CboCarModel.Location = new Point(222, 235);
            CboCarModel.Name = "CboCarModel";
            CboCarModel.Size = new Size(350, 38);
            CboCarModel.TabIndex = 164;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(441, 395);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(131, 40);
            btnPesquisar.TabIndex = 163;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click_1;
            // 
            // CPFRent
            // 
            CPFRent.AutoSize = true;
            CPFRent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CPFRent.Location = new Point(41, 350);
            CPFRent.Name = "CPFRent";
            CPFRent.Size = new Size(186, 38);
            CPFRent.TabIndex = 162;
            CPFRent.Text = "CPF Pesquisa";
            // 
            // TxtCustID
            // 
            TxtCustID.Location = new Point(159, 838);
            TxtCustID.Name = "TxtCustID";
            TxtCustID.ReadOnly = true;
            TxtCustID.Size = new Size(152, 35);
            TxtCustID.TabIndex = 161;
            // 
            // TxtRentalAddress
            // 
            TxtRentalAddress.Location = new Point(231, 709);
            TxtRentalAddress.Name = "TxtRentalAddress";
            TxtRentalAddress.ReadOnly = true;
            TxtRentalAddress.Size = new Size(350, 35);
            TxtRentalAddress.TabIndex = 160;
            // 
            // TxtRentalNameCustomer
            // 
            TxtRentalNameCustomer.Location = new Point(231, 647);
            TxtRentalNameCustomer.Name = "TxtRentalNameCustomer";
            TxtRentalNameCustomer.ReadOnly = true;
            TxtRentalNameCustomer.Size = new Size(350, 35);
            TxtRentalNameCustomer.TabIndex = 159;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(41, 705);
            label7.Name = "label7";
            label7.Size = new Size(169, 38);
            label7.TabIndex = 158;
            label7.Text = "Cust Adress";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(41, 643);
            label6.Name = "label6";
            label6.Size = new Size(160, 38);
            label6.TabIndex = 157;
            label6.Text = "Cust Name";
            // 
            // TimeRetalDate
            // 
            TimeRetalDate.Checked = true;
            TimeRetalDate.CustomizableEdges = customizableEdges3;
            TimeRetalDate.FillColor = SystemColors.ControlDark;
            TimeRetalDate.Font = new Font("Segoe UI", 9F);
            TimeRetalDate.Format = DateTimePickerFormat.Long;
            TimeRetalDate.Location = new Point(231, 450);
            TimeRetalDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            TimeRetalDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            TimeRetalDate.Name = "TimeRetalDate";
            TimeRetalDate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TimeRetalDate.Size = new Size(350, 38);
            TimeRetalDate.TabIndex = 156;
            TimeRetalDate.Value = new DateTime(2025, 8, 8, 9, 46, 16, 996);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(41, 834);
            label1.Name = "label1";
            label1.Size = new Size(112, 38);
            label1.TabIndex = 155;
            label1.Text = "Cust ID";
            // 
            // Placa
            // 
            Placa.AutoSize = true;
            Placa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Placa.Location = new Point(41, 291);
            Placa.Name = "Placa";
            Placa.Size = new Size(156, 38);
            Placa.TabIndex = 154;
            Placa.Text = "Plate Num";
            // 
            // TxtRentalFee
            // 
            TxtRentalFee.Location = new Point(231, 584);
            TxtRentalFee.Name = "TxtRentalFee";
            TxtRentalFee.Size = new Size(350, 35);
            TxtRentalFee.TabIndex = 153;
            // 
            // FeeRent
            // 
            FeeRent.AutoSize = true;
            FeeRent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            FeeRent.Location = new Point(41, 584);
            FeeRent.Name = "FeeRent";
            FeeRent.Size = new Size(62, 38);
            FeeRent.TabIndex = 152;
            FeeRent.Text = "Fee";
            // 
            // BrandCar
            // 
            BrandCar.AutoSize = true;
            BrandCar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BrandCar.Location = new Point(41, 450);
            BrandCar.Name = "BrandCar";
            BrandCar.Size = new Size(170, 38);
            BrandCar.TabIndex = 151;
            BrandCar.Text = "Rental Date";
            // 
            // CboFilterList
            // 
            CboFilterList.DropDownStyle = ComboBoxStyle.DropDownList;
            CboFilterList.FormattingEnabled = true;
            CboFilterList.Location = new Point(872, 197);
            CboFilterList.Name = "CboFilterList";
            CboFilterList.Size = new Size(212, 38);
            CboFilterList.TabIndex = 174;
            // 
            // BtnRefresh
            // 
            BtnRefresh.FlatStyle = FlatStyle.Flat;
            BtnRefresh.Location = new Point(1081, 195);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(134, 40);
            BtnRefresh.TabIndex = 175;
            BtnRefresh.Text = "Refresh";
            BtnRefresh.UseVisualStyleBackColor = true;
            BtnRefresh.Click += BtnRefresh_Click;
            // 
            // ReturnRentals
            // 
            ReturnRentals.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ReturnRentals.BackColor = Color.OliveDrab;
            ReturnRentals.FlatStyle = FlatStyle.Flat;
            ReturnRentals.Location = new Point(1434, 12);
            ReturnRentals.Name = "ReturnRentals";
            ReturnRentals.Size = new Size(54, 40);
            ReturnRentals.TabIndex = 176;
            ReturnRentals.Text = "<-";
            ReturnRentals.UseVisualStyleBackColor = false;
            ReturnRentals.Click += ReturnRentals_Click;
            // 
            // rental
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 1000);
            Controls.Add(BtnRefresh);
            Controls.Add(CboFilterList);
            Controls.Add(TimeReturnDate);
            Controls.Add(label10);
            Controls.Add(TxtCarID);
            Controls.Add(label8);
            Controls.Add(TxtRentId);
            Controls.Add(label5);
            Controls.Add(TxtCPFPesquisa);
            Controls.Add(CboCarReg);
            Controls.Add(label2);
            Controls.Add(CboCarModel);
            Controls.Add(btnPesquisar);
            Controls.Add(CPFRent);
            Controls.Add(TxtCustID);
            Controls.Add(TxtRentalAddress);
            Controls.Add(TxtRentalNameCustomer);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(TimeRetalDate);
            Controls.Add(label1);
            Controls.Add(Placa);
            Controls.Add(TxtRentalFee);
            Controls.Add(FeeRent);
            Controls.Add(BrandCar);
            Controls.Add(panel5);
            Controls.Add(DtgRentList);
            Controls.Add(RentalList);
            Controls.Add(RentalBack);
            Controls.Add(RentalDelete);
            Controls.Add(RentalAdd);
            Controls.Add(ModelCar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "rental";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "rental";
            Load += rental_Load;
            ((System.ComponentModel.ISupportInitialize)DtgRentList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DtgRentList;
        private Label RentalList;
        private Button RentalBack;
        private Button RentalDelete;
        private Button RentalAdd;
        private Label ModelCar;
        private Panel panel1;
        //private Button button1;
        private PictureBox pictureBox1;
        //private Button ExitUser;
        private Label label3;
        private Label label4;
        //private Button ExitCustomer;
        private Panel panel5;
        private Guna.UI2.WinForms.Guna2DateTimePicker TimeReturnDate;
        private Label label10;
        private TextBox TxtCarID;
        private Label label8;
        private TextBox TxtRentId;
        private Label label5;
        private MaskedTextBox TxtCPFPesquisa;
        private ComboBox CboCarReg;
        private Label label2;
        private ComboBox CboCarModel;
        private Button btnPesquisar;
        private Label CPFRent;
        private TextBox TxtCustID;
        private MaskedTextBox TxtRentalAddress;
        private MaskedTextBox TxtRentalNameCustomer;
        private Label label7;
        private Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker TimeRetalDate;
        private Label label1;
        private Label Placa;
        private MaskedTextBox TxtRentalFee;
        private Label FeeRent;
        private Label BrandCar;
        private ComboBox CboFilterList;
        private Button BtnRefresh;
        private Button ReturnRentals;
    }
}