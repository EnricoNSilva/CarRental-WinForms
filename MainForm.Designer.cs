namespace CarRental
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BtnCarsMain = new Button();
            BtnCustomerMain = new Button();
            BtnRentalMain = new Button();
            BtnReturnMain = new Button();
            BtnUsersMain = new Button();
            panel5 = new Panel();
            Titulo1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            ExitMain = new Button();
            Logout = new Button();
            BtnDashboard = new Button();
            BtnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)Titulo1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCarsMain
            // 
            BtnCarsMain.FlatStyle = FlatStyle.Flat;
            BtnCarsMain.Location = new Point(37, 209);
            BtnCarsMain.Name = "BtnCarsMain";
            BtnCarsMain.Size = new Size(150, 57);
            BtnCarsMain.TabIndex = 1;
            BtnCarsMain.Text = "Car";
            BtnCarsMain.UseVisualStyleBackColor = true;
            BtnCarsMain.Click += BtnCarsMain_Click;
            // 
            // BtnCustomerMain
            // 
            BtnCustomerMain.FlatStyle = FlatStyle.Flat;
            BtnCustomerMain.Location = new Point(256, 209);
            BtnCustomerMain.Name = "BtnCustomerMain";
            BtnCustomerMain.Size = new Size(150, 57);
            BtnCustomerMain.TabIndex = 2;
            BtnCustomerMain.Text = "Customer";
            BtnCustomerMain.UseVisualStyleBackColor = true;
            BtnCustomerMain.Click += BtnCustomerMain_Click;
            // 
            // BtnRentalMain
            // 
            BtnRentalMain.FlatStyle = FlatStyle.Flat;
            BtnRentalMain.Location = new Point(473, 209);
            BtnRentalMain.Name = "BtnRentalMain";
            BtnRentalMain.Size = new Size(150, 57);
            BtnRentalMain.TabIndex = 3;
            BtnRentalMain.Text = "Rental";
            BtnRentalMain.UseVisualStyleBackColor = true;
            BtnRentalMain.Click += BtnRentalMain_Click;
            // 
            // BtnReturnMain
            // 
            BtnReturnMain.FlatStyle = FlatStyle.Flat;
            BtnReturnMain.Location = new Point(681, 209);
            BtnReturnMain.Name = "BtnReturnMain";
            BtnReturnMain.Size = new Size(150, 57);
            BtnReturnMain.TabIndex = 4;
            BtnReturnMain.Text = "Return";
            BtnReturnMain.UseVisualStyleBackColor = true;
            BtnReturnMain.Click += BtnReturnMain_Click;
            // 
            // BtnUsersMain
            // 
            BtnUsersMain.FlatStyle = FlatStyle.Flat;
            BtnUsersMain.Location = new Point(900, 209);
            BtnUsersMain.Name = "BtnUsersMain";
            BtnUsersMain.Size = new Size(150, 57);
            BtnUsersMain.TabIndex = 5;
            BtnUsersMain.Text = "Users";
            BtnUsersMain.UseVisualStyleBackColor = true;
            BtnUsersMain.Click += BtnUsersMain_Click;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlDark;
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 980);
            panel5.Name = "panel5";
            panel5.Size = new Size(1500, 20);
            panel5.TabIndex = 6;
            // 
            // Titulo1
            // 
            Titulo1.Image = (Image)resources.GetObject("Titulo1.Image");
            Titulo1.Location = new Point(367, 349);
            Titulo1.Name = "Titulo1";
            Titulo1.Size = new Size(759, 448);
            Titulo1.SizeMode = PictureBoxSizeMode.Zoom;
            Titulo1.TabIndex = 7;
            Titulo1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.Location = new Point(554, 12);
            label1.Name = "label1";
            label1.Size = new Size(469, 70);
            label1.TabIndex = 0;
            label1.Text = "Car Rental System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(713, 95);
            label2.Name = "label2";
            label2.Size = new Size(161, 38);
            label2.TabIndex = 1;
            label2.Text = "Main Form";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(ExitMain);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 144);
            panel1.TabIndex = 0;
            // 
            // ExitMain
            // 
            ExitMain.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitMain.BackColor = Color.Firebrick;
            ExitMain.FlatStyle = FlatStyle.Flat;
            ExitMain.Location = new Point(1448, 12);
            ExitMain.Name = "ExitMain";
            ExitMain.Size = new Size(40, 40);
            ExitMain.TabIndex = 9;
            ExitMain.Text = "X";
            ExitMain.UseVisualStyleBackColor = false;
            ExitMain.Click += Exit_Click_1;
            // 
            // Logout
            // 
            Logout.FlatStyle = FlatStyle.Flat;
            Logout.Location = new Point(640, 885);
            Logout.Name = "Logout";
            Logout.Size = new Size(200, 57);
            Logout.TabIndex = 8;
            Logout.Text = "Logout";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // BtnDashboard
            // 
            BtnDashboard.FlatStyle = FlatStyle.Flat;
            BtnDashboard.Location = new Point(1111, 209);
            BtnDashboard.Name = "BtnDashboard";
            BtnDashboard.Size = new Size(150, 57);
            BtnDashboard.TabIndex = 9;
            BtnDashboard.Text = "Dashboard";
            BtnDashboard.UseVisualStyleBackColor = true;
            BtnDashboard.Click += BtnDashboard_Click;
            // 
            // BtnExport
            // 
            BtnExport.FlatStyle = FlatStyle.Flat;
            BtnExport.Location = new Point(1319, 209);
            BtnExport.Name = "BtnExport";
            BtnExport.Size = new Size(150, 57);
            BtnExport.TabIndex = 10;
            BtnExport.Text = "Export";
            BtnExport.UseVisualStyleBackColor = true;
            BtnExport.Click += BtnExport_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 1000);
            Controls.Add(BtnExport);
            Controls.Add(BtnDashboard);
            Controls.Add(Logout);
            Controls.Add(Titulo1);
            Controls.Add(panel5);
            Controls.Add(BtnUsersMain);
            Controls.Add(BtnReturnMain);
            Controls.Add(BtnRentalMain);
            Controls.Add(BtnCustomerMain);
            Controls.Add(BtnCarsMain);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "xx'";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)Titulo1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button BtnCarsMain;
        private Button BtnCustomerMain;
        private Button BtnRentalMain;
        private Button BtnReturnMain;
        private Button BtnUsersMain;
        private Panel panel5;
        private PictureBox Titulo1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button Logout;
        private Button ExitMain;
        private Button BtnDashboard;
        private Button BtnExport;
    }
}