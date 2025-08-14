using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRental
{
    public partial class UsersLoad : Form
    {
        public UsersLoad()
        {
            InitializeComponent();
        }

        private void ListarUsuarios()
        {
            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    string query = "Select * FROM [dbo].[TB_Users]";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    var dt = new DataTable();
                    da.Fill(dt);
                    DtgUserList.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }

        private void UserAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserName.Text) || string.IsNullOrWhiteSpace(UserPassword.Text))
            {
                MessageBox.Show("Missing information");
                return;
            }
            else
            {
                using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    try
                    {
                        con.Open();

                        // 1. A query agora usa parâmetros (@uName, @uPass) em vez de concatenar texto.
                        // 2. Especificamos as colunas que vamos inserir.
                        string query = "INSERT INTO [dbo].[TB_Users] (UserName, UserPass) VALUES (@uName, @uPass)";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            // 4. Passamos os valores para os parâmetros de forma segura.
                            cmd.Parameters.AddWithValue("@uName", UserName.Text);

                            cmd.Parameters.AddWithValue("@uPass", UserPassword.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuário adicionado com sucesso!");

                            // Limpa os campos para o próximo cadastro
                            UserName.Text = "";
                            UserPassword.Text = "";
                            ListarUsuarios();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }
                } // A conexão é fechada aqui automaticamente pelo 'using'
            }
        }

        private void UsersLoad_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void DtgUserList_SelectionChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    con.Open();
                    if (DtgUserList.CurrentRow != null)
                    {
                        // Pega a linha atualmente selecionada.
                        DataGridViewRow linhaSelecionada = DtgUserList.CurrentRow;

                        // Pega o valor da célula na coluna "id" e coloca no TextBox de ID.
                        UserName.Text = linhaSelecionada.Cells["UserName"].Value.ToString();

                        // Pega o valor da célula na coluna "ENDERECO" e coloca no TextBox de Código de Status.
                        UserId.Text = linhaSelecionada.Cells["IdUser"].Value.ToString();

                        // Pega o valor da célula na coluna "CPF" e coloca no TextBox de Descrição de Status.
                        UserPassword.Text = linhaSelecionada.Cells["UserPass"].Value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void DeleteUser_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserName.Text) || string.IsNullOrWhiteSpace(UserPassword.Text))
            {
                MessageBox.Show("Missing information");
                return;
            }
            else
            {
                using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    try
                    {
                        con.Open();

                        // 1. A query agora usa parâmetros (@uName, @uPass) em vez de concatenar texto.
                        // 2. Especificamos as colunas que vamos inserir.
                        string query = "DELETE FROM [dbo].[TB_Users] WHERE idUser=" + UserId.Text + ";";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuário removido com sucesso!");

                            // Limpa os campos para o próximo cadastro
                            UserName.Text = "";
                            UserPassword.Text = "";
                            ListarUsuarios();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }
                }
            }
        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserName.Text) || string.IsNullOrWhiteSpace(UserPassword.Text))
            {
                MessageBox.Show("Missing information");
                return;
            }
            else
            {
                using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    try
                    {
                        con.Open();

                        // 1. A query agora usa parâmetros (@uName, @uPass) em vez de concatenar texto.
                        // 2. Especificamos as colunas que vamos inserir.
                        string query = "UPDATE [dbo].[TB_Users] set UserName = @uName , UserPass = @uPass WHERE idUser = @uId";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            // 4. Passamos os valores para os parâmetros de forma segura.
                            cmd.Parameters.AddWithValue("@uName", UserName.Text);
                            cmd.Parameters.AddWithValue("@uID", UserId.Text);
                            cmd.Parameters.AddWithValue("@uPass", UserPassword.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuário alterado com sucesso!");

                            ListarUsuarios();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }
                } // A conexão é fechada aqui automaticamente pelo 'using'
            }
        }

        private void BackUser_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void ReturnReturns_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}