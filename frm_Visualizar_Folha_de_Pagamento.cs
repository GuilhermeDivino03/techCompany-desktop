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
    public partial class frm_Visualizar_Folha_de_Pagamento : Form
    {
        private MySqlConnection Conexao;
        string data_source = "datasource=localhost;username=root;password=root;database=techcompany";

        public frm_Visualizar_Folha_de_Pagamento()
        {
            InitializeComponent();
            this.AcceptButton = btn_Visualizar;

            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("CPF", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Salario Bruto", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("FGTS", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("INSS", 130, HorizontalAlignment.Left);
            listView1.Columns.Add("IRRF", 130, HorizontalAlignment.Left);
            listView1.Columns.Add("Vale Transporte", 130, HorizontalAlignment.Left);
            listView1.Columns.Add("Vale Alimentação", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Salario liquido", 130, HorizontalAlignment.Left);
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Menu frm_menu = new frm_Menu();
            frm_menu.Show();
        }

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {

            try
            {
                string c = "'%" + txb_CPF.Text + "%'";

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT *" +
                    "FROM folha_pagamento " +
                    "WHERE cpf_funcionario LIKE" + c;

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
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6),
                        reader.GetString(7),
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

        private void lbl_Funcionario_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txb_CPF_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbl_Visualizar_Funcionario_Click(object sender, EventArgs e)
        {
        }

        private void pct_Imagem_Menu_Click(object sender, EventArgs e)
        {
        }
    }
}
