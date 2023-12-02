namespace WinFormsApp1
{
    partial class frm_Cadastrar_Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cadastrar_Funcionario));
            lbl_Cadastrar_Funcionario = new Label();
            lbl_Funcionario = new Label();
            txb_Cargo = new TextBox();
            txb_CPF = new TextBox();
            lbl_Cargo = new Label();
            lbl_CPF = new Label();
            lbl_Nome_Completo = new Label();
            txb_Nome_Completo = new TextBox();
            lbl_Email = new Label();
            txb_Email = new TextBox();
            lbl_Telefone = new Label();
            txb_Telefone = new TextBox();
            lbl_RG = new Label();
            txb_RG = new TextBox();
            btn_Cadastrar = new Button();
            btn_Voltar = new Button();
            pct_Imagem_Menu = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pct_Imagem_Menu).BeginInit();
            SuspendLayout();
            // 
            // lbl_Cadastrar_Funcionario
            // 
            lbl_Cadastrar_Funcionario.AutoSize = true;
            lbl_Cadastrar_Funcionario.Font = new Font("Impact", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Cadastrar_Funcionario.ForeColor = Color.SlateBlue;
            lbl_Cadastrar_Funcionario.Location = new Point(173, 113);
            lbl_Cadastrar_Funcionario.Name = "lbl_Cadastrar_Funcionario";
            lbl_Cadastrar_Funcionario.Size = new Size(446, 54);
            lbl_Cadastrar_Funcionario.TabIndex = 1;
            lbl_Cadastrar_Funcionario.Text = "Cadastrar Funcionario";
            // 
            // lbl_Funcionario
            // 
            lbl_Funcionario.AutoSize = true;
            lbl_Funcionario.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Funcionario.ForeColor = Color.SlateBlue;
            lbl_Funcionario.Location = new Point(138, 192);
            lbl_Funcionario.Name = "lbl_Funcionario";
            lbl_Funcionario.Size = new Size(331, 27);
            lbl_Funcionario.TabIndex = 2;
            lbl_Funcionario.Text = "Informações do Funcionário:";
            // 
            // txb_Cargo
            // 
            txb_Cargo.Location = new Point(395, 410);
            txb_Cargo.Margin = new Padding(3, 4, 3, 4);
            txb_Cargo.Name = "txb_Cargo";
            txb_Cargo.Size = new Size(251, 27);
            txb_Cargo.TabIndex = 7;
            // 
            // txb_CPF
            // 
            txb_CPF.Location = new Point(138, 251);
            txb_CPF.Margin = new Padding(3, 4, 3, 4);
            txb_CPF.Name = "txb_CPF";
            txb_CPF.Size = new Size(251, 27);
            txb_CPF.TabIndex = 8;
            txb_CPF.TextChanged += txb_CPF_TextChanged;
            // 
            // lbl_Cargo
            // 
            lbl_Cargo.AutoSize = true;
            lbl_Cargo.BackColor = Color.SlateBlue;
            lbl_Cargo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Cargo.ForeColor = Color.White;
            lbl_Cargo.Location = new Point(395, 388);
            lbl_Cargo.Name = "lbl_Cargo";
            lbl_Cargo.Size = new Size(53, 18);
            lbl_Cargo.TabIndex = 5;
            lbl_Cargo.Text = "Cargo:";
            // 
            // lbl_CPF
            // 
            lbl_CPF.AutoSize = true;
            lbl_CPF.BackColor = Color.SlateBlue;
            lbl_CPF.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_CPF.ForeColor = Color.White;
            lbl_CPF.Location = new Point(138, 229);
            lbl_CPF.Name = "lbl_CPF";
            lbl_CPF.Size = new Size(42, 18);
            lbl_CPF.TabIndex = 6;
            lbl_CPF.Text = "CPF:";
            // 
            // lbl_Nome_Completo
            // 
            lbl_Nome_Completo.AutoSize = true;
            lbl_Nome_Completo.BackColor = Color.SlateBlue;
            lbl_Nome_Completo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Nome_Completo.ForeColor = Color.White;
            lbl_Nome_Completo.Location = new Point(138, 282);
            lbl_Nome_Completo.Name = "lbl_Nome_Completo";
            lbl_Nome_Completo.Size = new Size(122, 18);
            lbl_Nome_Completo.TabIndex = 9;
            lbl_Nome_Completo.Text = "Nome Completo:";
            // 
            // txb_Nome_Completo
            // 
            txb_Nome_Completo.Location = new Point(138, 304);
            txb_Nome_Completo.Margin = new Padding(3, 4, 3, 4);
            txb_Nome_Completo.Name = "txb_Nome_Completo";
            txb_Nome_Completo.Size = new Size(508, 27);
            txb_Nome_Completo.TabIndex = 10;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.BackColor = Color.SlateBlue;
            lbl_Email.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Email.ForeColor = Color.White;
            lbl_Email.Location = new Point(138, 335);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(49, 18);
            lbl_Email.TabIndex = 11;
            lbl_Email.Text = "Email:";
            // 
            // txb_Email
            // 
            txb_Email.Location = new Point(138, 357);
            txb_Email.Margin = new Padding(3, 4, 3, 4);
            txb_Email.Name = "txb_Email";
            txb_Email.Size = new Size(508, 27);
            txb_Email.TabIndex = 12;
            // 
            // lbl_Telefone
            // 
            lbl_Telefone.AutoSize = true;
            lbl_Telefone.BackColor = Color.SlateBlue;
            lbl_Telefone.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Telefone.ForeColor = Color.White;
            lbl_Telefone.Location = new Point(138, 388);
            lbl_Telefone.Name = "lbl_Telefone";
            lbl_Telefone.Size = new Size(69, 18);
            lbl_Telefone.TabIndex = 13;
            lbl_Telefone.Text = "Telefone:";
            // 
            // txb_Telefone
            // 
            txb_Telefone.Location = new Point(138, 410);
            txb_Telefone.Margin = new Padding(3, 4, 3, 4);
            txb_Telefone.Name = "txb_Telefone";
            txb_Telefone.Size = new Size(251, 27);
            txb_Telefone.TabIndex = 14;
            // 
            // lbl_RG
            // 
            lbl_RG.AutoSize = true;
            lbl_RG.BackColor = Color.SlateBlue;
            lbl_RG.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_RG.ForeColor = Color.White;
            lbl_RG.Location = new Point(395, 229);
            lbl_RG.Name = "lbl_RG";
            lbl_RG.Size = new Size(35, 18);
            lbl_RG.TabIndex = 15;
            lbl_RG.Text = "RG:";
            // 
            // txb_RG
            // 
            txb_RG.Location = new Point(395, 251);
            txb_RG.Margin = new Padding(3, 4, 3, 4);
            txb_RG.Name = "txb_RG";
            txb_RG.Size = new Size(251, 27);
            txb_RG.TabIndex = 16;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.BackColor = Color.SlateBlue;
            btn_Cadastrar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cadastrar.ForeColor = SystemColors.HighlightText;
            btn_Cadastrar.Location = new Point(415, 454);
            btn_Cadastrar.Margin = new Padding(3, 4, 3, 4);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(115, 76);
            btn_Cadastrar.TabIndex = 17;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = false;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = SystemColors.GrayText;
            btn_Voltar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Voltar.ForeColor = SystemColors.HighlightText;
            btn_Voltar.Location = new Point(258, 454);
            btn_Voltar.Margin = new Padding(3, 4, 3, 4);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(115, 76);
            btn_Voltar.TabIndex = 18;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // pct_Imagem_Menu
            // 
            pct_Imagem_Menu.Image = (Image)resources.GetObject("pct_Imagem_Menu.Image");
            pct_Imagem_Menu.Location = new Point(330, 18);
            pct_Imagem_Menu.Margin = new Padding(3, 4, 3, 4);
            pct_Imagem_Menu.Name = "pct_Imagem_Menu";
            pct_Imagem_Menu.Size = new Size(118, 91);
            pct_Imagem_Menu.SizeMode = PictureBoxSizeMode.Zoom;
            pct_Imagem_Menu.TabIndex = 36;
            pct_Imagem_Menu.TabStop = false;
            // 
            // frm_Cadastrar_Funcionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 537);
            Controls.Add(pct_Imagem_Menu);
            Controls.Add(btn_Cadastrar);
            Controls.Add(btn_Voltar);
            Controls.Add(txb_RG);
            Controls.Add(lbl_RG);
            Controls.Add(txb_Telefone);
            Controls.Add(lbl_Telefone);
            Controls.Add(txb_Email);
            Controls.Add(lbl_Email);
            Controls.Add(txb_Nome_Completo);
            Controls.Add(lbl_Nome_Completo);
            Controls.Add(txb_Cargo);
            Controls.Add(txb_CPF);
            Controls.Add(lbl_Cargo);
            Controls.Add(lbl_CPF);
            Controls.Add(lbl_Funcionario);
            Controls.Add(lbl_Cadastrar_Funcionario);
            MaximizeBox = false;
            Name = "frm_Cadastrar_Funcionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechCompany™";
            TopMost = true;
            Load += frm_Cadastrar_Funcionario_Load;
            ((System.ComponentModel.ISupportInitialize)pct_Imagem_Menu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Cadastrar_Funcionario;
        private Label lbl_Funcionario;
        private TextBox txb_Cargo;
        private TextBox txb_CPF;
        private Label lbl_Cargo;
        private Label lbl_CPF;
        private Label lbl_Nome_Completo;
        private TextBox txb_Nome_Completo;
        private Label lbl_Email;
        private TextBox txb_Email;
        private Label lbl_Telefone;
        private TextBox txb_Telefone;
        private Label lbl_RG;
        private TextBox txb_RG;
        private Button btn_Cadastrar;
        private Button btn_Voltar;
        private PictureBox pct_Imagem_Menu;
    }
}