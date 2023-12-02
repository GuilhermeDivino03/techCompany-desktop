namespace WinFormsApp1
{
    partial class frm_Visualizar_Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Visualizar_Funcionario));
            pct_Imagem_Menu = new PictureBox();
            lbl_Visualizar_Funcionario = new Label();
            lbl_Funcionario = new Label();
            txb_Nome_Completo = new TextBox();
            lbl_Nome_Completo = new Label();
            txb_CPF = new TextBox();
            lbl_CPF = new Label();
            btn_Visualizar = new Button();
            btn_Voltar = new Button();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)pct_Imagem_Menu).BeginInit();
            SuspendLayout();
            // 
            // pct_Imagem_Menu
            // 
            pct_Imagem_Menu.Image = (Image)resources.GetObject("pct_Imagem_Menu.Image");
            pct_Imagem_Menu.Location = new Point(273, 13);
            pct_Imagem_Menu.Margin = new Padding(3, 4, 3, 4);
            pct_Imagem_Menu.Name = "pct_Imagem_Menu";
            pct_Imagem_Menu.Size = new Size(118, 91);
            pct_Imagem_Menu.SizeMode = PictureBoxSizeMode.Zoom;
            pct_Imagem_Menu.TabIndex = 38;
            pct_Imagem_Menu.TabStop = false;
            // 
            // lbl_Visualizar_Funcionario
            // 
            lbl_Visualizar_Funcionario.AutoSize = true;
            lbl_Visualizar_Funcionario.Font = new Font("Impact", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Visualizar_Funcionario.ForeColor = Color.SlateBlue;
            lbl_Visualizar_Funcionario.Location = new Point(112, 108);
            lbl_Visualizar_Funcionario.Name = "lbl_Visualizar_Funcionario";
            lbl_Visualizar_Funcionario.Size = new Size(446, 54);
            lbl_Visualizar_Funcionario.TabIndex = 39;
            lbl_Visualizar_Funcionario.Text = "Visualizar Funcionario";
            // 
            // lbl_Funcionario
            // 
            lbl_Funcionario.AutoSize = true;
            lbl_Funcionario.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Funcionario.ForeColor = Color.SlateBlue;
            lbl_Funcionario.Location = new Point(78, 173);
            lbl_Funcionario.Name = "lbl_Funcionario";
            lbl_Funcionario.Size = new Size(261, 21);
            lbl_Funcionario.TabIndex = 40;
            lbl_Funcionario.Text = "Informações do Funcionário:";
            // 
            // txb_Nome_Completo
            // 
            txb_Nome_Completo.Location = new Point(78, 223);
            txb_Nome_Completo.Margin = new Padding(3, 4, 3, 4);
            txb_Nome_Completo.Name = "txb_Nome_Completo";
            txb_Nome_Completo.Size = new Size(385, 27);
            txb_Nome_Completo.TabIndex = 46;
            // 
            // lbl_Nome_Completo
            // 
            lbl_Nome_Completo.AutoSize = true;
            lbl_Nome_Completo.BackColor = Color.SlateBlue;
            lbl_Nome_Completo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Nome_Completo.ForeColor = Color.White;
            lbl_Nome_Completo.Location = new Point(78, 201);
            lbl_Nome_Completo.Name = "lbl_Nome_Completo";
            lbl_Nome_Completo.Size = new Size(122, 18);
            lbl_Nome_Completo.TabIndex = 45;
            lbl_Nome_Completo.Text = "Nome Completo:";
            // 
            // txb_CPF
            // 
            txb_CPF.Location = new Point(78, 273);
            txb_CPF.Margin = new Padding(3, 4, 3, 4);
            txb_CPF.Name = "txb_CPF";
            txb_CPF.Size = new Size(251, 27);
            txb_CPF.TabIndex = 44;
            // 
            // lbl_CPF
            // 
            lbl_CPF.AutoSize = true;
            lbl_CPF.BackColor = Color.SlateBlue;
            lbl_CPF.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_CPF.ForeColor = Color.White;
            lbl_CPF.Location = new Point(78, 252);
            lbl_CPF.Name = "lbl_CPF";
            lbl_CPF.Size = new Size(42, 18);
            lbl_CPF.TabIndex = 42;
            lbl_CPF.Text = "CPF:";
            // 
            // btn_Visualizar
            // 
            btn_Visualizar.BackColor = Color.SlateBlue;
            btn_Visualizar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Visualizar.ForeColor = SystemColors.HighlightText;
            btn_Visualizar.Location = new Point(343, 578);
            btn_Visualizar.Margin = new Padding(3, 4, 3, 4);
            btn_Visualizar.Name = "btn_Visualizar";
            btn_Visualizar.Size = new Size(115, 76);
            btn_Visualizar.TabIndex = 53;
            btn_Visualizar.Text = "Visualizar";
            btn_Visualizar.UseVisualStyleBackColor = false;
            btn_Visualizar.Click += btn_Visualizar_Click;
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = SystemColors.GrayText;
            btn_Voltar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Voltar.ForeColor = SystemColors.HighlightText;
            btn_Voltar.Location = new Point(180, 578);
            btn_Voltar.Margin = new Padding(3, 4, 3, 4);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(115, 76);
            btn_Voltar.TabIndex = 54;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(78, 325);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(500, 235);
            listView1.TabIndex = 55;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // frm_Visualizar_Funcionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(659, 680);
            Controls.Add(listView1);
            Controls.Add(btn_Visualizar);
            Controls.Add(btn_Voltar);
            Controls.Add(txb_Nome_Completo);
            Controls.Add(lbl_Nome_Completo);
            Controls.Add(txb_CPF);
            Controls.Add(lbl_CPF);
            Controls.Add(lbl_Funcionario);
            Controls.Add(lbl_Visualizar_Funcionario);
            Controls.Add(pct_Imagem_Menu);
            MaximizeBox = false;
            Name = "frm_Visualizar_Funcionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechCompany™";
            ((System.ComponentModel.ISupportInitialize)pct_Imagem_Menu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pct_Imagem_Menu;
        private Label lbl_Visualizar_Funcionario;
        private Label lbl_Funcionario;
        private TextBox txb_Nome_Completo;
        private Label lbl_Nome_Completo;
        private TextBox txb_CPF;
        private Label lbl_CPF;
        private Button btn_Visualizar;
        private Button btn_Voltar;
        private ListView listView1;
    }
}