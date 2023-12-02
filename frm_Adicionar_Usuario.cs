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

namespace DesktopTechCompany31
{
    public partial class frm_Adicionar_Usuario : Form
    {
        private MySqlConnection Conexao;
        string data_source = "datasource=localhost;username=root;password=root;database=techcompany";
        public frm_Adicionar_Usuario()
        {
            InitializeComponent();
            this.AcceptButton = btn_Cadastrar;
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Menu frm_Menu = new frm_Menu();
            frm_Menu.Show();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                Conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO usuario (cpf, nome, senha,tipo)" +
                    "VALUES" +
                    "('" + txb_CPF.Text + "','" + txb_Nome.Text + "','" + txb_Senha.Text + "','" + txb_Tipo.Text + "') ";

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
    }
}
