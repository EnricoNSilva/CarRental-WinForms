namespace CarRental
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            LblTitulo = new Label();
            Titulo1 = new PictureBox();
            BtnLogin = new Button();
            label1 = new Label();
            label3 = new Label();
            TxtUserID = new MaskedTextBox();
            TxtPassword = new MaskedTextBox();
            ExitCar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Titulo1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(LblTitulo);
            panel1.Controls.Add(Titulo1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 600);
            panel1.TabIndex = 0;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.BackColor = Color.Transparent;
            LblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            LblTitulo.Location = new Point(93, 85);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(190, 47);
            LblTitulo.TabIndex = 2;
            LblTitulo.Text = "Car Rental";
            // 
            // Titulo1
            // 
            Titulo1.Image = (Image)resources.GetObject("Titulo1.Image");
            Titulo1.Location = new Point(31, 160);
            Titulo1.Name = "Titulo1";
            Titulo1.Size = new Size(287, 257);
            Titulo1.SizeMode = PictureBoxSizeMode.Zoom;
            Titulo1.TabIndex = 1;
            Titulo1.TabStop = false;
            Titulo1.Click += Titulo1_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.DarkSlateGray;
            BtnLogin.Font = new Font("Segoe UI", 12F);
            BtnLogin.ForeColor = SystemColors.ButtonFace;
            BtnLogin.Location = new Point(534, 399);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(252, 65);
            BtnLogin.TabIndex = 2;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(397, 149);
            label1.Name = "label1";
            label1.Size = new Size(201, 47);
            label1.TabIndex = 5;
            label1.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(397, 268);
            label3.Name = "label3";
            label3.Size = new Size(175, 47);
            label3.TabIndex = 6;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // TxtUserID
            // 
            TxtUserID.Location = new Point(621, 161);
            TxtUserID.Name = "TxtUserID";
            TxtUserID.Size = new Size(252, 35);
            TxtUserID.TabIndex = 7;
            TxtUserID.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(621, 280);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(252, 35);
            TxtPassword.TabIndex = 8;
            // 
            // ExitCar
            // 
            ExitCar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitCar.BackColor = Color.Firebrick;
            ExitCar.FlatStyle = FlatStyle.Flat;
            ExitCar.Location = new Point(948, 12);
            ExitCar.Name = "ExitCar";
            ExitCar.Size = new Size(40, 40);
            ExitCar.TabIndex = 16;
            ExitCar.Text = "X";
            ExitCar.UseVisualStyleBackColor = false;
            ExitCar.Click += ExitCar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(ExitCar);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUserID);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(BtnLogin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Titulo1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox Titulo1;
        private Label LblTitulo;
        private Button BtnLogin;
        private Label label1;
        private Label label3;
        private MaskedTextBox TxtUserID;
        private MaskedTextBox TxtPassword;
        private Button ExitCar;
    }
}