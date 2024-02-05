using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MigradorTeste
{
    public partial class Form1 : Form
    {
        private int mov;
        private int movX;
        private int movY;
        public string servidor = Environment.MachineName.ToString();
        public string conexaoAoBD;
        public string caminhoLog;
        public string caminhoData;

        public Form1()
        {
            InitializeComponent();
            conexaoAoBD = $"Data Source={txtLocalDB.Text};Initial Catalog=master;Integrated Security=True;";
            //conexaoAoBD = $"Data Source={servidor};Initial Catalog=master;Integrated Security=True;";
            txtLocalDB.Text = servidor;
            caminhoData = txbData.Text;

            // Adiciona o manipulador de eventos KeyDown ao formulário
            this.KeyDown += BotaFechar_KeyDown;

            // Configura o formulário para receber eventos de teclado, mesmo quando os controles filhos têm o foco
            this.KeyPreview = true;

        }

        private void BtnCriarBD_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeBD = TxbNomeBD.Text;
                string diretorio = txbData.Text;

                string comandoCriarBD = $@"
                            CREATE DATABASE {nomeBD} 
                            ON PRIMARY (
	                            NAME = [{nomeBD}_DATA.MDF], 
	                            FILENAME = '{diretorio}\{nomeBD}_DATA.MDF', 
	                            SIZE = 3 MB, 
	                            MAXSIZE = UNLIMITED, 
	                            FILEGROWTH = 10 % 
                            ) 
                            LOG ON ( 
	                            NAME = [{nomeBD}_LOG.LDF], 
	                            FILENAME = '{diretorio}\{nomeBD}_LOG.LDF', 
	                            SIZE = 3 MB, 
	                            MAXSIZE = UNLIMITED, 
	                            FILEGROWTH = 10 % 
                            ); 
                            ALTER DATABASE {nomeBD} SET RECOVERY FULL;"
                ;

                string VerificarSeBDExisti = $"SELECT database_id FROM sys.databases WHERE name = '{nomeBD}'";

                using (SqlConnection conexao = new SqlConnection(conexaoAoBD))
                {
                    conexao.Open();

                    using (SqlCommand comandoSqlVerificaBD = new SqlCommand(VerificarSeBDExisti, conexao))
                    using (SqlCommand comandoSqlCriarBD = new SqlCommand(comandoCriarBD, conexao))
                    {
                        object retornoBD = comandoSqlVerificaBD.ExecuteScalar();

                        if (retornoBD == null)
                        {
                            comandoSqlCriarBD.ExecuteNonQuery();
                            MessageBox.Show($"Banco de dados {nomeBD} criado com sucesso !!!");
                            CarregarDados(conexaoAoBD);
                        }
                        else
                        {
                            MessageBox.Show($"Banco de dados {nomeBD} ja existe no servidor !!!");
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao criar banco de dados. {ex.Message}");
            }
        }

        private void BtnDroparBD_Click(object sender, EventArgs e)
        {
            try
            {
                //string nomeBD = TxbNomeBD.Text;
                string nomeBD = comboBox1.SelectedValue.ToString();
                string VerificarSeBDExisti = $"SELECT database_id FROM sys.databases WHERE name = '{nomeBD}'";
                string comandoDroparBD = $"DROP DATABASE {nomeBD}";

                using (SqlConnection conexao = new SqlConnection(conexaoAoBD))
                {
                    conexao.Open();

                    using (SqlCommand comandoSqlVerificaBD = new SqlCommand(VerificarSeBDExisti, conexao))
                    {
                        object retornoBD = comandoSqlVerificaBD.ExecuteScalar();

                        if (retornoBD != null)
                        {
                            using (SqlCommand comandoSqlDroparBD = new SqlCommand(comandoDroparBD, conexao))
                            {

                             DialogResult result = MessageBox.Show(
                             $"Deseja realmente remover o banco {nomeBD}?", 
                             "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (result == DialogResult.Yes)
                                {
                                    comandoSqlDroparBD.ExecuteNonQuery();
                                    MessageBox.Show($"Banco de dados {nomeBD} removido com sucesso !!!");
                                    CarregarDados(conexaoAoBD);
                                }
                                else
                                {
                                    return ;
                                }
                                
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Banco de dados {nomeBD} não existe no servidor !!!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover banco de dados. {ex.Message}");
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtLocalDB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxbData_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //O CarregarDados é onde carrega a listagem de todos os bancos no comboBox1 
            CarregarDados(conexaoAoBD);
            string atualiza = "TERMINA O MAX_ATUALIZA AI MANÉ";
            MessageBox.Show(atualiza);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1; movX = e.X; movY = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }


        private void BotaFechar_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                     "Deseja Fechar a aplicação?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                     );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        public void BotaFechar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F)
            {
                DialogResult result = MessageBox.Show(
                    "Deseja Fechar a aplicação?", "Informação",MessageBoxButtons.YesNo,MessageBoxIcon.Question
                    ) ;
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                    this.Close();
                }
                else
                {
                    
                }
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void CarregarDados(string connectionString)
        {
            SqlConnection con = new SqlConnection(connectionString);

            // 3 - ABRIR CONEXÃO
            con.Open();

            // 4 - PREPARANDO A QUERY PARA RECEBER AS VARIAVEIS E SALVAR NO BANCO.
            string query = "select upper(name) from sys.databases where name not in ('master','tempdb','model','msdb') order by name";

            // 5 - EXECUTANDO A QUERY
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            // 6 - LISTA DOS DATABASES.
            List<string> lista = new List<string>();
            while (reader.Read())
            {
                lista.Add(reader[0].ToString());
            }

            // 7 - Atribuir a lista como a fonte de dados da ComboBox
            comboBox1.DataSource = new BindingList<string>(lista);

            // 8 - Fechar o leitor
            reader.Close();
        }

        private void AtualizaBanco_Click(object sender, EventArgs e)
        {
            CarregarDados(conexaoAoBD);
        }

        private void MaxAtualiza_Click(object sender, EventArgs e)
        {
            string caminhoDoExe = @"D:\MAX\MAX_Atualiza.exe";
            string parametros = "/F";

            Process process = new Process();
            process.StartInfo.FileName = caminhoDoExe;
            process.StartInfo.Arguments = parametros;

            try
            {
                // Inicia a aplicação
                process.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao iniciar a aplicação: " + ex.Message);
            }
            finally
            {
                // Certifica-se de liberar os recursos associados ao processo
                process.Dispose();
            }
        
        }
    }
}

