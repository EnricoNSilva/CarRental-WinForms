namespace CarRental
{
    partial class Splash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            label1 = new Label();
            Credit = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            MyProgress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            Titulo1 = new PictureBox();
            MyProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Titulo1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(301, 33);
            label1.Name = "label1";
            label1.Size = new Size(422, 62);
            label1.TabIndex = 1;
            label1.Text = "Car Rental System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Credit
            // 
            Credit.AutoSize = true;
            Credit.Font = new Font("Segoe UI", 9.857143F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Credit.Location = new Point(423, 759);
            Credit.Name = "Credit";
            Credit.Size = new Size(173, 32);
            Credit.TabIndex = 2;
            Credit.Text = "Enrico N SIlva";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // MyProgress
            // 
            MyProgress.Controls.Add(Titulo1);
            MyProgress.FillColor = Color.DarkSlateGray;
            MyProgress.Font = new Font("Segoe UI", 12F);
            MyProgress.ForeColor = Color.DarkSlateGray;
            MyProgress.Location = new Point(301, 201);
            MyProgress.Minimum = 0;
            MyProgress.Name = "MyProgress";
            MyProgress.ProgressColor = SystemColors.ControlText;
            MyProgress.ProgressColor2 = SystemColors.ControlText;
            MyProgress.ShadowDecoration.CustomizableEdges = customizableEdges1;
            MyProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            MyProgress.Size = new Size(415, 415);
            MyProgress.TabIndex = 3;
            MyProgress.Text = "MyProgress";
            // 
            // Titulo1
            // 
            Titulo1.Image = (Image)resources.GetObject("Titulo1.Image");
            Titulo1.Location = new Point(72, 87);
            Titulo1.Name = "Titulo1";
            Titulo1.Size = new Size(270, 239);
            Titulo1.SizeMode = PictureBoxSizeMode.Zoom;
            Titulo1.TabIndex = 4;
            Titulo1.TabStop = false;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1000, 800);
            Controls.Add(MyProgress);
            Controls.Add(Credit);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Splash_Load;
            MyProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Titulo1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label Credit;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar MyProgress;
        private PictureBox Titulo1;
    }
}
