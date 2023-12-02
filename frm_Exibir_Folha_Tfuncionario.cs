using DesktopTechCompany12;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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

namespace DesktopTechCompany1
{
    public partial class frm_Exibir_Folha_Tfuncionario : Form
    {

        private MySqlConnection Conexao;
        string data_source = "datasource=localhost;username=root;password=root;database=techcompany";
        string f;
        string[] nomeDoArray;

        public frm_Exibir_Folha_Tfuncionario()
        {
            InitializeComponent();

        }

        public frm_Exibir_Folha_Tfuncionario(string cpf)
        {
            InitializeComponent();

            f = cpf;
            this.Load += SeuFormulario_Load;

            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("CPF", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Salario Bruto", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("FGTS", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("INSS", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("IRRF", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Vale Transporte", 130, HorizontalAlignment.Left);
            listView1.Columns.Add("Vale Alimentação", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Salario liquido", 130, HorizontalAlignment.Left);
        }

        private void SeuFormulario_Load(object sender, EventArgs e)
        {
            // Método que será executado quando o formulário for carregado
            nomeDoArray = ObterDadosFuncionario(f);
            var linha_listview = new ListViewItem(nomeDoArray);

            listView1.Items.Add(linha_listview);
        }

        public string[] ObterDadosFuncionario(string cpf)
        {
            string[] dadosFuncionario = new string[8]; // Criando um array para armazenar os dados

            using (Conexao = new MySqlConnection(data_source))
            {
                Conexao.Open();

                // Agora, vamos buscar os dados na tabela cadastro_funcionario
                string commandSqlFuncionario = "SELECT * FROM folha_pagamento WHERE cpf_funcionario = @cpf";
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
                        dadosFuncionario[3] = readerFuncionario.GetString(3); // Email
                        dadosFuncionario[4] = readerFuncionario.GetString(4); // Cargo
                        dadosFuncionario[5] = readerFuncionario.GetString(5); // Email
                        dadosFuncionario[6] = readerFuncionario.GetString(6); // Cargo
                        dadosFuncionario[7] = readerFuncionario.GetString(7); // Cargo
                    }
                }
            }

            return dadosFuncionario;
        }

        private void frm_Exibir_Folha_Tfuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Tela_Inicial_Funcionario frmTelaInicialFuncionario = new frm_Tela_Inicial_Funcionario(f);
            frmTelaInicialFuncionario.Show();
        }

    }

}
