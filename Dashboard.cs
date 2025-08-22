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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            // Chama as novas funções para as métricas detalhadas
            CarregarCarrosDisponiveis();
            CarregarFaturamentoTotal();
            CarregarAlugueisActive();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    string queryCar = "Select Count(*) FROM [TB_Cars]";
                    SqlDataAdapter da = new SqlDataAdapter(queryCar, con);
                    var dt = new DataTable();
                    da.Fill(dt);
                    CarLbl.Text = dt.Rows[0][0].ToString();

                    string queryUsers = "Select Count(*) FROM [TB_Users]";
                    SqlDataAdapter da1 = new SqlDataAdapter(queryUsers, con);
                    var dt1 = new DataTable();
                    da1.Fill(dt1);
                    UsersLbl.Text = dt1.Rows[0][0].ToString();

                    string queryCustumers = "Select Count(*) FROM [TB_Customers]";
                    SqlDataAdapter da2 = new SqlDataAdapter(queryCustumers, con);
                    var dt2 = new DataTable();
                    da2.Fill(dt2);
                    CustomersLbl.Text = dt2.Rows[0][0].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }
        private void CarregarCarrosDisponiveis()
        {
            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM TB_Cars WHERE Avaliable = 'Yes'";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        int carrosDisponiveis = (int)cmd.ExecuteScalar();

                        // Assumindo que você tem um Label chamado LblCarrosDisponiveis
                        LblCarrosDisponiveis.Text = carrosDisponiveis.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar carros disponíveis: " + ex.Message);
                }
            }
        }
        private void CarLbl_Click(object sender, EventArgs e)
        {

        }

        private void ExitDashboards_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void CustomersLbl_Click(object sender, EventArgs e)
        {

        }

        private void CarregarFaturamentoTotal()
        {
            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    con.Open();
                    string query = "SELECT SUM(RentFee) FROM TB_Rent";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // ExecuteScalar pode retornar null se a tabela estiver vazia
                        var resultado = cmd.ExecuteScalar();
                        decimal faturamento = (resultado == DBNull.Value) ? 0 : Convert.ToDecimal(resultado);

                        // Assumindo um Label LblFaturamentoTotal
                        // "C2" formata o valor como moeda (ex: R$ 1.234,56)
                        LblFaturamentoTotal.Text = faturamento.ToString("C2");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar faturamento total: " + ex.Message);
                }
            }
        }

        private void CarregarAlugueisActive()
        {
            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    con.Open();
                    // Conta os aluguéis que não têm um ID correspondente na tabela de devoluções
                    string query = "SELECT COUNT(*) FROM TB_Rent WHERE RentId NOT IN (SELECT RentId_FK FROM TB_Return)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        int alugueisAtivos = (int)cmd.ExecuteScalar();

                        // Assumindo um Label LblAlugueisAtivos
                        LblAlugueisAtivos.Text = alugueisAtivos.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar aluguéis ativos: " + ex.Message);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
