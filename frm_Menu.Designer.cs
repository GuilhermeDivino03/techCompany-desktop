namespace WinFormsApp1
{
    partial class frm_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            lbl_Menu = new Label();
            lbl_Cadastros = new Label();
            btn_Cadastrar_Funcionarios = new Button();
            lbl_Visualizacoes = new Label();
            btn_Cadastrar_Folhas = new Button();
            btn_Visualizar_Folhas = new Button();
            btn_Visualizar_Funcionarios = new Button();
            pct_Imagem_Menu = new PictureBox();
            btn_Cadastrar_Usuario = new Button();
            btn_Visualizar_Usuario = new Button();
            btn_Logout = new Button();
            ((System.ComponentModel.ISupportInitialize)pct_Imagem_Menu).BeginInit();
            SuspendLayout();
            // 
            // lbl_Menu
            // 
            lbl_Menu.AutoSize = true;
            lbl_Menu.BackColor = Color.Black;
            lbl_Menu.Font = new Font("Impact", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Menu.ForeColor = Color.SlateBlue;
            lbl_Menu.Location = new Point(276, 117);
            lbl_Menu.Name = "lbl_Menu";
            lbl_Menu.Size = new Size(137, 59);
            lbl_Menu.TabIndex = 1;
            lbl_Menu.Text = "Menu";
            lbl_Menu.TextAlign = ContentAlignment.TopCenter;
            lbl_Menu.UseMnemonic = false;
            lbl_Menu.Click += label1_Click;
            // 
            // lbl_Cadastros
            // 
            lbl_Cadastros.AutoSize = true;
            lbl_Cadastros.BackColor = Color.Black;
            lbl_Cadastros.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Cadastros.ForeColor = Color.SlateBlue;
            lbl_Cadastros.ImageAlign = ContentAlignment.TopLeft;
            lbl_Cadastros.Location = new Point(62, 165);
            lbl_Cadastros.Name = "lbl_Cadastros";
            lbl_Cadastros.Size = new Size(128, 27);
            lbl_Cadastros.TabIndex = 33;
            lbl_Cadastros.Text = "Cadastrar:";
            lbl_Cadastros.Click += label1_Click_1;
            // 
            // btn_Cadastrar_Funcionarios
            // 
            btn_Cadastrar_Funcionarios.BackColor = Color.SlateBlue;
            btn_Cadastrar_Funcionarios.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cadastrar_Funcionarios.ForeColor = Color.White;
            btn_Cadastrar_Funcionarios.Location = new Point(62, 210);
            btn_Cadastrar_Funcionarios.Margin = new Padding(3, 4, 3, 4);
            btn_Cadastrar_Funcionarios.Name = "btn_Cadastrar_Funcionarios";
            btn_Cadastrar_Funcionarios.Size = new Size(147, 92);
            btn_Cadastrar_Funcionarios.TabIndex = 3;
            btn_Cadastrar_Funcionarios.Text = "Cadastrar Funcionários";
            btn_Cadastrar_Funcionarios.UseVisualStyleBackColor = false;
            btn_Cadastrar_Funcionarios.Click += btn_Cadastrar_Funcionarios_Click;
            // 
            // lbl_Visualizacoes
            // 
            lbl_Visualizacoes.AutoSize = true;
            lbl_Visualizacoes.BackColor = Color.Black;
            lbl_Visualizacoes.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Visualizacoes.ForeColor = Color.SlateBlue;
            lbl_Visualizacoes.Location = new Point(60, 322);
            lbl_Visualizacoes.Name = "lbl_Visualizacoes";
            lbl_Visualizacoes.Size = new Size(130, 27);
            lbl_Visualizacoes.TabIndex = 34;
            lbl_Visualizacoes.Text = "Visualizar:";
            // 
            // btn_Cadastrar_Folhas
            // 
            btn_Cadastrar_Folhas.BackColor = Color.SlateBlue;
            btn_Cadastrar_Folhas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cadastrar_Folhas.ForeColor = Color.White;
            btn_Cadastrar_Folhas.Location = new Point(271, 210);
            btn_Cadastrar_Folhas.Margin = new Padding(3, 4, 3, 4);
            btn_Cadastrar_Folhas.Name = "btn_Cadastrar_Folhas";
            btn_Cadastrar_Folhas.Size = new Size(147, 92);
            btn_Cadastrar_Folhas.TabIndex = 4;
            btn_Cadastrar_Folhas.Text = "Cadastrar Folhas de Pagameneto ";
            btn_Cadastrar_Folhas.UseVisualStyleBackColor = false;
            btn_Cadastrar_Folhas.Click += btn_Cadastrar_Folhas_Click;
            // 
            // btn_Visualizar_Folhas
            // 
            btn_Visualizar_Folhas.BackColor = Color.SlateBlue;
            btn_Visualizar_Folhas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Visualizar_Folhas.ForeColor = Color.White;
            btn_Visualizar_Folhas.Location = new Point(480, 363);
            btn_Visualizar_Folhas.Margin = new Padding(3, 4, 3, 4);
            btn_Visualizar_Folhas.Name = "btn_Visualizar_Folhas";
            btn_Visualizar_Folhas.Size = new Size(147, 92);
            btn_Visualizar_Folhas.TabIndex = 4;
            btn_Visualizar_Folhas.Text = "Folha de Pagamento";
            btn_Visualizar_Folhas.UseVisualStyleBackColor = false;
            btn_Visualizar_Folhas.Click += btn_Visualizar_Folhas_Click;
            // 
            // btn_Visualizar_Funcionarios
            // 
            btn_Visualizar_Funcionarios.BackColor = Color.SlateBlue;
            btn_Visualizar_Funcionarios.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Visualizar_Funcionarios.ForeColor = Color.White;
            btn_Visualizar_Funcionarios.Location = new Point(271, 363);
            btn_Visualizar_Funcionarios.Margin = new Padding(3, 4, 3, 4);
            btn_Visualizar_Funcionarios.Name = "btn_Visualizar_Funcionarios";
            btn_Visualizar_Funcionarios.Size = new Size(147, 92);
            btn_Visualizar_Funcionarios.TabIndex = 3;
            btn_Visualizar_Funcionarios.Text = "Funcionários";
            btn_Visualizar_Funcionarios.UseVisualStyleBackColor = false;
            btn_Visualizar_Funcionarios.Click += btn_Visualizar_Funcionarios_Click;
            // 
            // pct_Imagem_Menu
            // 
            pct_Imagem_Menu.Image = (Image)resources.GetObject("pct_Imagem_Menu.Image");
            pct_Imagem_Menu.Location = new Point(285, 1);
            pct_Imagem_Menu.Margin = new Padding(3, 4, 3, 4);
            pct_Imagem_Menu.Name = "pct_Imagem_Menu";
            pct_Imagem_Menu.Size = new Size(118, 91);
            pct_Imagem_Menu.SizeMode = PictureBoxSizeMode.Zoom;
            pct_Imagem_Menu.TabIndex = 37;
            pct_Imagem_Menu.TabStop = false;
            // 
            // btn_Cadastrar_Usuario
            // 
            btn_Cadastrar_Usuario.BackColor = Color.SlateBlue;
            btn_Cadastrar_Usuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cadastrar_Usuario.ForeColor = Color.White;
            btn_Cadastrar_Usuario.Location = new Point(480, 210);
            btn_Cadastrar_Usuario.Margin = new Padding(3, 4, 3, 4);
            btn_Cadastrar_Usuario.Name = "btn_Cadastrar_Usuario";
            btn_Cadastrar_Usuario.Size = new Size(147, 92);
            btn_Cadastrar_Usuario.TabIndex = 38;
            btn_Cadastrar_Usuario.Text = "Cadastrar Usuario";
            btn_Cadastrar_Usuario.UseVisualStyleBackColor = false;
            btn_Cadastrar_Usuario.Click += btn_Cadastrar_Usuario_Click;
            // 
            // btn_Visualizar_Usuario
            // 
            btn_Visualizar_Usuario.BackColor = Color.SlateBlue;
            btn_Visualizar_Usuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Visualizar_Usuario.ForeColor = Color.White;
            btn_Visualizar_Usuario.Location = new Point(62, 363);
            btn_Visualizar_Usuario.Margin = new Padding(3, 4, 3, 4);
            btn_Visualizar_Usuario.Name = "btn_Visualizar_Usuario";
            btn_Visualizar_Usuario.Size = new Size(147, 92);
            btn_Visualizar_Usuario.TabIndex = 39;
            btn_Visualizar_Usuario.Text = "Visualizar usuario";
            btn_Visualizar_Usuario.UseVisualStyleBackColor = false;
            btn_Visualizar_Usuario.Click += btn_Visualizar_Usuario_Click;
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
            btn_Logout.TabIndex = 40;
            btn_Logout.Text = "Logout";
            btn_Logout.UseVisualStyleBackColor = false;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // frm_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(687, 479);
            Controls.Add(btn_Logout);
            Controls.Add(btn_Visualizar_Usuario);
            Controls.Add(btn_Cadastrar_Usuario);
            Controls.Add(pct_Imagem_Menu);
            Controls.Add(lbl_Visualizacoes);
            Controls.Add(btn_Visualizar_Folhas);
            Controls.Add(btn_Cadastrar_Folhas);
            Controls.Add(btn_Visualizar_Funcionarios);
            Controls.Add(btn_Cadastrar_Funcionarios);
            Controls.Add(lbl_Cadastros);
            Controls.Add(lbl_Menu);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frm_Menu";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechCompany™";
            TopMost = true;
            Load += frm_Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pct_Imagem_Menu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Menu;
        private Label lbl_Cadastros;
        private Button btn_Cadastrar_Funcionarios;
        private Label lbl_Visualizacoes;
        private Button btn_Cadastrar_Folhas;
        private Button btn_Visualizar_Folhas;
        private Button btn_Visualizar_Funcionarios;
        private PictureBox pct_Imagem_Menu;
        private Button btn_Cadastrar_Usuario;
        private Button btn_Visualizar_Usuario;
        private Button btn_Logout;
    }
}