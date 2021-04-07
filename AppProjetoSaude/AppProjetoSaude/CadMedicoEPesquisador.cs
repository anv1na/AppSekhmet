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
using System.Data.SqlTypes;

namespace AppProjetoSaude
{
    public partial class CadMedicoEPesquisador : Form
    {
        public CadMedicoEPesquisador()
        {
            InitializeComponent();
            AtualizarGrid();
            GerarCodigoMedico();            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           try
            {

                Medico med = new Medico();

                // Abre conexão com o banco de dados

                SqlConnection con = new SqlConnection(Banco.StringConexao);

                // Abre a conexão com o Banco
                con.Open();

                string sql = "Insert into medico(nome, endereco, numero, bairro, cidade, cep, estado, cpf, status)" +
                "values(@nomeM, @celularM, @enderecoM, @numeroM, @bairroM, @cidadeM, @cep, @estadoM, @statusM)";


                SqlCommand cmd = new SqlCommand(sql, con);

                // Direcionando os valores provenientes da tela 

                cmd.Parameters.Add("@nomeM", SqlDbType.VarChar).Value = txtnome.Text;
                cmd.Parameters.Add("@celularM", SqlDbType.VarChar).Value = mskcelular.Text;
                cmd.Parameters.Add("@enderecoM", SqlDbType.VarChar).Value = txtendereco.Text;
                cmd.Parameters.Add("@numeroM", SqlDbType.VarChar).Value = txtnumero.Text;
                cmd.Parameters.Add("@bairroM", SqlDbType.VarChar).Value = txtbairro.Text;
                cmd.Parameters.Add("@cidadeM", SqlDbType.VarChar).Value = txtcidade.Text;
                cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = mskcep.Text;
                cmd.Parameters.Add("@estadoM", SqlDbType.VarChar).Value = cbestado.Text;


                if (chkstatus.Checked == true)
                {
                    med.statusM = "I";
                }

                else
                {
                    med.statusM = "A";
                }

                cmd.Parameters.Add("@statusM", SqlDbType.VarChar).Value = med.statusM;

                // Se tudo estiver correto , ele executará o comando insert
                cmd.ExecuteNonQuery();
                MessageBox.Show("Médico/Pesquisador cadastrado com sucesso");

                // Fecha a conexão com o Banco de dados
                con.Close();

                AtualizarGrid(); // Quando clicar no botão salvar irá atualizar o datagrid

                Limpar(); // Limpa os Dados 
                GerarCodigoUsuario();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao inserir cliente" + erro.Message);
            }
        }

        public static DataTable ListarMedico()
        {
            try
            {

                SqlConnection con = new SqlConnection(Banco.StringConexao);
                con.Open();

                // Instrução Sql para realizar uma consulta no Banco de Dados - Seleciona os dados 

                string sql = "Select * from medico"; // Recupera todas as informações da tabela de medicos

                // SqlDataAdapter funciona com o sqlcommand mas com os dados da tabela 
                // SqlDataAdapter fornece uma ponte entre a aplicação  e o Banco de Dados 
                // Permitir a leitura e escrita dos dados

                SqlDataAdapter da = new SqlDataAdapter(sql, con);

                // Instanciar a classe DataTable para carregar os dados do banco em tabela.

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt; // Retornara os dados prontos 

                con.Close();



            }
            catch (Exception)
            {
                return null;
            }
        }
        // Este método carregara o dataGridView com os dados do medico

        public void AtualizarGrid()
        {

            // O comando datasource faz com que os dados vindos do ListarCliente, carregue o 
            // DataGridView do cliente

            dgmedico.DataSource = ListarMedico();

            // Montando o DataGridView com o cabeçalho e largura das colunas 

            dgmedico.Columns[0].HeaderText = "Código";
            dgmedico.Columns[1].HeaderText = "Nome";
            dgmedico.Columns[2].HeaderText = "Celular";
            dgmedico.Columns[3].HeaderText = "Rua";
            dgmedico.Columns[4].HeaderText = "Nº";
            dgmedico.Columns[5].HeaderText = "Bairro";
            dgmedico.Columns[6].HeaderText = "Cidade";
            dgmedico.Columns[7].HeaderText = "CEP";
            dgmedico.Columns[8].HeaderText = "UF";
            dgmedico.Columns[9].HeaderText = "Status";

            // Largura das colunas

            dgmedico.Columns[0].Width = 35; 
            dgmedico.Columns[1].Width = 75;
            dgmedico.Columns[2].Width = 75;
            dgmedico.Columns[3].Width = 75;
            dgmedico.Columns[4].Width = 75;
            dgmedico.Columns[5].Width = 75;
            dgmedico.Columns[6].Width = 75;
            dgmedico.Columns[7].Width = 75;
            dgmedico.Columns[8].Width = 35;
            dgmedico.Columns[9].Width = 35;

            // Permite que consiga selecionar a linha do DataGrid

            dgmedico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Permissões para usuários

            dgmedico.AllowUserToAddRows = false; // o usuário não pode add linhas
            dgmedico.AllowUserToDeleteRows = false; // o usuário não pode deletar linhas
            dgmedico.ReadOnly = true; // Deixará o datagrid somente para leitura

        }

        public void Limpar()
        {

            mskcep.Clear();
            txtbairro.Clear();
            mskcelular.Clear();
            txtcidade.Clear();
            txtcodigo.Clear();
            txtendereco.Clear();
            txtnome.Clear();
            txtnumero.Clear();
            txtpesquisar.Clear();
            cbestado.SelectedIndex = -1;

            if (chkstatus.Checked == true)
            {

                chkstatus.Checked = false;

            }

            txtnome.Focus();

        }

        public static Medico SelecionarMedico(int codigo)
        {

            try
            {

                SqlConnection con = new SqlConnection(Banco.StringConexao);
                con.Open();

                string sql = "Select * from medico Where codigoM=@codigoM";

                SqlCommand cmd = new SqlCommand(sql, con);

                // Vai usar o codigo do paciente para fazer o filtro na busca do registro selecionado

                cmd.Parameters.Add("@codigoM", SqlDbType.Int).Value = codigo; // Codigo determinado no parametro.

                // Vai retornar os dados percorrendo a tabela

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    // Atenção a sequência do BD

                    Medico med = new Medico();

                    med.codigoM = Convert.ToInt32(dr[0]);
                    med.nomeM = dr[1].ToString();
                    med.celularM = dr[2].ToString();
                    med.enderecoM = dr[3].ToString();
                    med.numeroM = Convert.ToInt32(dr[4]);
                    med.bairroM = dr[5].ToString();
                    med.cidadeM = dr[6].ToString();
                    med.cepM = dr[7].ToString();
                    med.estadoM = dr[8].ToString();
                    med.statusM = dr[9].ToString();

                    con.Close();
                    return med;
                }

                else
                {

                    con.Close();
                    return null;

                }

            }

            catch (Exception erro)
            {

                MessageBox.Show("Erro ao selecionar o paciente. " + erro.Message);
                return null;

            }

        }
        

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastroMedico_Load(object sender, EventArgs e)
        {

        }

        private void mskcep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEspecialidadeM_Click(object sender, EventArgs e)
        {
            Especialidades especialidade = new Especialidades();
            especialidade.ShowDialog();
        }

        private void dgmedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vai pegar os dados da classe e jogar nos TextBox

            // Vai verificar se há linha selecionada no datagrid

            try
            {
                int linha = dgmedico.SelectedRows[0].Index;

                if (linha >= 0)
                {

                    // Vai pegar o codigo do paciente da linha que foi selecionada
                    int codigo = Convert.ToInt32(dgmedico.Rows[linha].Cells[0].Value);

                    Medico med = SelecionarMedico(codigo);

                    txtcodigo.Text = med.codigoM.ToString();
                    txtnome.Text = med.nomeM;
                    txtendereco.Text = med.enderecoM;
                    txtnumero.Text = med.numeroM.ToString();
                    mskcep.Text = med.cepM;
                    txtbairro.Text = med.bairroM;
                    txtcidade.Text = med.cidadeM;
                    cbestado.SelectedItem = med.estadoM;

                    if (med.statusM == "A")
                    {

                        chkstatus.Checked = false;

                    }

                    else
                    {

                        chkstatus.Checked = true;

                    }
                }


            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o paciente" + erro.Message);
            }


        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
         try
            {
                DialogResult res = MessageBox.Show("Tem certeza que deseja alterar?", "Alterar Médico/Pesquisador", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {

                    // Vai iniciar a captura dos valores da tela que forem alterados
                    // Jogará nos atributos do Paciente

                    int linha = dgmedico.SelectedRows[0].Index;

                    Medico med = new Medico();

                    med.codigoM = Convert.ToInt32(txtcodigo.Text);
                    med.nomeM = txtnome.Text;
                    med.celularM = mskcelular.Text;
                    med.enderecoM = txtendereco.Text;
                    med.numeroM = Convert.ToInt32(txtnumero.Text);
                    med.cepM = mskcep.Text;
                    med.cidadeM = txtcidade.Text;
                    med.estadoM = cbestado.Text;
                    med.bairroM = txtbairro.Text;

                    if (chkstatus.Checked == true)
                    {
                        med.statusM = "I";
                    }
                    else
                    {
                        med.statusM = "A";
                    }

                    // Implementando a estrutura para salvar no BD

                    SqlConnection con = new SqlConnection(Banco.StringConexao);
                    con.Open();

                    string sql = "Update medico set nomeM=@nomeM, celularM=@celularM, enderecoM=@enderecoM, numeroM=@numeroM, bairroM=@bairroM, cidadeM=@cidadeM, cep=@cep,"+
                        "estadoM=@estadoM, statusM=@statusM where codigoM=@codigoM";

                    SqlCommand cmd = new SqlCommand(sql, con);

                    // Pegará os valores da classe que foram alterados e irá atribuir aos campos no BD

                    cmd.Parameters.Add("@nomeM", SqlDbType.VarChar).Value = med.nomeM;
                    cmd.Parameters.Add("@enderecoM", SqlDbType.VarChar).Value = med.enderecoM;
                    cmd.Parameters.Add("@numeroM", SqlDbType.Int).Value = med.numeroM;
                    cmd.Parameters.Add("@bairroM", SqlDbType.VarChar).Value = med.bairroM;
                    cmd.Parameters.Add("@cidadeM", SqlDbType.VarChar).Value = med.cidadeM;
                    cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = med.cepM;
                    cmd.Parameters.Add("@estadoM", SqlDbType.VarChar).Value = med.estadoM;
                    

                    if (chkstatus.Checked == true)
                    {
                        med.statusM = "I";
                    }
                    else
                    {
                        med.statusM = "A";
                    }

                    cmd.Parameters.Add("@statusM", SqlDbType.VarChar).Value = med.statusM;
                    cmd.Parameters.Add("@codigoM", SqlDbType.Int).Value = med.codigoM;

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Médico/Pesquisador alterado com sucesso!!");

                    AtualizarGrid();
                    Limpar();

                }
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar Médico/Pesquisador" + erro.Message);
            }

        }

        public static DataTable PesquisarMedico(string nomeM)
        {

            try
            {

                SqlConnection con = new SqlConnection(Banco.StringConexao);
                con.Open();

                string sql = "Select * from medico where nome like @nomeM";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);

                da.SelectCommand.Parameters.Add("@nomeM", SqlDbType.VarChar).Value = "%" + nomeM + "%";

                // Carregando as informações do banco em forma de tabela

                DataTable dt = new DataTable();

                da.Fill(dt); // Preenchendo os dados da tabela 

                con.Close();

                return dt;


            }

            catch (Exception erro)
            {
                return null;
                MessageBox.Show("Erro ao pesquisar Médico/Pesquisador" + erro.Message);
            }
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            dgmedico.DataSource = PesquisarMedico(txtpesquisar.Text);

            // Montando o DataGridView com o cabeçalho e largura das colunas 

            dgmedico.Columns[0].HeaderText = "Código";
            dgmedico.Columns[1].HeaderText = "Nome";
            dgmedico.Columns[2].HeaderText = "Celular";
            dgmedico.Columns[3].HeaderText = "CEP";
            dgmedico.Columns[4].HeaderText = "Rua";
            dgmedico.Columns[5].HeaderText = "Nº";
            dgmedico.Columns[6].HeaderText = "Bairro";
            dgmedico.Columns[7].HeaderText = "Cidade";
            dgmedico.Columns[8].HeaderText = "UF";
            dgmedico.Columns[9].HeaderText = "Status";

            // Largura das colunas

            dgmedico.Columns[0].Width = 50;
            dgmedico.Columns[1].Width = 50;
            dgmedico.Columns[2].Width = 15;
            dgmedico.Columns[3].Width = 50;
            dgmedico.Columns[4].Width = 50;
            dgmedico.Columns[5].Width = 30;
            dgmedico.Columns[6].Width = 40;
            dgmedico.Columns[7].Width = 9;
            dgmedico.Columns[8].Width = 50;
            dgmedico.Columns[9].Width = 10;

            // Permite que consiga selecionar a linha do DataGrid

            dgmedico.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Permissões para usuários

            dgmedico.AllowUserToAddRows = false; // o usuário não pode add linhas
            dgmedico.AllowUserToDeleteRows = false; // o usuário não pode deletar linhas
            dgmedico.ReadOnly = true; // Deixará o datagrid somente para leitura

        }

        public void GerarCodigoMedico()
        {
            SqlConnection con = new SqlConnection(Banco.StringConexao);
            con.Open();
            
            String codigo = " ";

            try
            {
                String sql = "Select max(codigo) from medico";
                SqlCommand cmd = new SqlCommand(sql, con);

                // Vai retornar dados percorrendo a tabela 
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtcodigo.Text = Convert.ToString(Convert.ToInt32(dr[0]) + 1);
                }

                else
                {
                    codigo = "1";
                }

            }
            catch (Exception erro)
            {
                codigo = "1";
            }
            con.Close();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
        
        }
        }


        
    }
}
