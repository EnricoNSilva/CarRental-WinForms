
namespace CarRental
{
    partial class Car
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Car));
            panel1 = new Panel();
            ExitCars = new Button();
            Titulo1 = new PictureBox();
            ExitUser = new Button();
            Exit = new Button();
            label2 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            BackCar = new Button();
            DeleteCar = new Button();
            EditCar = new Button();
            AddCar = new Button();
            TxtModel = new MaskedTextBox();
            ModelCar = new Label();
            BrandCar = new Label();
            TxtBrand = new MaskedTextBox();
            TxtRegNo = new MaskedTextBox();
            RegCar = new Label();
            LblLogin = new Label();
            DtgCarList = new DataGridView();
            TxtPrice = new MaskedTextBox();
            PriceCar = new Label();
            LblAvaliableCar = new Label();
            CboAvaliableCar = new ComboBox();
            TxtCarId = new MaskedTextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Titulo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtgCarList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(ExitCars);
            panel1.Controls.Add(Titulo1);
            panel1.Controls.Add(ExitUser);
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 144);
            panel1.TabIndex = 2;
            // 
            // ExitCars
            // 
            ExitCars.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitCars.BackColor = Color.OliveDrab;
            ExitCars.FlatStyle = FlatStyle.Flat;
            ExitCars.Location = new Point(1434, 12);
            ExitCars.Name = "ExitCars";
            ExitCars.Size = new Size(54, 40);
            ExitCars.TabIndex = 18;
            ExitCars.Text = "<-";
            ExitCars.UseVisualStyleBackColor = false;
            ExitCars.Click += ExitCars_Click;
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
            ExitUser.Location = new Point(2248, 12);
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
            Exit.Location = new Point(3048, 12);
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
            label2.Location = new Point(715, 101);
            label2.Name = "label2";
            label2.Size = new Size(186, 38);
            label2.TabIndex = 1;
            label2.Text = "Manage Cars";
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
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlDark;
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 980);
            panel5.Name = "panel5";
            panel5.Size = new Size(1500, 20);
            panel5.TabIndex = 45;
            // 
            // BackCar
            // 
            BackCar.FlatStyle = FlatStyle.Flat;
            BackCar.Location = new Point(227, 900);
            BackCar.Name = "BackCar";
            BackCar.Size = new Size(150, 42);
            BackCar.TabIndex = 55;
            BackCar.Text = "Back";
            BackCar.UseVisualStyleBackColor = true;
            BackCar.Click += BackCar_Click_1;
            // 
            // DeleteCar
            // 
            DeleteCar.FlatStyle = FlatStyle.Flat;
            DeleteCar.Location = new Point(47, 900);
            DeleteCar.Name = "DeleteCar";
            DeleteCar.Size = new Size(150, 42);
            DeleteCar.TabIndex = 54;
            DeleteCar.Text = "Delete";
            DeleteCar.UseVisualStyleBackColor = true;
            DeleteCar.Click += DeleteCar_Click_1;
            // 
            // EditCar
            // 
            EditCar.FlatStyle = FlatStyle.Flat;
            EditCar.Location = new Point(227, 827);
            EditCar.Name = "EditCar";
            EditCar.Size = new Size(150, 42);
            EditCar.TabIndex = 53;
            EditCar.Text = "Edit";
            EditCar.UseVisualStyleBackColor = true;
            EditCar.Click += EditCar_Click;
            // 
            // AddCar
            // 
            AddCar.FlatStyle = FlatStyle.Flat;
            AddCar.Location = new Point(47, 827);
            AddCar.Name = "AddCar";
            AddCar.Size = new Size(150, 42);
            AddCar.TabIndex = 52;
            AddCar.Text = "Add";
            AddCar.UseVisualStyleBackColor = true;
            AddCar.Click += AddCar_Click;
            // 
            // TxtModel
            // 
            TxtModel.Location = new Point(192, 498);
            TxtModel.Name = "TxtModel";
            TxtModel.Size = new Size(185, 35);
            TxtModel.TabIndex = 51;
            // 
            // ModelCar
            // 
            ModelCar.AutoSize = true;
            ModelCar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ModelCar.Location = new Point(47, 494);
            ModelCar.Name = "ModelCar";
            ModelCar.Size = new Size(101, 38);
            ModelCar.TabIndex = 50;
            ModelCar.Text = "Model";
            ModelCar.Click += ModelCar_Click;
            // 
            // BrandCar
            // 
            BrandCar.AutoSize = true;
            BrandCar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BrandCar.Location = new Point(47, 393);
            BrandCar.Name = "BrandCar";
            BrandCar.Size = new Size(95, 38);
            BrandCar.TabIndex = 47;
            BrandCar.Text = "Brand";
            // 
            // TxtBrand
            // 
            TxtBrand.Location = new Point(192, 397);
            TxtBrand.Name = "TxtBrand";
            TxtBrand.Size = new Size(185, 35);
            TxtBrand.TabIndex = 49;
            TxtBrand.MaskInputRejected += UserName_MaskInputRejected;
            // 
            // TxtRegNo
            // 
            TxtRegNo.Location = new Point(192, 299);
            TxtRegNo.Name = "TxtRegNo";
            TxtRegNo.Size = new Size(185, 35);
            TxtRegNo.TabIndex = 48;
            // 
            // RegCar
            // 
            RegCar.AutoSize = true;
            RegCar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            RegCar.Location = new Point(47, 295);
            RegCar.Name = "RegCar";
            RegCar.Size = new Size(105, 38);
            RegCar.TabIndex = 46;
            RegCar.Text = "RegNo";
            RegCar.Click += RegCar_Click;
            // 
            // LblLogin
            // 
            LblLogin.AutoSize = true;
            LblLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblLogin.Location = new Point(866, 154);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(125, 38);
            LblLogin.TabIndex = 56;
            LblLogin.Text = "Cars List";
            // 
            // DtgCarList
            // 
            DtgCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgCarList.Location = new Point(418, 195);
            DtgCarList.Name = "DtgCarList";
            DtgCarList.RowHeadersWidth = 72;
            DtgCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtgCarList.Size = new Size(1026, 747);
            DtgCarList.TabIndex = 57;
            DtgCarList.SelectionChanged += DtgCarList_SelectionChanged;
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(192, 597);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(185, 35);
            TxtPrice.TabIndex = 59;
            TxtPrice.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // PriceCar
            // 
            PriceCar.AutoSize = true;
            PriceCar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PriceCar.Location = new Point(47, 593);
            PriceCar.Name = "PriceCar";
            PriceCar.Size = new Size(81, 38);
            PriceCar.TabIndex = 58;
            PriceCar.Text = "Price";
            // 
            // LblAvaliableCar
            // 
            LblAvaliableCar.AutoSize = true;
            LblAvaliableCar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblAvaliableCar.Location = new Point(47, 696);
            LblAvaliableCar.Name = "LblAvaliableCar";
            LblAvaliableCar.Size = new Size(137, 38);
            LblAvaliableCar.TabIndex = 60;
            LblAvaliableCar.Text = "Avaliable";
            // 
            // CboAvaliableCar
            // 
            CboAvaliableCar.FormattingEnabled = true;
            CboAvaliableCar.Items.AddRange(new object[] { "Yes", "No" });
            CboAvaliableCar.Location = new Point(192, 700);
            CboAvaliableCar.Name = "CboAvaliableCar";
            CboAvaliableCar.Size = new Size(185, 38);
            CboAvaliableCar.TabIndex = 61;
            // 
            // TxtCarId
            // 
            TxtCarId.Location = new Point(192, 195);
            TxtCarId.Name = "TxtCarId";
            TxtCarId.ReadOnly = true;
            TxtCarId.Size = new Size(185, 35);
            TxtCarId.TabIndex = 62;
            TxtCarId.MaskInputRejected += maskedTextBox1_MaskInputRejected_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(47, 195);
            label3.Name = "label3";
            label3.Size = new Size(86, 38);
            label3.TabIndex = 63;
            label3.Text = "CarId";
            // 
            // Car
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 1000);
            Controls.Add(label3);
            Controls.Add(TxtCarId);
            Controls.Add(CboAvaliableCar);
            Controls.Add(LblAvaliableCar);
            Controls.Add(TxtPrice);
            Controls.Add(PriceCar);
            Controls.Add(DtgCarList);
            Controls.Add(LblLogin);
            Controls.Add(BackCar);
            Controls.Add(DeleteCar);
            Controls.Add(EditCar);
            Controls.Add(AddCar);
            Controls.Add(TxtModel);
            Controls.Add(ModelCar);
            Controls.Add(BrandCar);
            Controls.Add(TxtBrand);
            Controls.Add(TxtRegNo);
            Controls.Add(RegCar);
            Controls.Add(panel5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Car";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Titulo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtgCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UserName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ModelCar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private PictureBox Titulo1;
        private Button ExitUser;
        private Button Exit;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button3;
        private Panel panel5;
        private Button BackCar;
        private Button DeleteCar;
        private Button EditCar;
        private Button AddCar;
        private MaskedTextBox TxtModel;
        private Label ModelCar;
        private Label BrandCar;
        private Label label5;
        private MaskedTextBox TxtBrand;
        private MaskedTextBox TxtRegNo;
        private Label RegCar;
        private Label LblLogin;
        private DataGridView DtgCarList;
        private MaskedTextBox TxtPrice;
        private Label PriceCar;
        private Label LblAvaliableCar;
        private ComboBox CboAvaliableCar;
        private MaskedTextBox TxtCarId;
        private Label label3;
        private Button ExitCars;
    }
}