using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Titulo1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // 1. Validação básica dos campos
            if (string.IsNullOrWhiteSpace(TxtUserID.Text) || string.IsNullOrWhiteSpace(TxtPassword.Text))
            {
                MessageBox.Show("Por favor, insira o nome de usuário e a senha.", "Informação Faltando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    con.Open();

                    // Usamos COUNT(*) para contar quantos registros correspondem.
                    string query = "SELECT COUNT(*) FROM TB_Users WHERE UserName = @uName AND UserPass = @uPass";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@uName", TxtUserID.Text.Trim());
                        cmd.Parameters.AddWithValue("@uPass", TxtPassword.Text);

                        // 3. ExecuteScalar é usado para obter um único valor (a contagem).
                        int userCount = (int)cmd.ExecuteScalar();

                        // 4. Verifica se a contagem é 1 (encontrou exatamente um usuário).
                        if (userCount == 1)
                        {
                            // Usuário e senha corretos!
                            MessageBox.Show("Login bem-sucedido!");

                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Usuário ou senha incorretos
                            MessageBox.Show("Usuário ou senha incorretos. Tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao tentar fazer o login: " + ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ExitCar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
