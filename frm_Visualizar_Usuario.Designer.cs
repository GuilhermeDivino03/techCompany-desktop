namespace DesktopTechCompany36
{
    partial class frm_Visualizar_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Visualizar_Usuario));
            listView1 = new ListView();
            lbl_Funcionario = new Label();
            btn_Visualizar = new Button();
            btn_Voltar = new Button();
            txb_CPF = new TextBox();
            lbl_Visualizar_Funcionario = new Label();
            pct_Imagem_Menu = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pct_Imagem_Menu).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(199, 282);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(500, 235);
            listView1.TabIndex = 78;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_Funcionario
            // 
            lbl_Funcionario.AutoSize = true;
            lbl_Funcionario.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Funcionario.ForeColor = Color.SlateBlue;
            lbl_Funcionario.Location = new Point(199, 200);
            lbl_Funcionario.Name = "lbl_Funcionario";
            lbl_Funcionario.Size = new Size(125, 21);
            lbl_Funcionario.TabIndex = 77;
            lbl_Funcionario.Text = "Digite o CPF:";
            // 
            // btn_Visualizar
            // 
            btn_Visualizar.BackColor = Color.SlateBlue;
            btn_Visualizar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Visualizar.ForeColor = SystemColors.HighlightText;
            btn_Visualizar.Location = new Point(536, 543);
            btn_Visualizar.Margin = new Padding(3, 4, 3, 4);
            btn_Visualizar.Name = "btn_Visualizar";
            btn_Visualizar.Size = new Size(115, 76);
            btn_Visualizar.TabIndex = 75;
            btn_Visualizar.Text = "Visualizar";
            btn_Visualizar.UseVisualStyleBackColor = false;
            btn_Visualizar.Click += btn_Visualizar_Click;
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = SystemColors.GrayText;
            btn_Voltar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Voltar.ForeColor = SystemColors.HighlightText;
            btn_Voltar.Location = new Point(250, 543);
            btn_Voltar.Margin = new Padding(3, 4, 3, 4);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(115, 76);
            btn_Voltar.TabIndex = 76;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // txb_CPF
            // 
            txb_CPF.Location = new Point(199, 225);
            txb_CPF.Margin = new Padding(3, 4, 3, 4);
            txb_CPF.Name = "txb_CPF";
            txb_CPF.Size = new Size(251, 27);
            txb_CPF.TabIndex = 74;
            // 
            // lbl_Visualizar_Funcionario
            // 
            lbl_Visualizar_Funcionario.AutoSize = true;
            lbl_Visualizar_Funcionario.Font = new Font("Impact", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Visualizar_Funcionario.ForeColor = Color.SlateBlue;
            lbl_Visualizar_Funcionario.Location = new Point(288, 118);
            lbl_Visualizar_Funcionario.Name = "lbl_Visualizar_Funcionario";
            lbl_Visualizar_Funcionario.Size = new Size(367, 54);
            lbl_Visualizar_Funcionario.TabIndex = 73;
            lbl_Visualizar_Funcionario.Text = "Visualizar Usuario";
            // 
            // pct_Imagem_Menu
            // 
            pct_Imagem_Menu.Image = (Image)resources.GetObject("pct_Imagem_Menu.Image");
            pct_Imagem_Menu.Location = new Point(394, 23);
            pct_Imagem_Menu.Margin = new Padding(3, 4, 3, 4);
            pct_Imagem_Menu.Name = "pct_Imagem_Menu";
            pct_Imagem_Menu.Size = new Size(118, 91);
            pct_Imagem_Menu.SizeMode = PictureBoxSizeMode.Zoom;
            pct_Imagem_Menu.TabIndex = 72;
            pct_Imagem_Menu.TabStop = false;
            // 
            // frm_Visualizar_Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(885, 653);
            Controls.Add(listView1);
            Controls.Add(lbl_Funcionario);
            Controls.Add(btn_Visualizar);
            Controls.Add(btn_Voltar);
            Controls.Add(txb_CPF);
            Controls.Add(lbl_Visualizar_Funcionario);
            Controls.Add(pct_Imagem_Menu);
            Name = "frm_Visualizar_Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechCompany™";
            ((System.ComponentModel.ISupportInitialize)pct_Imagem_Menu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label lbl_Funcionario;
        private Button btn_Visualizar;
        private Button btn_Voltar;
        private TextBox txb_CPF;
        private Label lbl_Visualizar_Funcionario;
        private PictureBox pct_Imagem_Menu;
    }
}