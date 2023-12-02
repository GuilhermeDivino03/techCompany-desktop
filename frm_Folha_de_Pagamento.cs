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
    public partial class frm_Folha_de_Pagamento : Form
    {
        public frm_Folha_de_Pagamento()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frm_Visualizar_Folha_de_Pagamento frm_Visualizar_Folha_De_Pagamento = new frm_Visualizar_Folha_de_Pagamento();
            frm_Visualizar_Folha_De_Pagamento.Show();
        }
    }
}
