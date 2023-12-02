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
    public partial class frm_Funcionario : Form
    {
        public frm_Funcionario()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Visualizar_Funcionario frm_Visualizar_Funcionario = new frm_Visualizar_Funcionario();
            frm_Visualizar_Funcionario.Show();
        }
    }
}
