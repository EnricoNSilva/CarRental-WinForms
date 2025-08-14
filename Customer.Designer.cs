
namespace CarRental
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            TxtPhoneCustomer = new MaskedTextBox();
            PriceCar = new Label();
            DtgCustomerList = new DataGridView();
            CustomerList = new Label();
            CustomerBack = new Button();
            CustomerDelete = new Button();
            CustomerEdit = new Button();
            CustomerAdd = new Button();
            TxtAdressCustomer = new MaskedTextBox();
            ModelCar = new Label();
            BrandCar = new Label();
            TxtNameCustomer = new MaskedTextBox();
            TxtIdCustomer = new MaskedTextBox();
            RegCar = new Label();
            panel5 = new Panel();
            CpfCust = new Label();
            TxtCpfCust = new MaskedTextBox();
            panel1 = new Panel();
            ExitCustomers = new Button();
            Titulo1 = new PictureBox();
            ExitUser = new Button();
            Exit = new Button();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DtgCustomerList).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Titulo1).BeginInit();
            SuspendLayout();
            // 
            // TxtPhoneCustomer
            // 
            TxtPhoneCustomer.Location = new Point(182, 643);
            TxtPhoneCustomer.Name = "TxtPhoneCustomer";
            TxtPhoneCustomer.Size = new Size(185, 35);
            TxtPhoneCustomer.TabIndex = 76;
            // 
            // PriceCar
            // 
            PriceCar.AutoSize = true;
            PriceCar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PriceCar.Location = new Point(37, 639);
            PriceCar.Name = "PriceCar";
            PriceCar.Size = new Size(100, 38);
            PriceCar.TabIndex = 75;
            PriceCar.Text = "Phone";
            // 
            // DtgCustomerList
            // 
            DtgCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgCustomerList.Location = new Point(434, 192);
            DtgCustomerList.Name = "DtgCustomerList";
            DtgCustomerList.RowHeadersWidth = 72;
            DtgCustomerList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtgCustomerList.Size = new Size(992, 727);
            DtgCustomerList.TabIndex = 74;
            DtgCustomerList.SelectionChanged += DtgCustomerList_SelecctionChanged;
            // 
            // CustomerList
            // 
            CustomerList.AutoSize = true;
            CustomerList.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CustomerList.Location = new Point(869, 151);
            CustomerList.Name = "CustomerList";
            CustomerList.Size = new Size(196, 38);
            CustomerList.TabIndex = 73;
            CustomerList.Text = "Customer List";
            // 
            // CustomerBack
            // 
            CustomerBack.FlatStyle = FlatStyle.Flat;
            CustomerBack.Location = new Point(217, 877);
            CustomerBack.Name = "CustomerBack";
            CustomerBack.Size = new Size(150, 42);
            CustomerBack.TabIndex = 72;
            CustomerBack.Text = "Back";
            CustomerBack.UseVisualStyleBackColor = true;
            // 
            // CustomerDelete
            // 
            CustomerDelete.FlatStyle = FlatStyle.Flat;
            CustomerDelete.Location = new Point(42, 877);
            CustomerDelete.Name = "CustomerDelete";
            CustomerDelete.Size = new Size(150, 42);
            CustomerDelete.TabIndex = 71;
            CustomerDelete.Text = "Delete";
            CustomerDelete.UseVisualStyleBackColor = true;
            CustomerDelete.Click += CustomerDelete_Click;
            // 
            // CustomerEdit
            // 
            CustomerEdit.FlatStyle = FlatStyle.Flat;
            CustomerEdit.Location = new Point(217, 801);
            CustomerEdit.Name = "CustomerEdit";
            CustomerEdit.Size = new Size(150, 42);
            CustomerEdit.TabIndex = 70;
            CustomerEdit.Text = "Edit";
            CustomerEdit.UseVisualStyleBackColor = true;
            CustomerEdit.Click += CustomerEdit_Click;
            // 
            // CustomerAdd
            // 
            CustomerAdd.FlatStyle = FlatStyle.Flat;
            CustomerAdd.Location = new Point(42, 801);
            CustomerAdd.Name = "CustomerAdd";
            CustomerAdd.Size = new Size(150, 42);
            CustomerAdd.TabIndex = 69;
            CustomerAdd.Text = "Add";
            CustomerAdd.UseVisualStyleBackColor = true;
            CustomerAdd.Click += CustomerAdd_Click;
            // 
            // TxtAdressCustomer
            // 
            TxtAdressCustomer.Location = new Point(182, 534);
            TxtAdressCustomer.Name = "TxtAdressCustomer";
            TxtAdressCustomer.Size = new Size(185, 35);
            TxtAdressCustomer.TabIndex = 68;
            // 
            // ModelCar
            // 
            ModelCar.AutoSize = true;
            ModelCar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ModelCar.Location = new Point(37, 530);
            ModelCar.Name = "ModelCar";
            ModelCar.Size = new Size(104, 38);
            ModelCar.TabIndex = 67;
            ModelCar.Text = "Adress";
            // 
            // BrandCar
            // 
            BrandCar.AutoSize = true;
            BrandCar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BrandCar.Location = new Point(37, 431);
            BrandCar.Name = "BrandCar";
            BrandCar.Size = new Size(95, 38);
            BrandCar.TabIndex = 64;
            BrandCar.Text = "Name";
            // 
            // TxtNameCustomer
            // 
            TxtNameCustomer.Location = new Point(182, 431);
            TxtNameCustomer.Name = "TxtNameCustomer";
            TxtNameCustomer.Size = new Size(185, 35);
            TxtNameCustomer.TabIndex = 66;
            // 
            // TxtIdCustomer
            // 
            TxtIdCustomer.Location = new Point(182, 192);
            TxtIdCustomer.Name = "TxtIdCustomer";
            TxtIdCustomer.ReadOnly = true;
            TxtIdCustomer.Size = new Size(185, 35);
            TxtIdCustomer.TabIndex = 65;
            // 
            // RegCar
            // 
            RegCar.AutoSize = true;
            RegCar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            RegCar.Location = new Point(37, 192);
            RegCar.Name = "RegCar";
            RegCar.Size = new Size(47, 38);
            RegCar.TabIndex = 63;
            RegCar.Text = "ID";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlDark;
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 980);
            panel5.Name = "panel5";
            panel5.Size = new Size(1500, 20);
            panel5.TabIndex = 62;
            // 
            // CpfCust
            // 
            CpfCust.AutoSize = true;
            CpfCust.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            CpfCust.Location = new Point(37, 317);
            CpfCust.Name = "CpfCust";
            CpfCust.Size = new Size(62, 38);
            CpfCust.TabIndex = 77;
            CpfCust.Text = "Cpf";
            // 
            // TxtCpfCust
            // 
            TxtCpfCust.Location = new Point(182, 317);
            TxtCpfCust.Name = "TxtCpfCust";
            TxtCpfCust.Size = new Size(185, 35);
            TxtCpfCust.TabIndex = 78;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(ExitCustomers);
            panel1.Controls.Add(Titulo1);
            panel1.Controls.Add(ExitUser);
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 144);
            panel1.TabIndex = 79;
            // 
            // ExitCustomers
            // 
            ExitCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitCustomers.BackColor = Color.OliveDrab;
            ExitCustomers.FlatStyle = FlatStyle.Flat;
            ExitCustomers.Location = new Point(1434, 12);
            ExitCustomers.Name = "ExitCustomers";
            ExitCustomers.Size = new Size(54, 40);
            ExitCustomers.TabIndex = 80;
            ExitCustomers.Text = "<-";
            ExitCustomers.UseVisualStyleBackColor = false;
            ExitCustomers.Click += ExitCustomers_Click;
            // 
            // Titulo1
            // 
            Titulo1.Image = (Image)resources.GetObject("Titulo1.Image");
            Titulo1.Location = new Point(12, 12);
            Titulo1.Name = "Titulo1";
            Titulo1.Size = new Size(96, 75);
            Titulo1.SizeMode = PictureBoxSizeMode.Zoom;
            Titulo1.TabIndex = 14;
            Titulo1.TabStop = false;
            // 
            // ExitUser
            // 
            ExitUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitUser.BackColor = Color.Firebrick;
            ExitUser.FlatStyle = FlatStyle.Flat;
            ExitUser.Location = new Point(3548, 12);
            ExitUser.Name = "ExitUser";
            ExitUser.Size = new Size(40, 40);
            ExitUser.TabIndex = 10;
            ExitUser.Text = "X";
            ExitUser.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Exit.BackColor = Color.Red;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Location = new Point(4348, 12);
            Exit.Name = "Exit";
            Exit.Size = new Size(40, 40);
            Exit.TabIndex = 9;
            Exit.Text = "X";
            Exit.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(685, 106);
            label2.Name = "label2";
            label2.Size = new Size(269, 38);
            label2.TabIndex = 1;
            label2.Text = "Manage Customers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.Location = new Point(577, 17);
            label1.Name = "label1";
            label1.Size = new Size(469, 70);
            label1.TabIndex = 0;
            label1.Text = "Car Rental System";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 1000);
            Controls.Add(panel1);
            Controls.Add(TxtCpfCust);
            Controls.Add(CpfCust);
            Controls.Add(TxtPhoneCustomer);
            Controls.Add(PriceCar);
            Controls.Add(DtgCustomerList);
            Controls.Add(CustomerList);
            Controls.Add(CustomerBack);
            Controls.Add(CustomerDelete);
            Controls.Add(CustomerEdit);
            Controls.Add(CustomerAdd);
            Controls.Add(TxtAdressCustomer);
            Controls.Add(ModelCar);
            Controls.Add(BrandCar);
            Controls.Add(TxtNameCustomer);
            Controls.Add(TxtIdCustomer);
            Controls.Add(RegCar);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)DtgCustomerList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Titulo1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox TxtPhoneCustomer;
        private Label PriceCar;
        private DataGridView DtgCustomerList;
        private Label CustomerList;
        private Button CustomerBack;
        private Button CustomerDelete;
        private Button CustomerEdit;
        private Button CustomerAdd;
        private MaskedTextBox TxtAdressCustomer;
        private Label ModelCar;
        private Label BrandCar;
        private MaskedTextBox TxtNameCustomer;
        private MaskedTextBox TxtIdCustomer;
        private Label RegCar;
        private Panel panel5;
        private Label CpfCust;
        private MaskedTextBox TxtCpfCust;
        private Panel panel1;
        private PictureBox Titulo1;
        private Button ExitUser;
        private Button Exit;
        private Label label2;
        private Label label1;
        private Button ExitCustomers;
    }
}