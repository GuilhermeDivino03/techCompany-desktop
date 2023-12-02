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

namespace WinFormsApp1
{
    public partial class frm_Cadastrar_Funcionario : Form
    {
        private MySqlConnection Conexao;
        string data_source = "datasource=localhost;username=root;password=root;database=techcompany";

        public frm_Cadastrar_Funcionario()
        {
            InitializeComponent();
            this.AcceptButton = btn_Cadastrar;
        }

        private void frm_Cadastrar_Funcionario_Load(object sender, EventArgs e)
        {

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Menu frm_menu = new frm_Menu();
            frm_menu.Show();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {

            try
            {

                Conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO cadastro_funcionario (cpf, rg, nome_completo,email,telefone,cargo)" +
                    "VALUES" +
                    "('" + txb_CPF.Text + "','" + txb_RG.Text + "','" + txb_Nome_Completo.Text + "','" + txb_Email.Text + "','" +
                    txb_Telefone.Text + "','" + txb_Cargo.Text + "') ";

                //Executar Comando Insert
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Cadastro realizado com sucesso");


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

        private void txb_CPF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
