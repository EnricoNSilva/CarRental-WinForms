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
    public partial class Export : Form
    {
        public Export()
        {
            InitializeComponent();
        }

        private void ExitExports_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void ExportCustomers_Click(object sender, EventArgs e)
        {
            // --- ETAPA A: Obter os dados do banco ---
            DataTable dtCustomers = new DataTable();
            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    string query = "SELECT * FROM TB_Customers";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.Fill(dtCustomers);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar dados dos clientes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // --- ETAPA B: Permitir que o usuário escolha onde salvar ---
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Arquivo CSV (*.csv)|*.csv";
                saveFileDialog.Title = "Salvar Arquivo de Clientes";
                saveFileDialog.FileName = $"Clientes_{DateTime.Now:yyyyMMdd}.csv"; // Sugere um nome de arquivo

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // --- ETAPA C: Chamar nossa função "mágica" ---
                        CsvHelper.ExportDataTableToCsv(dtCustomers, saveFileDialog.FileName);
                        MessageBox.Show("Arquivo de clientes exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnExportRentals_Click(object sender, EventArgs e)
        {
            // --- ETAPA A: Obter os dados do banco ---
            DataTable dtRentals = new DataTable();
            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    string query = "SELECT * FROM TB_Rent";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.Fill(dtRentals);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar dados dos alugueis: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // --- ETAPA B: Permitir que o usuário escolha onde salvar ---
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Arquivo CSV (*.csv)|*.csv";
                saveFileDialog.Title = "Salvar Arquivo de Alugueis";
                saveFileDialog.FileName = $"Rentals_{DateTime.Now:yyyyMMdd}.csv"; // Sugere um nome de arquivo

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        CsvHelper.ExportDataTableToCsv(dtRentals, saveFileDialog.FileName);
                        MessageBox.Show("Arquivo de alugueis exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnExportReturns_Click(object sender, EventArgs e)
        {
            // --- ETAPA A: Obter os dados do banco ---
            DataTable dtReturns = new DataTable();
            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    string query = "SELECT * FROM TB_Return";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.Fill(dtReturns);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar dados dos retornos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // --- ETAPA B: Permitir que o usuário escolha onde salvar ---
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Arquivo CSV (*.csv)|*.csv";
                saveFileDialog.Title = "Salvar Arquivo de retornos";
                saveFileDialog.FileName = $"Returns_{DateTime.Now:yyyyMMdd}.csv"; // Sugere um nome de arquivo

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        CsvHelper.ExportDataTableToCsv(dtReturns, saveFileDialog.FileName);
                        MessageBox.Show("Arquivo de retornos exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnExportCars_Click_1(object sender, EventArgs e)
        {
            // --- ETAPA A: Obter os dados do banco ---
            DataTable dtCars = new DataTable();
            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    string query = "SELECT * FROM TB_Cars";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.Fill(dtCars);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar dados dos carros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // --- ETAPA B: Permitir que o usuário escolha onde salvar ---
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Arquivo CSV (*.csv)|*.csv";
                saveFileDialog.Title = "Salvar Arquivo de Carros";
                saveFileDialog.FileName = $"Carros_{DateTime.Now:yyyyMMdd}.csv"; // Sugere um nome de arquivo

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        CsvHelper.ExportDataTableToCsv(dtCars, saveFileDialog.FileName);
                        MessageBox.Show("Arquivo de carros exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
