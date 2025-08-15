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
    public partial class rental : Form
    {
        public rental()
        {
            InitializeComponent();
        }

        private void BtnExitRental_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RentalBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void PreencherComboModelos()
        {
            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    // Usamos DISTINCT para não repetir os modelos na lista
                    string query = "SELECT DISTINCT Model FROM TB_Cars WHERE Avaliable = 'Yes'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    var dt = new DataTable();
                    da.Fill(dt);

                    CboCarModel.DisplayMember = "Model"; // Mostra o modelo
                    CboCarModel.ValueMember = "Model";   // Usa o modelo como valor
                    CboCarModel.DataSource = dt;

                    CboCarModel.SelectedIndex = -1;
                    CboCarModel.Text = "Selecione um Modelo...";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os modelos de carros: " + ex.Message);
                }
            }
        }

        private void rental_Load(object sender, EventArgs e)
        {
            CboFilterList.Items.Add("Cars on rent");
            CboFilterList.Items.Add("Rental history");
            CboFilterList.SelectedIndex = 0;

            PreencherComboModelos();
            ListCarsOnRent();
            this.CboCarModel.SelectedIndexChanged += new System.EventHandler(this.CboCarModel_SelectedIndexChanged_1);
        }

        private void RentalAdd_Click(object sender, EventArgs e)
        {
            // Validação agora usa os IDs dos ComboBoxes e o ID do Cliente.
            if (CboCarReg.SelectedValue == null || string.IsNullOrWhiteSpace(TxtCustID.Text) || string.IsNullOrWhiteSpace(TxtRentalFee.Text))
            {
                MessageBox.Show("Por favor, selecione um carro, encontre um cliente e defina a taxa.");
                return;
            }

            int carroIdSelecionado = Convert.ToInt32(CboCarReg.SelectedValue);

            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                SqlTransaction transaction = null;
                try
                {
                    con.Open();
                    transaction = con.BeginTransaction();

                    // CORRIGIDO: Query usa CarId_FK.
                    string queryInsertRent = "INSERT INTO TB_Rent (CarId_FK, CustId_FK, RentDate, RentFee, ExpectedReturnDate) VALUES (@CarId, @CustId, @RentDate, @Fee, @ExpectedReturn)";
                    using (SqlCommand insertCmd = new SqlCommand(queryInsertRent, con, transaction))
                    {
                        // CORRIGIDO: Passamos o CarId (INT) e não mais a placa.
                        insertCmd.Parameters.AddWithValue("@CarId", carroIdSelecionado);
                        insertCmd.Parameters.AddWithValue("@CustId", Convert.ToInt32(TxtCustID.Text));
                        insertCmd.Parameters.AddWithValue("@RentDate", TimeRetalDate.Value);
                        insertCmd.Parameters.AddWithValue("@Fee", Convert.ToDecimal(TxtRentalFee.Text));
                        insertCmd.Parameters.AddWithValue("@ExpectedReturn", TimeReturnDate.Value);
                        insertCmd.ExecuteNonQuery();
                    }

                    // CORRIGIDO: O UPDATE agora é feito pelo CarId, que é a PK.
                    string queryUpdateCar = "UPDATE TB_Cars SET Avaliable = 'No' WHERE CarId = @CarId";
                    using (SqlCommand updateCmd = new SqlCommand(queryUpdateCar, con, transaction))
                    {
                        updateCmd.Parameters.AddWithValue("@CarId", carroIdSelecionado);
                        updateCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Aluguel registrado com sucesso!");

                    ListCarsOnRent();
                    PreencherComboModelos();
                    CboCarReg.DataSource = null; // Limpa a combo de placas
                }
                catch (Exception ex)
                {
                    transaction?.Rollback();
                    MessageBox.Show("Ocorreu um erro na operação: " + ex.Message);
                }
            }
        }

        private void ListRentalHistory()
        {
            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    // Query que busca TODOS os aluguéis, sem filtro de devolução
                    string query = @"
                SELECT R.RentId, R.CarId_FK, C.RegNum, C.Model, R.CustId_FK, CS.CustName, CS.CustAddress, R.RentDate, R.ExpectedReturnDate, R.RentFee 
                FROM TB_Rent AS R
                JOIN TB_Cars AS C ON R.CarId_FK = C.CarId
                JOIN TB_Customers AS CS ON R.CustId_FK = CS.CustId";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    var dt = new DataTable();
                    da.Fill(dt);
                    DtgRentList.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao listar o histórico de aluguéis: " + ex.Message);
                }
            }
        }

        private void CboCarModel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CboCarModel.SelectedValue == null) return;

            string modeloSelecionado = CboCarModel.SelectedValue.ToString();
            CboCarReg.DataSource = null;

            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    // CORRIGIDO: Buscamos o CarId e o RegNum.
                    string query = "SELECT CarId, RegNum FROM TB_Cars WHERE Model = @Model AND Avaliable = 'Yes'";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.Parameters.AddWithValue("@Model", modeloSelecionado);
                    var dt = new DataTable();
                    da.Fill(dt);

                    // CORRIGIDO: O usuário VÊ a placa (RegNum), mas o VALOR interno é o CarId.
                    CboCarReg.DisplayMember = "RegNum";
                    CboCarReg.ValueMember = "CarId";
                    CboCarReg.DataSource = dt;

                    CboCarReg.SelectedIndex = -1;
                    CboCarReg.Text = "Selecione uma Placa...";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar as placas para este modelo: " + ex.Message);
                }
            }
        }

        private void DtgRentList_SelectionChanged(object sender, EventArgs e)
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
                TxtRentalNameCustomer.Text = linhaSelecionada.Cells["CustName"].Value.ToString();
                TxtRentalAddress.Text = linhaSelecionada.Cells["CustAddress"].Value.ToString();
                TxtRentalFee.Text = linhaSelecionada.Cells["RentFee"].Value.ToString();
            }

        }

        private void RentalDelete_Click(object sender, EventArgs e)
        {
            if (TxtRentId.Text == null)
            {
                MessageBox.Show("Por favor, selecione um aluguel da lista para deletar.");
                return;
            }

            // 2. Confirmação do Usuário: É uma boa prática confirmar ações destrutivas.
            var confirmResult = MessageBox.Show("Você tem certeza que quer deletar este registro de aluguel?",
                                             "Confirmar Deleção",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.No)
            {
                return; // O usuário cancelou a operação.
            }

            else
            {
                using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
                {
                    SqlTransaction transaction = null;
                    try
                    {
                        con.Open();
                        transaction = con.BeginTransaction();

                        // ETAPA 1: Apagar o registro da TB_Rent
                        string queryDeleteRent = "DELETE FROM TB_Rent WHERE RentId = @RentId";
                        using (SqlCommand deleteCmd = new SqlCommand(queryDeleteRent, con, transaction))
                        {
                            deleteCmd.Parameters.AddWithValue("@RentId", Convert.ToInt32(TxtRentId.Text));
                            deleteCmd.ExecuteNonQuery();
                        }

                        // ETAPA 2: Devolver o carro ao estoque (torná-lo disponível)
                        string queryUpdateCar = "UPDATE TB_Cars SET Avaliable = 'Yes' WHERE CarId = @CarId";
                        using (SqlCommand updateCmd = new SqlCommand(queryUpdateCar, con, transaction))
                        {
                            updateCmd.Parameters.AddWithValue("@CarId", Convert.ToInt32(TxtCarID.Text));
                            updateCmd.ExecuteNonQuery();
                        }

                        // Se ambas as operações funcionaram, confirma a transação.
                        transaction.Commit();
                        MessageBox.Show("Aluguel removido com sucesso!");

                        // Atualiza as listas e limpa a tela
                        ListCarsOnRent();
                        PreencherComboModelos();
                    }
                    catch (Exception ex)
                    {
                        // Se qualquer erro ocorrer, desfaz tudo.
                        transaction?.Rollback();
                        MessageBox.Show("Ocorreu um erro ao deletar o aluguel: " + ex.Message);
                    }
                }
            }
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCPFPesquisa.Text))
            {
                MessageBox.Show("Por favor, digite um CPF para pesquisar.", "Atenção");
                return;
            }

            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    // ===== CORREÇÃO: ABRIMOS A CONEXÃO AQUI =====
                    con.Open();

                    string sSQL = "SELECT * FROM [dbo].[TB_Customers] WHERE CPF_CNPJ = @pCPF";
                    SqlCommand cmd = new SqlCommand(sSQL, con);

                    // É uma boa prática usar .Trim() para remover espaços em branco acidentais
                    cmd.Parameters.AddWithValue("@pCPF", TxtCPFPesquisa.Text.Trim());

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        TxtRentalNameCustomer.Text = dt.Rows[0]["CustName"].ToString();
                        TxtRentalAddress.Text = dt.Rows[0]["CustAddress"].ToString();
                        TxtCustID.Text = dt.Rows[0]["CustId"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cliente não localizado para este CPF!", "Rent Car");
                        TxtRentalNameCustomer.Text = "";
                        TxtRentalAddress.Text = "";
                        TxtCustID.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro na pesquisa: " + ex.Message);
                }
                // A conexão é fechada automaticamente aqui pelo 'using'
            }
        }

        private void ListCarsOnRent()
        {
            using (SqlConnection con = new SqlConnection("Data Source=Note-Enrico;Database=DB_RENTAL_CAR;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                try
                {
                    // Query que busca apenas os aluguéis que NÃO estão na tabela de devolução
                    string query = @"
                SELECT R.RentId, R.CarId_FK, C.RegNum, C.Model, R.CustId_FK, CS.CustName, CS.CustAddress, R.RentDate, R.ExpectedReturnDate, R.RentFee 
                FROM TB_Rent AS R
                JOIN TB_Cars AS C ON R.CarId_FK = C.CarId
                JOIN TB_Customers AS CS ON R.CustId_FK = CS.CustId
                LEFT JOIN TB_Return AS RT ON R.RentId = RT.RentId_FK
                WHERE RT.ReturnId IS NULL";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    var dt = new DataTable();
                    da.Fill(dt);
                    DtgRentList.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao listar os aluguéis ativos: " + ex.Message);
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            if (CboFilterList.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma opção de visualização.");
                return;
            }

            string filtroSelecionado = CboFilterList.SelectedItem.ToString();

            if (filtroSelecionado == "Carros Alugados Atualmente")
            {
                ListCarsOnRent();
            }
            else if (filtroSelecionado == "Histórico de Aluguéis")
            {
                ListRentalHistory();
            }
        }

        private void ReturnRentals_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
