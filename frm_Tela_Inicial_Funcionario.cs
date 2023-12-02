using DesktopTechCompany1;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopTechCompany12
{
    public partial class frm_Tela_Inicial_Funcionario : Form
    {
        private MySqlConnection Conexao;
        string data_source = "datasource=localhost;username=root;password=root;database=techcompany";
        string f;
        string[] nomeDoArray;

        public frm_Tela_Inicial_Funcionario()
        {
            InitializeComponent();

        }


        public frm_Tela_Inicial_Funcionario(String cpf)
        {
            InitializeComponent();
            f = cpf;
            this.Load += SeuFormulario_Load;


        }

        private void SeuFormulario_Load(object sender, EventArgs e)
        {
            // Método que será executado quando o formulário for carregado
            nomeDoArray = ObterDadosFuncionario(f);
            txb_Nome_Completo.Text = nomeDoArray[0];
            txb_Email.Text = nomeDoArray[1];
            txtCargo.Text = nomeDoArray[2];
        }

        public string[] ObterDadosFuncionario(string cpf)
        {
            string[] dadosFuncionario = new string[3]; // Criando um array para armazenar os dados

            using (Conexao = new MySqlConnection(data_source))
            {
                Conexao.Open();

                // Agora, vamos buscar os dados na tabela cadastro_funcionario
                string commandSqlFuncionario = "SELECT nome_completo, email, cargo FROM cadastro_funcionario WHERE cpf = @cpf";
                MySqlCommand comandoFuncionario = new MySqlCommand(commandSqlFuncionario, Conexao);
                comandoFuncionario.Parameters.AddWithValue("@cpf", cpf);

                using (MySqlDataReader readerFuncionario = comandoFuncionario.ExecuteReader())
                {
                    if (readerFuncionario.Read())
                    {
                        // Obter os dados do cadastro_funcionario
                        dadosFuncionario[0] = readerFuncionario.GetString(0); // Nome Completo
                        dadosFuncionario[1] = readerFuncionario.GetString(1); // Email
                        dadosFuncionario[2] = readerFuncionario.GetString(2); // Cargo
                    }
                }
            }

            return dadosFuncionario;
        }

        private void lbl_Cadastros_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Exibir_Folha_Tfuncionario frm_Exibir_Folha_Tfuncionario = new frm_Exibir_Folha_Tfuncionario(f);
            frm_Exibir_Folha_Tfuncionario.Show();

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Tela_de_login frm_Tela_De_Login = new frm_Tela_de_login();
            frm_Tela_De_Login.Show();
        }

        private void frm_Tela_Inicial_Funcionario_Load(object sender, EventArgs e)
        {

        }
    }
}
