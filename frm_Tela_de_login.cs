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
using WinFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DesktopTechCompany12
{
    public partial class frm_Tela_de_login : Form
    {
        private MySqlConnection Conexao;
        string data_source = "datasource=localhost;username=root;password=root;database=techcompany";
        string tipoFuncionario;
        string cpf;


        public frm_Tela_de_login()
        {
            InitializeComponent();

            this.AcceptButton = btn_Entrar;
        }

        private void frm_Tela_de_login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btn_Entrar_Click(object sender, EventArgs e)
        {

            string commandSql = "SELECT * FROM usuario WHERE cpf ='" + txb_Usuario.Text + "' AND senha = '" + txb_Senha.Text + "'";

            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(commandSql, Conexao);
                MySqlDataReader reader = comando.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Usuario ou senha incorreta");
                    return;
                }

                cpf = reader.GetString(0); // CPF do usuário logado
                tipoFuncionario = reader.GetString(3);
                reader.Close();


                if ("funcionario".Equals(tipoFuncionario))
                {
                    this.exibirTelaInicialDoFuncionario();
                }

                if ("admin".Equals(tipoFuncionario))
                {
                    this.exibirTelaDoMenu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao?.Close();
            }
        }

        private void exibirTelaInicialDoFuncionario()
        {
            this.Hide();
            frm_Tela_Inicial_Funcionario frmTelaInicialFuncionario = new frm_Tela_Inicial_Funcionario(cpf);
            frmTelaInicialFuncionario.Show();
        }

        private void exibirTelaDoMenu()
        {
            this.Hide();
            frm_Menu frmMenu = new frm_Menu();
            frmMenu.Show();
        }

    }
}
