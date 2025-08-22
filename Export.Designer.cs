namespace CarRental
{
    partial class Export
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export));
            panel1 = new Panel();
            ExitExports = new Button();
            label2 = new Label();
            Titulo1 = new PictureBox();
            ExitUser = new Button();
            Exit = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            BtnExportCars = new Button();
            ExportCustomers = new Button();
            BtnExportRentals = new Button();
            BtnExportReturns = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Titulo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(ExitExports);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Titulo1);
            panel1.Controls.Add(ExitUser);
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1476, 144);
            panel1.TabIndex = 5;
            // 
            // ExitExports
            // 
            ExitExports.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitExports.BackColor = Color.OliveDrab;
            ExitExports.FlatStyle = FlatStyle.Flat;
            ExitExports.Location = new Point(1410, 12);
            ExitExports.Name = "ExitExports";
            ExitExports.Size = new Size(54, 40);
            ExitExports.TabIndex = 17;
            ExitExports.Text = "<-";
            ExitExports.UseVisualStyleBackColor = false;
            ExitExports.Click += ExitExports_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(715, 101);
            label2.Name = "label2";
            label2.Size = new Size(193, 38);
            label2.TabIndex = 1;
            label2.Text = "Export Tables";
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
            ExitUser.Location = new Point(4924, 12);
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
            Exit.Location = new Point(5724, 12);
            Exit.Name = "Exit";
            Exit.Size = new Size(40, 40);
            Exit.TabIndex = 9;
            Exit.Text = "X";
            Exit.UseVisualStyleBackColor = false;
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
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(505, 247);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(591, 475);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // BtnExportCars
            // 
            BtnExportCars.FlatStyle = FlatStyle.Flat;
            BtnExportCars.Location = new Point(91, 833);
            BtnExportCars.Name = "BtnExportCars";
            BtnExportCars.Size = new Size(255, 50);
            BtnExportCars.TabIndex = 125;
            BtnExportCars.Text = "Export Cars";
            BtnExportCars.UseVisualStyleBackColor = true;
            BtnExportCars.Click += BtnExportCars_Click_1;
            // 
            // ExportCustomers
            // 
            ExportCustomers.FlatStyle = FlatStyle.Flat;
            ExportCustomers.Location = new Point(441, 833);
            ExportCustomers.Name = "ExportCustomers";
            ExportCustomers.Size = new Size(255, 50);
            ExportCustomers.TabIndex = 126;
            ExportCustomers.Text = "Export Customers";
            ExportCustomers.UseVisualStyleBackColor = true;
            ExportCustomers.Click += ExportCustomers_Click;
            // 
            // BtnExportRentals
            // 
            BtnExportRentals.FlatStyle = FlatStyle.Flat;
            BtnExportRentals.Location = new Point(800, 833);
            BtnExportRentals.Name = "BtnExportRentals";
            BtnExportRentals.Size = new Size(255, 50);
            BtnExportRentals.TabIndex = 127;
            BtnExportRentals.Text = "Export Rentals";
            BtnExportRentals.UseVisualStyleBackColor = true;
            BtnExportRentals.Click += BtnExportRentals_Click;
            // 
            // BtnExportReturns
            // 
            BtnExportReturns.FlatStyle = FlatStyle.Flat;
            BtnExportReturns.Location = new Point(1145, 833);
            BtnExportReturns.Name = "BtnExportReturns";
            BtnExportReturns.Size = new Size(255, 50);
            BtnExportReturns.TabIndex = 128;
            BtnExportReturns.Text = "Export Returns";
            BtnExportReturns.UseVisualStyleBackColor = true;
            BtnExportReturns.Click += BtnExportReturns_Click;
            // 
            // Export
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1476, 936);
            Controls.Add(BtnExportReturns);
            Controls.Add(BtnExportRentals);
            Controls.Add(ExportCustomers);
            Controls.Add(BtnExportCars);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Export";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Export";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Titulo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox Titulo1;
        private Button ExitUser;
        private Button Exit;
        private Label label1;
        private PictureBox pictureBox1;
        private Button ExitExports;
        private Button BtnExportCars;
        private Button ExportCustomers;
        private Button BtnExportRentals;
        private Button BtnExportReturns;
    }
}