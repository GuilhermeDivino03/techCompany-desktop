namespace WinFormsApp1
{
    partial class frm_Folha_de_Pagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Folha_de_Pagamento));
            pct_Imagem_Menu = new PictureBox();
            btn_Voltar = new Button();
            btn_Imprimir = new Button();
            pct_Holerite_teste = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pct_Imagem_Menu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pct_Holerite_teste).BeginInit();
            SuspendLayout();
            // 
            // pct_Imagem_Menu
            // 
            pct_Imagem_Menu.Image = (Image)resources.GetObject("pct_Imagem_Menu.Image");
            pct_Imagem_Menu.Location = new Point(554, 10);
            pct_Imagem_Menu.Margin = new Padding(3, 4, 3, 4);
            pct_Imagem_Menu.Name = "pct_Imagem_Menu";
            pct_Imagem_Menu.Size = new Size(118, 91);
            pct_Imagem_Menu.SizeMode = PictureBoxSizeMode.Zoom;
            pct_Imagem_Menu.TabIndex = 58;
            pct_Imagem_Menu.TabStop = false;
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = SystemColors.GrayText;
            btn_Voltar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Voltar.ForeColor = SystemColors.HighlightText;
            btn_Voltar.Location = new Point(495, 652);
            btn_Voltar.Margin = new Padding(3, 4, 3, 4);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(115, 76);
            btn_Voltar.TabIndex = 68;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click_1;
            // 
            // btn_Imprimir
            // 
            btn_Imprimir.BackColor = Color.SlateBlue;
            btn_Imprimir.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Imprimir.ForeColor = SystemColors.HighlightText;
            btn_Imprimir.Location = new Point(638, 652);
            btn_Imprimir.Margin = new Padding(3, 4, 3, 4);
            btn_Imprimir.Name = "btn_Imprimir";
            btn_Imprimir.Size = new Size(115, 76);
            btn_Imprimir.TabIndex = 69;
            btn_Imprimir.Text = "Imprimir";
            btn_Imprimir.UseVisualStyleBackColor = false;
            // 
            // pct_Holerite_teste
            // 
            pct_Holerite_teste.Image = (Image)resources.GetObject("pct_Holerite_teste.Image");
            pct_Holerite_teste.Location = new Point(209, 102);
            pct_Holerite_teste.Margin = new Padding(3, 4, 3, 4);
            pct_Holerite_teste.Name = "pct_Holerite_teste";
            pct_Holerite_teste.Size = new Size(790, 542);
            pct_Holerite_teste.SizeMode = PictureBoxSizeMode.Zoom;
            pct_Holerite_teste.TabIndex = 70;
            pct_Holerite_teste.TabStop = false;
            // 
            // frm_Folha_de_Pagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1226, 742);
            Controls.Add(pct_Holerite_teste);
            Controls.Add(btn_Imprimir);
            Controls.Add(btn_Voltar);
            Controls.Add(pct_Imagem_Menu);
            MaximizeBox = false;
            Name = "frm_Folha_de_Pagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechCompany™";
            ((System.ComponentModel.ISupportInitialize)pct_Imagem_Menu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pct_Holerite_teste).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pct_Imagem_Menu;
        private Button btn_Voltar;
        private Button btn_Imprimir;
        private PictureBox pct_Holerite_teste;
    }
}