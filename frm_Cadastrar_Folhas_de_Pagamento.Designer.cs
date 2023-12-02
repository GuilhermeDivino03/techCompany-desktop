namespace WinFormsApp1
{
    partial class frm_Cadastrar_Folhas_de_Pagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cadastrar_Folhas_de_Pagamento));
            lbl_Cadastrar = new Label();
            lbl_CPF = new Label();
            txb_CPF = new TextBox();
            lbl_Horas_Trabalhadas = new Label();
            lbl_Valor_Vale_Transporte = new Label();
            txb_Horas_Trabalhadas = new TextBox();
            txb_Valor_Hora = new TextBox();
            lbl_Beneficios_Descontos = new Label();
            btn_Voltar = new Button();
            btn_Cadastrar = new Button();
            pct_Imagem_Menu = new PictureBox();
            lbl_Funcionario = new Label();
            ((System.ComponentModel.ISupportInitialize)pct_Imagem_Menu).BeginInit();
            SuspendLayout();
            // 
            // lbl_Cadastrar
            // 
            lbl_Cadastrar.AutoSize = true;
            lbl_Cadastrar.Font = new Font("Impact", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Cadastrar.ForeColor = Color.SlateBlue;
            lbl_Cadastrar.Location = new Point(42, 103);
            lbl_Cadastrar.Name = "lbl_Cadastrar";
            lbl_Cadastrar.Size = new Size(621, 54);
            lbl_Cadastrar.TabIndex = 0;
            lbl_Cadastrar.Text = "Cadastrar Folhas de Pagamento";
            // 
            // lbl_CPF
            // 
            lbl_CPF.AutoSize = true;
            lbl_CPF.BackColor = Color.SlateBlue;
            lbl_CPF.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_CPF.ForeColor = Color.White;
            lbl_CPF.Location = new Point(219, 210);
            lbl_CPF.Name = "lbl_CPF";
            lbl_CPF.Size = new Size(42, 18);
            lbl_CPF.TabIndex = 3;
            lbl_CPF.Text = "CPF:";
            // 
            // txb_CPF
            // 
            txb_CPF.BackColor = SystemColors.Window;
            txb_CPF.ForeColor = SystemColors.WindowText;
            txb_CPF.Location = new Point(219, 232);
            txb_CPF.Margin = new Padding(3, 4, 3, 4);
            txb_CPF.Name = "txb_CPF";
            txb_CPF.Size = new Size(251, 27);
            txb_CPF.TabIndex = 4;
            txb_CPF.TextChanged += textBox1_TextChanged;
            // 
            // lbl_Horas_Trabalhadas
            // 
            lbl_Horas_Trabalhadas.AutoSize = true;
            lbl_Horas_Trabalhadas.BackColor = Color.SlateBlue;
            lbl_Horas_Trabalhadas.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Horas_Trabalhadas.ForeColor = Color.White;
            lbl_Horas_Trabalhadas.Location = new Point(219, 279);
            lbl_Horas_Trabalhadas.Name = "lbl_Horas_Trabalhadas";
            lbl_Horas_Trabalhadas.Size = new Size(187, 18);
            lbl_Horas_Trabalhadas.TabIndex = 3;
            lbl_Horas_Trabalhadas.Text = "Horas trabalhadas no mês:";
            // 
            // lbl_Valor_Vale_Transporte
            // 
            lbl_Valor_Vale_Transporte.AutoSize = true;
            lbl_Valor_Vale_Transporte.BackColor = Color.SlateBlue;
            lbl_Valor_Vale_Transporte.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Valor_Vale_Transporte.ForeColor = Color.White;
            lbl_Valor_Vale_Transporte.Location = new Point(219, 346);
            lbl_Valor_Vale_Transporte.Name = "lbl_Valor_Vale_Transporte";
            lbl_Valor_Vale_Transporte.Size = new Size(172, 18);
            lbl_Valor_Vale_Transporte.TabIndex = 3;
            lbl_Valor_Vale_Transporte.Text = "Valor da hora trabalhada:";
            // 
            // txb_Horas_Trabalhadas
            // 
            txb_Horas_Trabalhadas.Location = new Point(219, 301);
            txb_Horas_Trabalhadas.Margin = new Padding(3, 4, 3, 4);
            txb_Horas_Trabalhadas.Name = "txb_Horas_Trabalhadas";
            txb_Horas_Trabalhadas.Size = new Size(251, 27);
            txb_Horas_Trabalhadas.TabIndex = 4;
            txb_Horas_Trabalhadas.TextChanged += textBox1_TextChanged;
            // 
            // txb_Valor_Hora
            // 
            txb_Valor_Hora.Location = new Point(219, 368);
            txb_Valor_Hora.Margin = new Padding(3, 4, 3, 4);
            txb_Valor_Hora.Name = "txb_Valor_Hora";
            txb_Valor_Hora.Size = new Size(251, 27);
            txb_Valor_Hora.TabIndex = 4;
            txb_Valor_Hora.TextChanged += textBox1_TextChanged;
            // 
            // lbl_Beneficios_Descontos
            // 
            lbl_Beneficios_Descontos.AutoSize = true;
            lbl_Beneficios_Descontos.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Beneficios_Descontos.ForeColor = Color.SlateBlue;
            lbl_Beneficios_Descontos.Location = new Point(119, 639);
            lbl_Beneficios_Descontos.Name = "lbl_Beneficios_Descontos";
            lbl_Beneficios_Descontos.Size = new Size(0, 21);
            lbl_Beneficios_Descontos.TabIndex = 1;
            lbl_Beneficios_Descontos.Click += lbl_Funcionario_Click;
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = SystemColors.GrayText;
            btn_Voltar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Voltar.ForeColor = SystemColors.HighlightText;
            btn_Voltar.Location = new Point(219, 493);
            btn_Voltar.Margin = new Padding(3, 4, 3, 4);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(115, 76);
            btn_Voltar.TabIndex = 6;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.BackColor = Color.SlateBlue;
            btn_Cadastrar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cadastrar.ForeColor = SystemColors.HighlightText;
            btn_Cadastrar.Location = new Point(376, 493);
            btn_Cadastrar.Margin = new Padding(3, 4, 3, 4);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(115, 76);
            btn_Cadastrar.TabIndex = 6;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = false;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // pct_Imagem_Menu
            // 
            pct_Imagem_Menu.Image = (Image)resources.GetObject("pct_Imagem_Menu.Image");
            pct_Imagem_Menu.Location = new Point(288, 8);
            pct_Imagem_Menu.Margin = new Padding(3, 4, 3, 4);
            pct_Imagem_Menu.Name = "pct_Imagem_Menu";
            pct_Imagem_Menu.Size = new Size(118, 91);
            pct_Imagem_Menu.SizeMode = PictureBoxSizeMode.Zoom;
            pct_Imagem_Menu.TabIndex = 37;
            pct_Imagem_Menu.TabStop = false;
            // 
            // lbl_Funcionario
            // 
            lbl_Funcionario.AutoSize = true;
            lbl_Funcionario.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Funcionario.ForeColor = Color.SlateBlue;
            lbl_Funcionario.Location = new Point(87, 166);
            lbl_Funcionario.Name = "lbl_Funcionario";
            lbl_Funcionario.Size = new Size(413, 27);
            lbl_Funcionario.TabIndex = 40;
            lbl_Funcionario.Text = "Informações da folha de pagamento:";
            // 
            // frm_Cadastrar_Folhas_de_Pagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(710, 582);
            Controls.Add(lbl_Funcionario);
            Controls.Add(pct_Imagem_Menu);
            Controls.Add(btn_Cadastrar);
            Controls.Add(btn_Voltar);
            Controls.Add(txb_Valor_Hora);
            Controls.Add(txb_Horas_Trabalhadas);
            Controls.Add(txb_CPF);
            Controls.Add(lbl_Valor_Vale_Transporte);
            Controls.Add(lbl_Horas_Trabalhadas);
            Controls.Add(lbl_CPF);
            Controls.Add(lbl_Beneficios_Descontos);
            Controls.Add(lbl_Cadastrar);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frm_Cadastrar_Folhas_de_Pagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechCompany™";
            TopMost = true;
            Load += frm_Cadastrar_Folhas_Pagamento_Load;
            ((System.ComponentModel.ISupportInitialize)pct_Imagem_Menu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Cadastrar;
        private Label lbl_CPF;
        private Label lbl_Cargo;
        private TextBox txb_CPF;
        private TextBox txb_Cargo;
        private Label lbl_Horas_Trabalhadas;
        private Label lbl_Valor_Vale_Transporte;
        private Label lbl_Desconto_INSS;
        private TextBox txb_Horas_Trabalhadas;
        private TextBox txb_Valor_Hora;
        private TextBox txb_Desconto_INSS;
        private Label lbl_Beneficios_Descontos;
        private Button btn_Voltar;
        private Button btn_Cadastrar;
        private PictureBox pct_Imagem_Menu;
        private Label lbl_Funcionario;
        private TextBox txb_Nome_Completo;
        private Label lbl_Nome_Completo;
    }
}