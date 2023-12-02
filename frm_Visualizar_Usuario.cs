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

namespace DesktopTechCompany36
{
    public partial class frm_Visualizar_Usuario : Form
    {
        private MySqlConnection Conexao;
        string data_source = "datasource=localhost;username=root;password=root;database=techcompany";

        public frm_Visualizar_Usuario()
        {
            InitializeComponent();
            this.AcceptButton = btn_Visualizar;

            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("CPF", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Senha", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Tipo", 130, HorizontalAlignment.Left);
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Menu frm_Menu = new frm_Menu();
            frm_Menu.Show();
        }

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string c = "'%" + txb_CPF.Text + "%'";

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT *" +
                    "FROM usuario " +
                    "WHERE cpf LIKE" + c;

                Conexao.Open();

                //Executar Comando select
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comando.ExecuteReader();


                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3)
                    };
                    var linha_listview = new ListViewItem(row);

                    listView1.Items.Add(linha_listview);




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
    }
}
