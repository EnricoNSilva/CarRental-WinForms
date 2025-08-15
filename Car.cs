using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarRental
{
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
            ListarCarros();
        }
        private void ListarCarros()
        {
            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    string query = "Select * FROM [dbo].[TB_Cars]";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    var dt = new DataTable();
                    da.Fill(dt);
                    DtgCarList.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }
        private void ExitCar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DtgCarList_SelectionChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    con.Open();
                    if (DtgCarList.CurrentRow != null)
                    {
                        // Pega a linha atualmente selecionada.
                        DataGridViewRow linhaSelecionada = DtgCarList.CurrentRow;
                        TxtCarId.Text = linhaSelecionada.Cells["CarId"].Value.ToString();
                        TxtBrand.Text = linhaSelecionada.Cells["Brand"].Value.ToString();
                        CboAvaliableCar.Text = linhaSelecionada.Cells["Avaliable"].Value.ToString();
                        TxtModel.Text = linhaSelecionada.Cells["Model"].Value.ToString();
                        TxtRegNo.Text = linhaSelecionada.Cells["RegNum"].Value.ToString();
                        TxtPrice.Text = linhaSelecionada.Cells["Price"].Value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void RegCar_Click(object sender, EventArgs e)
        {

        }

        private void DeleteCar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCarId.Text)) // A única informação necessária é o ID
            {
                MessageBox.Show("Por favor, selecione um carro da lista.");
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    con.Open();
                    // CORRIGIDO: Usa CarId e parâmetros
                    string query = "DELETE FROM [dbo].[TB_Cars] WHERE CarId = @cId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@cId", Convert.ToInt32(TxtCarId.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Carro removido com sucesso!");
                        ListarCarros();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            // 1. Validação usando os TEXTBOXES corretos (TxtRegNo, TxtBrand, etc.)
            if (string.IsNullOrWhiteSpace(TxtRegNo.Text) || string.IsNullOrWhiteSpace(TxtBrand.Text) ||
                string.IsNullOrWhiteSpace(TxtModel.Text) || string.IsNullOrWhiteSpace(TxtPrice.Text))
            {
                MessageBox.Show("Todas as informações são obrigatórias.");
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO [dbo].[TB_Cars] (RegNum, Brand, Model, Avaliable, Price) VALUES (@cReg, @cBrand, @cModel, @cAvaliable, @cPrice)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // 2. Passando os valores dos TEXTBOXES e COMBOBOX corretos.
                        cmd.Parameters.AddWithValue("@cReg", TxtRegNo.Text);
                        cmd.Parameters.AddWithValue("@cBrand", TxtBrand.Text);
                        cmd.Parameters.AddWithValue("@cModel", TxtModel.Text);
                        if (CboAvaliableCar.SelectedItem == null)
                        {
                            MessageBox.Show("Por favor, selecione a disponibilidade do carro (Yes/No).");
                            return; // Impede que o resto do código execute se nada for selecionado.
                        }
                        else
                        {
                            // 2. Se a verificação passou, AGORA é seguro usar o SelectedItem, pois sabemos que ele não é nulo.
                            string disponibilidade = CboAvaliableCar.SelectedItem.ToString();
                            cmd.Parameters.AddWithValue("@cAvaliable", disponibilidade);
                            // 3. CONVERTER o texto do preço para um número antes de enviar.
                            cmd.Parameters.AddWithValue("@cPrice", Convert.ToDecimal(TxtPrice.Text));

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Carro adicionado com sucesso!");

                            ListarCarros();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }

        private void EditCar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCarId.Text))
            {
                MessageBox.Show("Todas as informações são obrigatórias.");
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    con.Open();
                    // CORRIGIDO: A cláusula WHERE agora usa o CarId, que é imutável.
                    string query = "UPDATE [dbo].[TB_Cars] SET RegNum = @cReg, Brand = @cBrand, Model = @cModel, Avaliable = @cAvaliable, Price = @cPrice WHERE CarId = @cId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@cId", Convert.ToInt32(TxtCarId.Text));
                        cmd.Parameters.AddWithValue("@cReg", TxtRegNo.Text);
                        cmd.Parameters.AddWithValue("@cBrand", TxtBrand.Text);
                        cmd.Parameters.AddWithValue("@cModel", TxtModel.Text);
                        cmd.Parameters.AddWithValue("@cAvaliable", CboAvaliableCar.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@cPrice", Convert.ToDecimal(TxtPrice.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Carro alterado com sucesso!");
                        ListarCarros();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }

        private void BackCar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void ExitCars_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
