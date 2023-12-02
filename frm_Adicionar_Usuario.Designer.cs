namespace DesktopTechCompany31
{
    partial class frm_Adicionar_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Adicionar_Usuario));
            pct_Imagem_Menu = new PictureBox();
            btn_Cadastrar = new Button();
            lbl_Cadastrar_Funcionario = new Label();
            lbl_Funcionario = new Label();
            lbl_CPF = new Label();
            txb_CPF = new TextBox();
            lbl_RG = new Label();
            txb_Nome = new TextBox();
            label2 = new Label();
            txb_Senha = new TextBox();
            label1 = new Label();
            txb_Tipo = new TextBox();
            btn_Voltar = new Button();
            ((System.ComponentModel.ISupportInitialize)pct_Imagem_Menu).BeginInit();
            SuspendLayout();
            // 
            // pct_Imagem_Menu
            // 
            pct_Imagem_Menu.Image = (Image)resources.GetObject("pct_Imagem_Menu.Image");
            pct_Imagem_Menu.Location = new Point(338, 13);
            pct_Imagem_Menu.Margin = new Padding(3, 4, 3, 4);
            pct_Imagem_Menu.Name = "pct_Imagem_Menu";
            pct_Imagem_Menu.Size = new Size(118, 91);
            pct_Imagem_Menu.SizeMode = PictureBoxSizeMode.Zoom;
            pct_Imagem_Menu.TabIndex = 58;
            pct_Imagem_Menu.TabStop = false;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.BackColor = Color.SlateBlue;
            btn_Cadastrar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cadastrar.ForeColor = SystemColors.HighlightText;
            btn_Cadastrar.Location = new Point(419, 371);
            btn_Cadastrar.Margin = new Padding(3, 4, 3, 4);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(115, 76);
            btn_Cadastrar.TabIndex = 70;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = false;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // lbl_Cadastrar_Funcionario
            // 
            lbl_Cadastrar_Funcionario.AutoSize = true;
            lbl_Cadastrar_Funcionario.Font = new Font("Impact", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Cadastrar_Funcionario.ForeColor = Color.SlateBlue;
            lbl_Cadastrar_Funcionario.Location = new Point(200, 110);
            lbl_Cadastrar_Funcionario.Name = "lbl_Cadastrar_Funcionario";
            lbl_Cadastrar_Funcionario.Size = new Size(367, 54);
            lbl_Cadastrar_Funcionario.TabIndex = 60;
            lbl_Cadastrar_Funcionario.Text = "Cadastrar Usuario";
            // 
            // lbl_Funcionario
            // 
            lbl_Funcionario.AutoSize = true;
            lbl_Funcionario.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Funcionario.ForeColor = Color.SlateBlue;
            lbl_Funcionario.Location = new Point(146, 195);
            lbl_Funcionario.Name = "lbl_Funcionario";
            lbl_Funcionario.Size = new Size(283, 27);
            lbl_Funcionario.TabIndex = 61;
            lbl_Funcionario.Text = "Informações do Usuario:";
            // 
            // lbl_CPF
            // 
            lbl_CPF.AutoSize = true;
            lbl_CPF.BackColor = Color.SlateBlue;
            lbl_CPF.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_CPF.ForeColor = Color.White;
            lbl_CPF.Location = new Point(146, 232);
            lbl_CPF.Name = "lbl_CPF";
            lbl_CPF.Size = new Size(42, 18);
            lbl_CPF.TabIndex = 62;
            lbl_CPF.Text = "CPF:";
            // 
            // txb_CPF
            // 
            txb_CPF.Location = new Point(146, 254);
            txb_CPF.Margin = new Padding(3, 4, 3, 4);
            txb_CPF.Name = "txb_CPF";
            txb_CPF.Size = new Size(251, 27);
            txb_CPF.TabIndex = 63;
            // 
            // lbl_RG
            // 
            lbl_RG.AutoSize = true;
            lbl_RG.BackColor = Color.SlateBlue;
            lbl_RG.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_RG.ForeColor = Color.White;
            lbl_RG.Location = new Point(403, 232);
            lbl_RG.Name = "lbl_RG";
            lbl_RG.Size = new Size(53, 18);
            lbl_RG.TabIndex = 64;
            lbl_RG.Text = "Nome:";
            // 
            // txb_Nome
            // 
            txb_Nome.Location = new Point(403, 254);
            txb_Nome.Margin = new Padding(3, 4, 3, 4);
            txb_Nome.Name = "txb_Nome";
            txb_Nome.Size = new Size(251, 27);
            txb_Nome.TabIndex = 65;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SlateBlue;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(146, 291);
            label2.Name = "label2";
            label2.Size = new Size(54, 18);
            label2.TabIndex = 66;
            label2.Text = "Senha:";
            // 
            // txb_Senha
            // 
            txb_Senha.Location = new Point(146, 313);
            txb_Senha.Margin = new Padding(3, 4, 3, 4);
            txb_Senha.Name = "txb_Senha";
            txb_Senha.Size = new Size(251, 27);
            txb_Senha.TabIndex = 67;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SlateBlue;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(403, 291);
            label1.Name = "label1";
            label1.Size = new Size(41, 18);
            label1.TabIndex = 68;
            label1.Text = "Tipo:";
            // 
            // txb_Tipo
            // 
            txb_Tipo.Location = new Point(403, 313);
            txb_Tipo.Margin = new Padding(3, 4, 3, 4);
            txb_Tipo.Name = "txb_Tipo";
            txb_Tipo.Size = new Size(251, 27);
            txb_Tipo.TabIndex = 69;
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = SystemColors.GrayText;
            btn_Voltar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Voltar.ForeColor = SystemColors.HighlightText;
            btn_Voltar.Location = new Point(240, 371);
            btn_Voltar.Margin = new Padding(3, 4, 3, 4);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(115, 76);
            btn_Voltar.TabIndex = 71;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // frm_Adicionar_Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 472);
            Controls.Add(btn_Cadastrar);
            Controls.Add(btn_Voltar);
            Controls.Add(txb_Tipo);
            Controls.Add(label1);
            Controls.Add(txb_Senha);
            Controls.Add(label2);
            Controls.Add(txb_Nome);
            Controls.Add(lbl_RG);
            Controls.Add(txb_CPF);
            Controls.Add(lbl_CPF);
            Controls.Add(lbl_Funcionario);
            Controls.Add(lbl_Cadastrar_Funcionario);
            Controls.Add(pct_Imagem_Menu);
            Name = "frm_Adicionar_Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechCompany™";
            ((System.ComponentModel.ISupportInitialize)pct_Imagem_Menu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pct_Imagem_Menu;
        private Button btn_Cadastrar;
        private Label lbl_Cadastrar_Funcionario;
        private Label lbl_Funcionario;
        private Label lbl_CPF;
        private TextBox txb_CPF;
        private Label lbl_RG;
        private TextBox txb_Nome;
        private Label label2;
        private TextBox txb_Senha;
        private Label label1;
        private TextBox txb_Tipo;
        private Button btn_Voltar;
    }
}