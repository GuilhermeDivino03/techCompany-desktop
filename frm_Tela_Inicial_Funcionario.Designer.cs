namespace DesktopTechCompany12
{
    partial class frm_Tela_Inicial_Funcionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Tela_Inicial_Funcionario));
            btn_Entrar = new Button();
            lbl_Seja_Bem_Vindo = new Label();
            pct_Imagem_Menu = new PictureBox();
            btn_Logout = new Button();
            txb_Nome_Completo = new TextBox();
            lbl_Nome_Completo = new Label();
            txb_Email = new TextBox();
            lbl_Email = new Label();
            lbl_Funcionario = new Label();
            txtCargo = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pct_Imagem_Menu).BeginInit();
            SuspendLayout();
            // 
            // btn_Entrar
            // 
            btn_Entrar.BackColor = Color.SlateBlue;
            btn_Entrar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Entrar.ForeColor = SystemColors.HighlightText;
            btn_Entrar.Location = new Point(358, 254);
            btn_Entrar.Margin = new Padding(3, 4, 3, 4);
            btn_Entrar.Name = "btn_Entrar";
            btn_Entrar.Size = new Size(129, 89);
            btn_Entrar.TabIndex = 61;
            btn_Entrar.Text = "Consultar folha de pagamento";
            btn_Entrar.UseVisualStyleBackColor = false;
            btn_Entrar.Click += btn_Entrar_Click;
            // 
            // lbl_Seja_Bem_Vindo
            // 
            lbl_Seja_Bem_Vindo.AutoSize = true;
            lbl_Seja_Bem_Vindo.Font = new Font("Impact", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Seja_Bem_Vindo.ForeColor = Color.SlateBlue;
            lbl_Seja_Bem_Vindo.Location = new Point(112, 108);
            lbl_Seja_Bem_Vindo.Name = "lbl_Seja_Bem_Vindo";
            lbl_Seja_Bem_Vindo.Size = new Size(328, 54);
            lbl_Seja_Bem_Vindo.TabIndex = 60;
            lbl_Seja_Bem_Vindo.Text = "Seja Bem Vindo!";
            // 
            // pct_Imagem_Menu
            // 
            pct_Imagem_Menu.Image = (Image)resources.GetObject("pct_Imagem_Menu.Image");
            pct_Imagem_Menu.Location = new Point(217, 13);
            pct_Imagem_Menu.Margin = new Padding(3, 4, 3, 4);
            pct_Imagem_Menu.Name = "pct_Imagem_Menu";
            pct_Imagem_Menu.Size = new Size(118, 91);
            pct_Imagem_Menu.SizeMode = PictureBoxSizeMode.Zoom;
            pct_Imagem_Menu.TabIndex = 55;
            pct_Imagem_Menu.TabStop = false;
            // 
            // btn_Logout
            // 
            btn_Logout.BackColor = Color.SlateBlue;
            btn_Logout.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Logout.ForeColor = Color.White;
            btn_Logout.Location = new Point(12, 12);
            btn_Logout.Margin = new Padding(3, 4, 3, 4);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(75, 31);
            btn_Logout.TabIndex = 65;
            btn_Logout.Text = "Logout";
            btn_Logout.UseVisualStyleBackColor = false;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // txb_Nome_Completo
            // 
            txb_Nome_Completo.Location = new Point(33, 236);
            txb_Nome_Completo.Margin = new Padding(3, 4, 3, 4);
            txb_Nome_Completo.Name = "txb_Nome_Completo";
            txb_Nome_Completo.Size = new Size(228, 27);
            txb_Nome_Completo.TabIndex = 70;
            // 
            // lbl_Nome_Completo
            // 
            lbl_Nome_Completo.AutoSize = true;
            lbl_Nome_Completo.BackColor = Color.SlateBlue;
            lbl_Nome_Completo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Nome_Completo.ForeColor = Color.White;
            lbl_Nome_Completo.Location = new Point(33, 214);
            lbl_Nome_Completo.Name = "lbl_Nome_Completo";
            lbl_Nome_Completo.Size = new Size(122, 18);
            lbl_Nome_Completo.TabIndex = 69;
            lbl_Nome_Completo.Text = "Nome Completo:";
            // 
            // txb_Email
            // 
            txb_Email.Location = new Point(33, 286);
            txb_Email.Margin = new Padding(3, 4, 3, 4);
            txb_Email.Name = "txb_Email";
            txb_Email.Size = new Size(228, 27);
            txb_Email.TabIndex = 68;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.BackColor = Color.SlateBlue;
            lbl_Email.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Email.ForeColor = Color.White;
            lbl_Email.Location = new Point(33, 265);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(54, 18);
            lbl_Email.TabIndex = 67;
            lbl_Email.Text = "E-mail:";
            // 
            // lbl_Funcionario
            // 
            lbl_Funcionario.AutoSize = true;
            lbl_Funcionario.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Funcionario.ForeColor = Color.SlateBlue;
            lbl_Funcionario.Location = new Point(33, 185);
            lbl_Funcionario.Name = "lbl_Funcionario";
            lbl_Funcionario.Size = new Size(261, 21);
            lbl_Funcionario.TabIndex = 66;
            lbl_Funcionario.Text = "Informações do Funcionário:";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(33, 337);
            txtCargo.Margin = new Padding(3, 4, 3, 4);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(228, 27);
            txtCargo.TabIndex = 72;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SlateBlue;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 316);
            label1.Name = "label1";
            label1.Size = new Size(53, 18);
            label1.TabIndex = 71;
            label1.Text = "Cargo:";
            // 
            // frm_Tela_Inicial_Funcionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(543, 415);
            Controls.Add(txtCargo);
            Controls.Add(label1);
            Controls.Add(txb_Nome_Completo);
            Controls.Add(lbl_Nome_Completo);
            Controls.Add(txb_Email);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_Funcionario);
            Controls.Add(btn_Logout);
            Controls.Add(btn_Entrar);
            Controls.Add(lbl_Seja_Bem_Vindo);
            Controls.Add(pct_Imagem_Menu);
            MaximizeBox = false;
            Name = "frm_Tela_Inicial_Funcionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechCompany™";
            Load += frm_Tela_Inicial_Funcionario_Load;
            ((System.ComponentModel.ISupportInitialize)pct_Imagem_Menu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Entrar;
        private Label lbl_Seja_Bem_Vindo;
        private PictureBox pct_Imagem_Menu;
        private Button btn_Logout;
        private TextBox txb_Nome_Completo;
        private Label lbl_Nome_Completo;
        private TextBox txb_Email;
        private Label lbl_Email;
        private Label lbl_Funcionario;
        private TextBox txtCargo;
        private Label label1;
    }
}