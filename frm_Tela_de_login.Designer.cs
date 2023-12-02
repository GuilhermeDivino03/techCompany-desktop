namespace DesktopTechCompany12
{
    partial class frm_Tela_de_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Tela_de_login));
            pct_Imagem_Menu = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txb_Usuario = new TextBox();
            txb_Senha = new TextBox();
            lbl_Cadastrar = new Label();
            btn_Entrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pct_Imagem_Menu).BeginInit();
            SuspendLayout();
            // 
            // pct_Imagem_Menu
            // 
            pct_Imagem_Menu.Image = (Image)resources.GetObject("pct_Imagem_Menu.Image");
            pct_Imagem_Menu.Location = new Point(195, 6);
            pct_Imagem_Menu.Margin = new Padding(3, 4, 3, 4);
            pct_Imagem_Menu.Name = "pct_Imagem_Menu";
            pct_Imagem_Menu.Size = new Size(118, 91);
            pct_Imagem_Menu.SizeMode = PictureBoxSizeMode.Zoom;
            pct_Imagem_Menu.TabIndex = 38;
            pct_Imagem_Menu.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SlateBlue;
            label1.ForeColor = Color.White;
            label1.Location = new Point(126, 175);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 39;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SlateBlue;
            label2.ForeColor = Color.White;
            label2.Location = new Point(126, 228);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 40;
            label2.Text = "Senha:";
            // 
            // txb_Usuario
            // 
            txb_Usuario.Location = new Point(126, 198);
            txb_Usuario.Name = "txb_Usuario";
            txb_Usuario.Size = new Size(245, 27);
            txb_Usuario.TabIndex = 41;
            // 
            // txb_Senha
            // 
            txb_Senha.Location = new Point(126, 251);
            txb_Senha.Name = "txb_Senha";
            txb_Senha.Size = new Size(245, 27);
            txb_Senha.TabIndex = 42;
            // 
            // lbl_Cadastrar
            // 
            lbl_Cadastrar.AutoSize = true;
            lbl_Cadastrar.Font = new Font("Impact", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Cadastrar.ForeColor = Color.SlateBlue;
            lbl_Cadastrar.Location = new Point(119, 101);
            lbl_Cadastrar.Name = "lbl_Cadastrar";
            lbl_Cadastrar.Size = new Size(263, 54);
            lbl_Cadastrar.TabIndex = 43;
            lbl_Cadastrar.Text = "Tela de login";
            // 
            // btn_Entrar
            // 
            btn_Entrar.BackColor = Color.SlateBlue;
            btn_Entrar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Entrar.ForeColor = SystemColors.HighlightText;
            btn_Entrar.Location = new Point(198, 301);
            btn_Entrar.Margin = new Padding(3, 4, 3, 4);
            btn_Entrar.Name = "btn_Entrar";
            btn_Entrar.Size = new Size(115, 76);
            btn_Entrar.TabIndex = 54;
            btn_Entrar.Text = "Entrar";
            btn_Entrar.UseVisualStyleBackColor = false;
            btn_Entrar.Click += btn_Entrar_Click;
            // 
            // frm_Tela_de_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(506, 460);
            Controls.Add(btn_Entrar);
            Controls.Add(lbl_Cadastrar);
            Controls.Add(txb_Senha);
            Controls.Add(txb_Usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pct_Imagem_Menu);
            Name = "frm_Tela_de_login";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "Login TechCompany™";
            Load += frm_Tela_de_login_Load;
            ((System.ComponentModel.ISupportInitialize)pct_Imagem_Menu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pct_Imagem_Menu;
        private Label label1;
        private Label label2;
        private TextBox txb_Usuario;
        private TextBox txb_Senha;
        private Label lbl_Cadastrar;
        private Button btn_Entrar;
    }
}