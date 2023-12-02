namespace DesktopTechCompany1
{
    partial class frm_Exibir_Folha_Tfuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Exibir_Folha_Tfuncionario));
            pct_Imagem_Menu = new PictureBox();
            listView1 = new ListView();
            btn_Voltar = new Button();
            ((System.ComponentModel.ISupportInitialize)pct_Imagem_Menu).BeginInit();
            SuspendLayout();
            // 
            // pct_Imagem_Menu
            // 
            pct_Imagem_Menu.Image = (Image)resources.GetObject("pct_Imagem_Menu.Image");
            pct_Imagem_Menu.Location = new Point(333, 28);
            pct_Imagem_Menu.Margin = new Padding(3, 4, 3, 4);
            pct_Imagem_Menu.Name = "pct_Imagem_Menu";
            pct_Imagem_Menu.Size = new Size(118, 91);
            pct_Imagem_Menu.SizeMode = PictureBoxSizeMode.Zoom;
            pct_Imagem_Menu.TabIndex = 59;
            pct_Imagem_Menu.TabStop = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 142);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 201);
            listView1.TabIndex = 72;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = SystemColors.GrayText;
            btn_Voltar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Voltar.ForeColor = SystemColors.HighlightText;
            btn_Voltar.Location = new Point(333, 385);
            btn_Voltar.Margin = new Padding(3, 4, 3, 4);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(115, 76);
            btn_Voltar.TabIndex = 73;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // frm_Exibir_Folha_Tfuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 493);
            Controls.Add(btn_Voltar);
            Controls.Add(listView1);
            Controls.Add(pct_Imagem_Menu);
            ForeColor = Color.CadetBlue;
            Name = "frm_Exibir_Folha_Tfuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechCompany™";
            Load += frm_Exibir_Folha_Tfuncionario_Load;
            ((System.ComponentModel.ISupportInitialize)pct_Imagem_Menu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pct_Imagem_Menu;
        private ListView listView1;
        private Button btn_Voltar;
    }
}