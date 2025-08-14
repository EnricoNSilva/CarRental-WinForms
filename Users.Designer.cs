namespace CarRental
{
    partial class UsersLoad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersLoad));
            panel1 = new Panel();
            Titulo1 = new PictureBox();
            Exit = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            UserName = new MaskedTextBox();
            UserId = new MaskedTextBox();
            label4 = new Label();
            LblLogin = new Label();
            label5 = new Label();
            UserPassword = new MaskedTextBox();
            UserAdd = new Button();
            EditUser = new Button();
            DeleteUser = new Button();
            BackUser = new Button();
            DtgUserList = new DataGridView();
            panel5 = new Panel();
            ReturnReturns = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Titulo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtgUserList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(ReturnReturns);
            panel1.Controls.Add(Titulo1);
            panel1.Controls.Add(Exit);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 144);
            panel1.TabIndex = 1;
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
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Exit.BackColor = Color.Red;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Location = new Point(2248, 12);
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
            label2.Location = new Point(672, 101);
            label2.Name = "label2";
            label2.Size = new Size(201, 38);
            label2.TabIndex = 1;
            label2.Text = "Manage Users";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.Location = new Point(534, 17);
            label1.Name = "label1";
            label1.Size = new Size(469, 70);
            label1.TabIndex = 0;
            label1.Text = "Car Rental System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(49, 469);
            label3.Name = "label3";
            label3.Size = new Size(95, 38);
            label3.TabIndex = 11;
            label3.Text = "Name";
            // 
            // UserName
            // 
            UserName.Location = new Point(194, 469);
            UserName.Name = "UserName";
            UserName.Size = new Size(185, 35);
            UserName.TabIndex = 13;
            // 
            // UserId
            // 
            UserId.Location = new Point(194, 343);
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            UserId.Size = new Size(185, 35);
            UserId.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(49, 339);
            label4.Name = "label4";
            label4.Size = new Size(47, 38);
            label4.TabIndex = 10;
            label4.Text = "ID";
            // 
            // LblLogin
            // 
            LblLogin.AutoSize = true;
            LblLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblLogin.Location = new Point(940, 161);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(140, 38);
            LblLogin.TabIndex = 14;
            LblLogin.Text = "Users List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(49, 588);
            label5.Name = "label5";
            label5.Size = new Size(139, 38);
            label5.TabIndex = 15;
            label5.Text = "Password";
            // 
            // UserPassword
            // 
            UserPassword.Location = new Point(194, 591);
            UserPassword.Name = "UserPassword";
            UserPassword.Size = new Size(185, 35);
            UserPassword.TabIndex = 16;
            // 
            // UserAdd
            // 
            UserAdd.FlatStyle = FlatStyle.Flat;
            UserAdd.Location = new Point(49, 814);
            UserAdd.Name = "UserAdd";
            UserAdd.Size = new Size(150, 42);
            UserAdd.TabIndex = 17;
            UserAdd.Text = "Add";
            UserAdd.UseVisualStyleBackColor = true;
            UserAdd.Click += UserAdd_Click;
            // 
            // EditUser
            // 
            EditUser.FlatStyle = FlatStyle.Flat;
            EditUser.Location = new Point(229, 814);
            EditUser.Name = "EditUser";
            EditUser.Size = new Size(150, 42);
            EditUser.TabIndex = 18;
            EditUser.Text = "Edit";
            EditUser.UseVisualStyleBackColor = true;
            EditUser.Click += EditUser_Click;
            // 
            // DeleteUser
            // 
            DeleteUser.FlatStyle = FlatStyle.Flat;
            DeleteUser.Location = new Point(49, 870);
            DeleteUser.Name = "DeleteUser";
            DeleteUser.Size = new Size(150, 42);
            DeleteUser.TabIndex = 19;
            DeleteUser.Text = "Delete";
            DeleteUser.UseVisualStyleBackColor = true;
            DeleteUser.Click += DeleteUser_Click_1;
            // 
            // BackUser
            // 
            BackUser.FlatStyle = FlatStyle.Flat;
            BackUser.Location = new Point(229, 870);
            BackUser.Name = "BackUser";
            BackUser.Size = new Size(150, 42);
            BackUser.TabIndex = 20;
            BackUser.Text = "Back";
            BackUser.UseVisualStyleBackColor = true;
            BackUser.Click += BackUser_Click_1;
            // 
            // DtgUserList
            // 
            DtgUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgUserList.Location = new Point(481, 212);
            DtgUserList.Name = "DtgUserList";
            DtgUserList.RowHeadersWidth = 72;
            DtgUserList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtgUserList.Size = new Size(977, 700);
            DtgUserList.TabIndex = 21;
            DtgUserList.SelectionChanged += DtgUserList_SelectionChanged;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlDark;
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 980);
            panel5.Name = "panel5";
            panel5.Size = new Size(1500, 20);
            panel5.TabIndex = 22;
            // 
            // ReturnReturns
            // 
            ReturnReturns.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ReturnReturns.BackColor = Color.OliveDrab;
            ReturnReturns.FlatStyle = FlatStyle.Flat;
            ReturnReturns.Location = new Point(1434, 12);
            ReturnReturns.Name = "ReturnReturns";
            ReturnReturns.Size = new Size(54, 40);
            ReturnReturns.TabIndex = 176;
            ReturnReturns.Text = "<-";
            ReturnReturns.UseVisualStyleBackColor = false;
            ReturnReturns.Click += ReturnReturns_Click;
            // 
            // UsersLoad
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 1000);
            Controls.Add(panel5);
            Controls.Add(DtgUserList);
            Controls.Add(BackUser);
            Controls.Add(DeleteUser);
            Controls.Add(EditUser);
            Controls.Add(UserAdd);
            Controls.Add(UserPassword);
            Controls.Add(label5);
            Controls.Add(LblLogin);
            Controls.Add(label3);
            Controls.Add(UserName);
            Controls.Add(UserId);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersLoad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            Load += UsersLoad_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Titulo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtgUserList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button Exit;
        private Label label2;
        private Label label1;
        private Label label3;
        private MaskedTextBox UserName;
        private MaskedTextBox UserId;
        private Label label4;
        private PictureBox Titulo1;
        private Label LblLogin;
        private Label label5;
        private MaskedTextBox UserPassword;
        private Button UserAdd;
        private Button EditUser;
        private Button DeleteUser;
        private Button BackUser;
        private DataGridView DtgUserList;
        private Panel panel5;
        private Button ReturnReturns;
    }
}