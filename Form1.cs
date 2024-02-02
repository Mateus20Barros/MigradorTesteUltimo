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

        }

        private void btnCriarBD_Click(object sender, EventArgs e)
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
                string nomeBD = TxbNomeBD.Text;
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
                                comandoSqlDroparBD.ExecuteNonQuery();
                                MessageBox.Show($"Banco de dados {nomeBD} removido com sucesso !!!");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtLocalDB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fechando sistema");
            Application.Exit();
        }

        private void txbData_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
 

       
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
    }
}
