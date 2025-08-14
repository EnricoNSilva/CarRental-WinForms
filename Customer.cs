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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarRental
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            ListarCustomer();
        }

        private void CustomerAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNameCustomer.Text)
                || string.IsNullOrWhiteSpace(TxtAdressCustomer.Text) || string.IsNullOrWhiteSpace(TxtPhoneCustomer.Text))
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
                        string query = "INSERT INTO [dbo].[TB_Customers] (CustName,CPF_CNPJ, CustAddress, CustPhone) VALUES (@cName,@cCPF, @cAdd, @cPhone)";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            // 4. Passamos os valores para os parâmetros de forma segura.
                            cmd.Parameters.AddWithValue("@cName", TxtNameCustomer.Text);
                            cmd.Parameters.AddWithValue("@cAdd", TxtAdressCustomer.Text);
                            cmd.Parameters.AddWithValue("@cCPF", TxtCpfCust.Text);
                            cmd.Parameters.AddWithValue("@cPhone", TxtPhoneCustomer.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuário adicionado com sucesso!");

                            ListarCustomer();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }
                } // A conexão é fechada aqui automaticamente pelo 'using'
            }
        }

        private void ListarCustomer()
        {
            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    string query = "Select * FROM [dbo].[TB_Customers]";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    var dt = new DataTable();
                    da.Fill(dt);
                    DtgCustomerList.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }

        private void DtgCustomerList_SelecctionChanged(object sender, EventArgs e)
        {
            if (DtgCustomerList.CurrentRow != null && DtgCustomerList.CurrentRow.Index >= 0)
            {
                // Pega a linha atualmente selecionada.
                DataGridViewRow linhaSelecionada = DtgCustomerList.CurrentRow;

                TxtIdCustomer.Text = linhaSelecionada.Cells["CustId"].Value.ToString();
                TxtNameCustomer.Text = linhaSelecionada.Cells["CustName"].Value.ToString();
                TxtCpfCust.Text = linhaSelecionada.Cells["CPF_CNPJ"].Value.ToString();
                TxtPhoneCustomer.Text = linhaSelecionada.Cells["CustPhone"].Value.ToString();
                TxtAdressCustomer.Text = linhaSelecionada.Cells["CustAddress"].Value.ToString();
            }
        }

        private void CustomerDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtIdCustomer.Text))
            {
                MessageBox.Show("Por favor, selecione um cliente da lista.");
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    con.Open();
                    // CORRIGIDO: Query parametrizada para evitar SQL Injection.
                    string query = "DELETE FROM [dbo].[TB_Customers] WHERE CustId = @cId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@cId", Convert.ToInt32(TxtIdCustomer.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente removido com sucesso!");
                        ListarCustomer();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }

        private void CustomerEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNameCustomer.Text)
                || string.IsNullOrWhiteSpace(TxtAdressCustomer.Text) || string.IsNullOrWhiteSpace(TxtPhoneCustomer.Text))
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
                        string query = "UPDATE [dbo].[TB_Customers] SET CustName = @cName, CustAddress = @cAdd, CustPhone = @cPhone, CPF_CNPJ = @cCPF WHERE CustId = @cId";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            // 4. Passamos os valores para os parâmetros de forma segura.
                            cmd.Parameters.AddWithValue("@cId", TxtIdCustomer.Text);
                            cmd.Parameters.AddWithValue("@cName", TxtNameCustomer.Text);
                            cmd.Parameters.AddWithValue("@cAdd", TxtAdressCustomer.Text);
                            cmd.Parameters.AddWithValue("@cPhone", TxtPhoneCustomer.Text);
                            cmd.Parameters.AddWithValue("@cCPF", TxtCpfCust.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuário editado com sucesso!");

                            ListarCustomer();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message);
                    }
                } // A conexão é fechada aqui automaticamente pelo 'using'
            }
        }
        private void ExitCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
