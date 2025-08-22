using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnCarsMain_Click(object sender, EventArgs e)
        {
            Car CarForm = new Car();
            CarForm.Show();
            this.Hide();
        }

        private void BtnCustomerMain_Click(object sender, EventArgs e)
        {
            Customer CustomerForm = new Customer();
            CustomerForm.Show();
            this.Hide();
        }

        private void BtnRentalMain_Click(object sender, EventArgs e)
        {
            rental RentalForm = new rental();
            RentalForm.Show();
            this.Hide();
        }

        private void BtnReturnMain_Click(object sender, EventArgs e)
        {
            Return ReturnForm = new Return();
            ReturnForm.Show();
            this.Hide();
        }

        private void BtnUsersMain_Click(object sender, EventArgs e)
        {
            UsersLoad UserForm = new UsersLoad();
            UserForm.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard Dash = new Dashboard();
            Dash.Show();
            this.Hide();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            Export Export = new Export();
            Export.Show();
            this.Hide();
        }
    }
}
