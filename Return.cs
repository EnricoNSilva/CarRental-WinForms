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
    public partial class Return : Form
    {
        private int idAluguelSelecionado = 0;
        private int idCarroOriginal = 0;
        public Return()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Placa_Click(object sender, EventArgs e)
        {

        }

        private void RentalBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void DtgRentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Garante que uma linha válida está selecionada para evitar erros
            if (DtgRentList.CurrentRow != null && DtgRentList.CurrentRow.Index >= 0)
            {
                // Pega a referência para a linha que o usuário clicou
                DataGridViewRow linhaSelecionada = DtgRentList.CurrentRow;

                // Preenche os campos de texto com os dados da linha selecionada
                TxtCustID.Text = linhaSelecionada.Cells["CustId_FK"].Value.ToString();
                TxtCarID.Text = linhaSelecionada.Cells["CarId_FK"].Value.ToString();
                TxtRentId.Text = linhaSelecionada.Cells["RentId"].Value.ToString();
                TxtExpectedReturn.Text = linhaSelecionada.Cells["ExpectedReturnDate"].Value.ToString();
                TxtRentalDate.Text = linhaSelecionada.Cells["RentDate"].Value.ToString();
                TxtReturnNameCustomer.Text = linhaSelecionada.Cells["CustName"].Value.ToString();
                TxtReturnFee.Text = linhaSelecionada.Cells["RentFee"].Value.ToString();
                TxtCarModelReturn.Text = linhaSelecionada.Cells["Model"].Value.ToString();
                TxtPlacaReturn.Text = linhaSelecionada.Cells["RegNum"].Value.ToString();
            }
        }

        private void ListRent()
        {
            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    string query = @"
                 SELECT 
                    CAR.RegNum,
                    CAR.Model,
                    CUST.CustName, 
                    R.RentDate, 
                    R.RentFee,
                    R.CarId_FK,
                    R.RentId,
                    R.CustId_FK, 
                    R.ExpectedReturnDate
                FROM 
                    [dbo].[TB_Rent] AS R
                JOIN 
                    [dbo].[TB_Customers] AS CUST ON R.CustId_FK = CUST.CustId
                JOIN 
                    TB_Cars AS CAR ON R.CarId_FK = CAR.CarId
                LEFT JOIN
                    TB_Return AS RT ON R.RentId = RT.RentId_FK
                WHERE
                    RT.ReturnId IS NULL";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    var dt = new DataTable();
                    da.Fill(dt);
                    DtgRentList.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }
        private void ListCarsReturned()
        {
            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    // Esta query busca o histórico de devoluções
                    string query = @"
                SELECT 
                    RT.ReturnId,
                    C.RegNum,
                    CS.CustName,
                    R.RentDate,
                    RT.ReturnDate,
                    RT.Delay,
                    RT.Fine
                FROM
                    TB_Return AS RT
                JOIN
                    TB_Rent AS R ON RT.RentId_FK = R.RentId
                JOIN
                    TB_Cars AS C ON R.CarId_FK = C.CarId
                JOIN
                    TB_Customers AS CS ON R.CustId_FK = CS.CustId";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    var dt = new DataTable();
                    da.Fill(dt);
                    // Assumindo que a grade de baixo se chama DtgCarsReturned
                    DtgReturnList.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao listar o histórico de devoluções: " + ex.Message);
                }
            }
        }

        private void Return_Load(object sender, EventArgs e)
        {
            ListRent();
            ListCarsReturned();
        }

        private void ReturnAdd_Click(object sender, EventArgs e)
        {
            // 1. Validação: Verifica se um aluguel foi selecionado na grade.
            if (TxtRentId.Text == null)
            {
                MessageBox.Show("Por favor, selecione um carro da lista 'Cars On Rent' para processar a devolução.");
                return;
            }

            // --- ETAPA 2: Coleta de Dados e Cálculos ---
            DateTime dataDevolucaoPrevista;
            DateTime dataDevolucaoReal = TimeReturnDate.Value; // Data que o usuário selecionou na tela
            decimal precoDiaria = 0;

            // Validação da data
            if (!DateTime.TryParse(TxtExpectedReturn.Text, out dataDevolucaoPrevista))
            {
                MessageBox.Show("A data de devolução prevista não pôde ser lida. Verifique o registro.");
                return;
            }

            // --- ETAPA 3: Iniciar a conexão e buscar o preço da diária para calcular a multa ---
            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                SqlTransaction transaction = null;
                try
                {
                    con.Open();

                    // Busca o preço da diária do carro original
                    string queryBuscaPreco = "SELECT RentFee FROM TB_Rent WHERE RentId = @RentId";
                    using (SqlCommand precoCmd = new SqlCommand(queryBuscaPreco, con))
                    {
                        precoCmd.Parameters.AddWithValue("@RentId", TxtRentId.Text);
                        var result = precoCmd.ExecuteScalar();
                        if (result != null)
                        {
                            precoDiaria = Convert.ToDecimal(result);
                        }
                    }

                    // Cálculo do Atraso e da Multa
                    TimeSpan diferenca = dataDevolucaoReal.Date - dataDevolucaoPrevista.Date;
                    int diasDeAtraso = Math.Max(0, diferenca.Days); // Garante que o atraso nunca seja negativo
                    decimal multa = diasDeAtraso * precoDiaria;

                    // Exibe os valores calculados nos campos da tela
                    TxtDelayReturn.Text = diasDeAtraso.ToString();
                    TxtFineReturn.Text = multa.ToString("F2"); // "F2" formata para 2 casas decimais

                    // Confirmação final com o usuário
                    var confirmResult = MessageBox.Show($"Atraso: {diasDeAtraso} dias\nMulta: R$ {multa:F2}\n\nConfirmar devolução?",
                                                        "Confirmar Devolução", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (confirmResult == DialogResult.No)
                    {
                        return;
                    }

                    // --- ETAPA 4: Executar as Operações no Banco de Dados (dentro de uma transação) ---
                    transaction = con.BeginTransaction();

                    // 4a. Insere o registro na tabela de devoluções
                    string queryInsertReturn = "INSERT INTO TB_Return (RentId_FK, ReturnDate, Delay, Fine) VALUES (@RentId, @ReturnDate, @Delay, @Fine)";
                    using (SqlCommand insertCmd = new SqlCommand(queryInsertReturn, con, transaction))
                    {
                        insertCmd.Parameters.AddWithValue("@RentId", TxtRentId.Text);
                        insertCmd.Parameters.AddWithValue("@ReturnDate", dataDevolucaoReal);
                        insertCmd.Parameters.AddWithValue("@Delay", diasDeAtraso);
                        insertCmd.Parameters.AddWithValue("@Fine", multa);
                        insertCmd.ExecuteNonQuery();
                    }

                    // 4b. Atualiza o status do carro para 'Disponível'
                    string queryUpdateCar = "UPDATE TB_Cars SET Avaliable = 'Yes' WHERE CarId = @CarId";
                    using (SqlCommand updateCmd = new SqlCommand(queryUpdateCar, con, transaction))
                    {
                        updateCmd.Parameters.AddWithValue("@CarId", TxtCarID.Text);
                        updateCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Devolução registrada com sucesso!");

                    ListRent();
                    ListCarsReturned();
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    MessageBox.Show("Ocorreu um erro ao registrar a devolução: " + ex.Message);
                }
            }
        }

        private void DtgReturnList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //    // Garante que uma linha válida está selecionada para evitar erros
            //    if (DtgRentList.CurrentRow != null && DtgRentList.CurrentRow.Index >= 0)
            //    {
            //        // Pega a referência para a linha que o usuário clicou
            //        DataGridViewRow linhaSelecionada = DtgRentList.CurrentRow;

            //        // Preenche os campos de texto com os dados da linha selecionada   TimeRetalDate.Value = Convert.ToDateTime(linhaSelecionada.Cells["RentDate"].Value);

            //        TxtRentId.Text = linhaSelecionada.Cells["RentId"].Value.ToString();
            //        TxtRentalDate.Text = linhaSelecionada.Cells["RentDate"].Value.ToString();
            //        TimeReturnDate.Value =Convert.ToDateTime(linhaSelecionada.Cells["ReturnDate"].Value);
            //        TxtReturnNameCustomer.Text = linhaSelecionada.Cells["CustName"].Value.ToString();
            //        TxtReturnFee.Text = linhaSelecionada.Cells["RentFee"].Value.ToString();
            //        TxtCarModelReturn.Text = linhaSelecionada.Cells["Model"].Value.ToString();
            //        TxtPlacaReturn.Text = linhaSelecionada.Cells["RegNum"].Value.ToString();
            //        TxtDelayReturn.Text = linhaSelecionada.Cells["Delay"].Value.ToString();
            //        TxtFineReturn.Text = linhaSelecionada.Cells["Fine"].Value.ToString();
            //    }
        }

        private void ExitReturns_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReturnReturns_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
