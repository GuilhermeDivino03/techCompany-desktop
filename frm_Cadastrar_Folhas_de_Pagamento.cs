using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frm_Cadastrar_Folhas_de_Pagamento : Form
    {

        private MySqlConnection Conexao;
        string data_source = "datasource=localhost;username=root;password=root;database=techcompany";

        public frm_Cadastrar_Folhas_de_Pagamento()
        {
            InitializeComponent();
            this.AcceptButton = btn_Cadastrar;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Funcionario_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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
                decimal[] folhaDePagamento = CalcularFolhaPagamento(Convert.ToDecimal(txb_Valor_Hora.Text), (int)Convert.ToDecimal(txb_Horas_Trabalhadas.Text));

                Conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO folha_pagamento (cpf_funcionario, salario_bruto, fgts, inss,irrf,vale_transporte, vale_alimentacao, salario_liquido)" +
                    "VALUES" +
                    "('" + txb_CPF.Text + "','" + folhaDePagamento[0].ToString("F2", CultureInfo.InvariantCulture) + "','" + folhaDePagamento[1].ToString("F2", CultureInfo.InvariantCulture) + "','" + folhaDePagamento[2].ToString("F2", CultureInfo.InvariantCulture) + "','" + folhaDePagamento[3].ToString("F2", CultureInfo.InvariantCulture) + "','" + folhaDePagamento[4].ToString("F2", CultureInfo.InvariantCulture) + "','" +
                    folhaDePagamento[5].ToString("F2", CultureInfo.InvariantCulture) + "','" + folhaDePagamento[6].ToString("F2", CultureInfo.InvariantCulture) + "') ";

                //Executar Comando Insert
                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

                MessageBox.Show("Cadastro realizado com sucesso!");


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

        private void frm_Cadastrar_Folhas_Pagamento_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        static decimal[] CalcularFolhaPagamento(decimal valorPorHora, int horasTrabalhadas)
        {
            decimal salarioBruto = valorPorHora * horasTrabalhadas;

            // Descontos
            decimal fgts = salarioBruto * 0.08m;
            decimal inss = salarioBruto * 0.11m;
            decimal irrf = salarioBruto * 0.026m;
            decimal valeTransporte = salarioBruto * 0.06m;
            decimal valeAlimentacao = salarioBruto * 0.1m;

            decimal totalDescontos = fgts + inss + irrf + valeTransporte + valeAlimentacao;

            decimal salarioLiquido = salarioBruto - totalDescontos;

            // Retornar um array com todas as informações
            return new decimal[] { salarioBruto, fgts, inss, irrf, valeTransporte, valeAlimentacao, salarioLiquido };
        }
    }
}
