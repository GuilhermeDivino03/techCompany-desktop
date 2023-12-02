using DesktopTechCompany12;
using DesktopTechCompany31;
using DesktopTechCompany36;

namespace WinFormsApp1
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cadastrar_Folhas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Cadastrar_Folhas_de_Pagamento frm_cadastrar_folhas_de_pagamento = new frm_Cadastrar_Folhas_de_Pagamento();
            frm_cadastrar_folhas_de_pagamento.Show();
        }

        private void btn_Cadastrar_Funcionarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Cadastrar_Funcionario frm_cadastrar_funcionario = new frm_Cadastrar_Funcionario();
            frm_cadastrar_funcionario.Show();
        }

        private void btn_Visualizar_Funcionarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Visualizar_Funcionario frm_Visualizar_Funcionario = new frm_Visualizar_Funcionario();
            frm_Visualizar_Funcionario.Show();
        }

        private void btn_Visualizar_Folhas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Visualizar_Folha_de_Pagamento frm_Visualizar_Folha_De_Pagamento = new frm_Visualizar_Folha_de_Pagamento();
            frm_Visualizar_Folha_De_Pagamento.Show();
        }

        private void btn_Cadastrar_Usuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Adicionar_Usuario frm_Adicionar_Usuario = new frm_Adicionar_Usuario();
            frm_Adicionar_Usuario.Show();
        }

        private void btn_Visualizar_Usuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Visualizar_Usuario frm_Visualizar_Usuario = new frm_Visualizar_Usuario();
            frm_Visualizar_Usuario.Show();


        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Tela_de_login frm_Tela_De_Login = new frm_Tela_de_login();
            frm_Tela_De_Login.Show();

        }
    }
}