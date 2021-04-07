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
    public partial class CadastroPaciente : Form
    {
        public CadastroPaciente()
        {
            InitializeComponent();
            AtualizarGrid();
            GerarCodigoUsuario();
        }

        private void btnVoltarP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConcluirP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            try
            {

                Paciente pac = new Paciente();

                // Abre conexão com o banco de dados

                SqlConnection con = new SqlConnection(Banco.StringConexao);

                // Abre a conexão com o Banco
                con.Open();

                string sql = "Insert into paciente(nomeP, celularP, enderecoP, numeroP, bairroP, cidadeP, cep, estadoP, statusP)" +
                "values(@nomeP, @celularP, @enderecoP, @numeroP, @bairroP, @cidadeP, @cep, @estadoP, @statusP)";


                SqlCommand cmd = new SqlCommand(sql, con);

                // Direcionando os valores provenientes da tela 

                cmd.Parameters.Add("@nomeP", SqlDbType.VarChar).Value = txtNomeP.Text;
                cmd.Parameters.Add("@celularP", SqlDbType.VarChar).Value = mskCelularP.Text;
                cmd.Parameters.Add("@enderecoP", SqlDbType.VarChar).Value = txtEnderecoP.Text;
                cmd.Parameters.Add("@numeroP", SqlDbType.VarChar).Value = txtNumeroP.Text;
                cmd.Parameters.Add("@bairroP", SqlDbType.VarChar).Value = txtBairroP.Text;
                cmd.Parameters.Add("@cidadeP", SqlDbType.VarChar).Value = txtCidadeP.Text;
                cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = mskCepP.Text;
                cmd.Parameters.Add("@estadoP", SqlDbType.VarChar).Value = cboEstadoP.Text;


                if (chkStatusP.Checked == true)
                {
                    pac.statusP = "I";
                }

                else
                {
                    pac.statusP = "A";
                }

                cmd.Parameters.Add("@statusP", SqlDbType.VarChar).Value = pac.statusP;

                // Se tudo estiver correto , ele executará o comando insert
                cmd.ExecuteNonQuery();
                MessageBox.Show("Paciente cadastrado com sucesso!");

                // Fecha a conexão com o Banco de dados
                con.Close();

                AtualizarGrid(); // Quando clicar no botão salvar irá atualizar o datagrid

                Limpar(); // Limpa os Dados 
                GerarCodigoUsuario();


            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao inserir paciente" + erro.Message);
            }
        }

        public static DataTable ListarCliente()
        {
            try
            {

                SqlConnection con = new SqlConnection(Banco.StringConexao);
                con.Open();

                // Instrução Sql para realizar uma consulta no Banco de Dados - Seleciona os dados 

                string sql = "Select * from paciente"; // Recupera todas as informações da tabela de clientes

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
            // Este método carregara o dataGridView com os dados do cliente

        public void AtualizarGrid()
        {

            // O comando datasource faz com que os dados vindos do ListarCliente, carregue o 
            // DataGridView do cliente

            dgPaciente.DataSource = ListarCliente();

            // Montando o DataGridView com o cabeçalho e largura das colunas 

            dgPaciente.Columns[0].HeaderText = "Código";
            dgPaciente.Columns[1].HeaderText = "Nome";
            dgPaciente.Columns[2].HeaderText = "Celular";
            dgPaciente.Columns[3].HeaderText = "Rua";
            dgPaciente.Columns[4].HeaderText = "Nº";
            dgPaciente.Columns[5].HeaderText = "Bairro";
            dgPaciente.Columns[6].HeaderText = "Cidade";
            dgPaciente.Columns[7].HeaderText = "CEP";
            dgPaciente.Columns[8].HeaderText = "UF";
            dgPaciente.Columns[9].HeaderText = "Status";

            // Largura das colunas

            dgPaciente.Columns[0].Width = 35;
            dgPaciente.Columns[1].Width = 75;
            dgPaciente.Columns[2].Width = 75;
            dgPaciente.Columns[3].Width = 75;
            dgPaciente.Columns[4].Width = 75;
            dgPaciente.Columns[5].Width = 75;
            dgPaciente.Columns[6].Width = 75;
            dgPaciente.Columns[7].Width = 75;
            dgPaciente.Columns[8].Width = 35;
            dgPaciente.Columns[9].Width = 35;

            // Permite que consiga selecionar a linha do DataGrid

            dgPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Permissões para usuários

            dgPaciente.AllowUserToAddRows = false; // o usuário não pode add linhas
            dgPaciente.AllowUserToDeleteRows = false; // o usuário não pode deletar linhas
            dgPaciente.ReadOnly = true; // Deixará o datagrid somente para leitura

        }

        public void Limpar()
        {

            mskCepP.Clear();
            txtBairroP.Clear();
            mskCelularP.Clear();
            txtCidadeP.Clear();    
            txtCodigoP.Clear();
            txtEnderecoP.Clear();
            txtNomeP.Clear();
            txtNumeroP.Clear();
            txtPesquisarP.Clear();
            cboEstadoP.SelectedIndex = -1;

            if (chkStatusP.Checked == true)
            {

                chkStatusP.Checked = false;

            }

            txtNomeP.Focus();

        }

        public static Paciente SelecionarPaciente(int codigo)
        {

            try
            {

                SqlConnection con = new SqlConnection(Banco.StringConexao);
                con.Open();

                string sql = "Select * from paciente Where codigoP=@codigoP";

                SqlCommand cmd = new SqlCommand(sql, con);

                // Vai usar o codigo do paciente para fazer o filtro na busca do registro selecionado

                cmd.Parameters.Add("@codigoP", SqlDbType.Int).Value = codigo; // Codigo determinado no parametro.

                // Vai retornar os dados percorrendo a tabela

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    // Atenção a sequência do BD

                    Paciente pac = new Paciente();

                    pac.codigoP = Convert.ToInt32(dr[0]);
                    pac.nomeP = dr[1].ToString();
                    pac.celularP = dr[2].ToString();
                    pac.enderecoP = dr[3].ToString();
                    pac.numeroP = Convert.ToInt32(dr[4]);
                    pac.bairroP = dr[5].ToString();
                    pac.cidadeP = dr[6].ToString();
                    pac.cepP = dr[7].ToString();
                    pac.estadoP = dr[8].ToString();
                    pac.statusP = dr[9].ToString();

                    con.Close();
                    return pac;
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

        private void dgPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vai pegar os dados da classe e jogar nos TextBox

            // Vai verificar se há linha selecionada no datagrid

            try
            {
                int linha = dgPaciente.SelectedRows[0].Index;

                if (linha >= 0)
                {

                    // Vai pegar o codigo do paciente da linha que foi selecionada
                    int codigo = Convert.ToInt32(dgPaciente.Rows[linha].Cells[0].Value);

                    Paciente pac = SelecionarPaciente(codigo);

                    txtCodigoP.Text = pac.codigoP.ToString();
                    txtNomeP.Text = pac.nomeP;
                    txtEnderecoP.Text = pac.enderecoP;
                    txtNumeroP.Text = pac.numeroP.ToString();
                    mskCepP.Text = pac.cepP;
                    txtBairroP.Text = pac.bairroP;
                    txtCidadeP.Text = pac.cidadeP;
                    cboEstadoP.SelectedItem = pac.estadoP;

                    if (pac.statusP == "A")
                    {

                        chkStatusP.Checked = false;

                    }

                    else
                    {

                        chkStatusP.Checked = true;

                    }
                }


            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao selecionar o paciente" + erro.Message);
            }


        }

        // Metodo para alterar os registros no banco de dados

        private void btnAlterarP_Click(object sender, EventArgs e)
        {
        
             try
            {
                DialogResult res = MessageBox.Show("Tem certeza que deseja alterar?", "Alterar Paciente",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {

                    // Vai iniciar a captura dos valores da tela que forem alterados
                    // Jogará nos atributos do Paciente

                    int linha = dgPaciente.SelectedRows[0].Index;

                    Paciente pac = new Paciente();

                    pac.codigoP = Convert.ToInt32(txtCodigoP.Text);
                    pac.nomeP = txtNomeP.Text;
                    pac.celularP = mskCelularP.Text;
                    pac.enderecoP = txtEnderecoP.Text;
                    pac.numeroP = Convert.ToInt32(txtNumeroP.Text);
                    pac.cepP = mskCepP.Text;
                    pac.cidadeP = txtCidadeP.Text;
                    pac.estadoP = cboEstadoP.Text;
                    pac.bairroP = txtBairroP.Text;

                    if (chkStatusP.Checked == true)
                    {
                        pac.statusP = "I";
                    }
                    else
                    {
                        pac.statusP = "A";
                    }

                    // Implementando a estrutura para salvar no BD

                    SqlConnection con = new SqlConnection(Banco.StringConexao);
                    con.Open();

                    string sql = "Update paciente set nomeP=@nomeP, celularP=@celularP, enderecoP=@enderecoP, numeroP=@numeroP, bairroP=@bairroP, cidadeP=@cidadeP, cep=@cep,"+
                        "estadoP=@estadoP, statusP=@statusP where CodigoP=@codigoP";

                    SqlCommand cmd = new SqlCommand(sql, con);

                    // Pegará os valores da classe que foram alterados e irá atribuir aos campos no BD

                    cmd.Parameters.Add("@nomeP", SqlDbType.VarChar).Value = pac.nomeP;
                    cmd.Parameters.Add("@enderecoP", SqlDbType.VarChar).Value = pac.enderecoP;
                    cmd.Parameters.Add("@numeroP", SqlDbType.Int).Value = pac.numeroP;
                    cmd.Parameters.Add("@bairroP", SqlDbType.VarChar).Value = pac.bairroP;
                    cmd.Parameters.Add("@cidadeP", SqlDbType.VarChar).Value = pac.cidadeP;
                    cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = pac.cepP;
                    cmd.Parameters.Add("@estadoP", SqlDbType.VarChar).Value = pac.estadoP;
                    

                    if (chkStatusP.Checked == true)
                    {
                        pac.statusP = "I";
                    }
                    else
                    {
                        pac.statusP = "A";
                    }

                    cmd.Parameters.Add("@statusP", SqlDbType.VarChar).Value = pac.statusP;
                    cmd.Parameters.Add("@codigoP", SqlDbType.Int).Value = pac.codigoP;

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Paciente alterado com sucesso!!");

                    AtualizarGrid();
                    Limpar();

                }
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao alterar Paciente" + erro.Message);
            }

        }

        public static DataTable PesquisarPaciente(string nomeP)
        {

            try
            {

                SqlConnection con = new SqlConnection(Banco.StringConexao);
                con.Open();

                string sql = "Select * from paciente where nome like @nomeP";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);

                da.SelectCommand.Parameters.Add("@nomeP", SqlDbType.VarChar).Value = "%" + nomeP + "%";

                // Carregando as informações do banco em forma de tabela

                DataTable dt = new DataTable();

                da.Fill(dt); // Preenchendo os dados da tabela 

                con.Close();

                return dt;


            }

            catch (Exception erro)
            {
                return null;
                MessageBox.Show("Erro ao pesquisar paciente" + erro.Message);
            }
        }

        //Botão pesquisar

        private void btnPesquisarP_Click(object sender, EventArgs e)
        {
        
            dgPaciente.DataSource = PesquisarPaciente(txtPesquisarP.Text);

            // Montando o DataGridView com o cabeçalho e largura das colunas 

            dgPaciente.Columns[0].HeaderText = "Código";
            dgPaciente.Columns[1].HeaderText = "Nome";
            dgPaciente.Columns[2].HeaderText = "Celular";
            dgPaciente.Columns[3].HeaderText = "CEP";
            dgPaciente.Columns[4].HeaderText = "Rua";
            dgPaciente.Columns[5].HeaderText = "Nº";
            dgPaciente.Columns[6].HeaderText = "Bairro";
            dgPaciente.Columns[7].HeaderText = "Cidade";
            dgPaciente.Columns[8].HeaderText = "UF";
            dgPaciente.Columns[9].HeaderText = "Status";

            // Largura das colunas

            dgPaciente.Columns[0].Width = 50;
            dgPaciente.Columns[1].Width = 50;
            dgPaciente.Columns[2].Width = 15;
            dgPaciente.Columns[3].Width = 50;
            dgPaciente.Columns[4].Width = 50;
            dgPaciente.Columns[5].Width = 30;
            dgPaciente.Columns[6].Width = 40;
            dgPaciente.Columns[7].Width = 9;
            dgPaciente.Columns[8].Width = 50;
            dgPaciente.Columns[9].Width = 10;

            // Permite que consiga selecionar a linha do DataGrid

            dgPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Permissões para usuários

            dgPaciente.AllowUserToAddRows = false; // o usuário não pode add linhas
            dgPaciente.AllowUserToDeleteRows = false; // o usuário não pode deletar linhas
            dgPaciente.ReadOnly = true; // Deixará o datagrid somente para leitura

        }

        public void GerarCodigoUsuario()
        {
            SqlConnection con = new SqlConnection(Banco.StringConexao);
            con.Open();
            
            String codigo = " ";

            try
            {
                String sql = "Select max(codigo) from paciente";
                SqlCommand cmd = new SqlCommand(sql, con);

                // Vai retornar dados percorrendo a tabela 
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtCodigoP.Text = Convert.ToString(Convert.ToInt32(dr[0]) + 1);
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

        private void btnExcluirP_Click(object sender, EventArgs e)
        {
            // Botão Excluir - Excluir registro do BD
            try
            {
                DialogResult confirm = MessageBox.Show("Tem certeza que deseja excluir este paciente?", "Excluir Paciente",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm == DialogResult.Yes)
                {


                    SqlConnection con = new SqlConnection(Banco.StringConexao);
                    con.Open();

                    string sql = "Delete from paciente where codigoP=@codigoP";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add("@codigoP", SqlDbType.VarChar).Value = txtCodigoP.Text;
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Paciente excluido com Sucesso!!");
                    Limpar();
                    AtualizarGrid();
                    GerarCodigoUsuario();
                    con.Close();

                }
            }

            catch (Exception erro)
            {
                MessageBox.Show("Erro ao excluir Paciente" + erro.Message);
            }
          
        }

      

        private void mskCepP_Leave(object sender, EventArgs e)
        {
          // XML = eXtensible Markup  Language (Linguagem de Marcação extensivel) a função é auxiliar 
            // os sistemas de informação no compartilhamento de dados (especialmnte via internet), além
            // de codificar documentos.

            // Web Service = é uma solução utilizada na itegração de sistemas e na comunicação entre 
            // aplicações diferentes.
            // Permite encivar e receber dados em formato XML

            // Web Servicew irá retornar um endereço especifico de acordo com o cep informado

            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml"
                .Replace("@cep", mskCepP.Text); // Buscar registro

            // DataSet foi projetado para acesso a dados não importando a fonte desses dados
            DataSet ds = new DataSet();
            ds.ReadXml(xml);

            txtEnderecoP.Text = ds.Tables[0].Rows[0][6].ToString();
            txtBairroP.Text = ds.Tables[0].Rows[0][4].ToString();
            txtCidadeP.Text = ds.Tables[0].Rows[0][3].ToString();
            cboEstadoP.Text = ds.Tables[0].Rows[0][2].ToString();
       

        }
        


        }


        }
        

