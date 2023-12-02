namespace WinFormsApp1
{
    partial class frm_Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Funcionario));
            btn_Voltar = new Button();
            pictureBox1 = new PictureBox();
            txb_RG = new TextBox();
            lbl_RG = new Label();
            txb_Telefone = new TextBox();
            lbl_Telefone = new Label();
            txb_Email = new TextBox();
            lbl_Email = new Label();
            txb_Nome_Completo = new TextBox();
            lbl_Nome_Completo = new Label();
            txb_Cargo = new TextBox();
            txb_CPF = new TextBox();
            lbl_Cargo = new Label();
            lbl_CPF = new Label();
            lbl_Funcionario = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = SystemColors.GrayText;
            btn_Voltar.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Voltar.ForeColor = SystemColors.HighlightText;
            btn_Voltar.Location = new Point(292, 396);
            btn_Voltar.Margin = new Padding(3, 4, 3, 4);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(115, 76);
            btn_Voltar.TabIndex = 55;
            btn_Voltar.Text = "Voltar";
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(289, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // txb_RG
            // 
            txb_RG.Location = new Point(351, 186);
            txb_RG.Margin = new Padding(3, 4, 3, 4);
            txb_RG.Name = "txb_RG";
            txb_RG.Size = new Size(251, 27);
            txb_RG.TabIndex = 69;
            // 
            // lbl_RG
            // 
            lbl_RG.AutoSize = true;
            lbl_RG.BackColor = Color.SlateBlue;
            lbl_RG.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_RG.ForeColor = Color.White;
            lbl_RG.Location = new Point(351, 164);
            lbl_RG.Name = "lbl_RG";
            lbl_RG.Size = new Size(35, 18);
            lbl_RG.TabIndex = 68;
            lbl_RG.Text = "RG:";
            // 
            // txb_Telefone
            // 
            txb_Telefone.Location = new Point(94, 345);
            txb_Telefone.Margin = new Padding(3, 4, 3, 4);
            txb_Telefone.Name = "txb_Telefone";
            txb_Telefone.Size = new Size(251, 27);
            txb_Telefone.TabIndex = 67;
            // 
            // lbl_Telefone
            // 
            lbl_Telefone.AutoSize = true;
            lbl_Telefone.BackColor = Color.SlateBlue;
            lbl_Telefone.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Telefone.ForeColor = Color.White;
            lbl_Telefone.Location = new Point(94, 323);
            lbl_Telefone.Name = "lbl_Telefone";
            lbl_Telefone.Size = new Size(69, 18);
            lbl_Telefone.TabIndex = 66;
            lbl_Telefone.Text = "Telefone:";
            // 
            // txb_Email
            // 
            txb_Email.Location = new Point(94, 292);
            txb_Email.Margin = new Padding(3, 4, 3, 4);
            txb_Email.Name = "txb_Email";
            txb_Email.Size = new Size(508, 27);
            txb_Email.TabIndex = 65;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.BackColor = Color.SlateBlue;
            lbl_Email.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Email.ForeColor = Color.White;
            lbl_Email.Location = new Point(94, 270);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(49, 18);
            lbl_Email.TabIndex = 64;
            lbl_Email.Text = "Email:";
            // 
            // txb_Nome_Completo
            // 
            txb_Nome_Completo.Location = new Point(94, 239);
            txb_Nome_Completo.Margin = new Padding(3, 4, 3, 4);
            txb_Nome_Completo.Name = "txb_Nome_Completo";
            txb_Nome_Completo.Size = new Size(508, 27);
            txb_Nome_Completo.TabIndex = 63;
            // 
            // lbl_Nome_Completo
            // 
            lbl_Nome_Completo.AutoSize = true;
            lbl_Nome_Completo.BackColor = Color.SlateBlue;
            lbl_Nome_Completo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Nome_Completo.ForeColor = Color.White;
            lbl_Nome_Completo.Location = new Point(94, 217);
            lbl_Nome_Completo.Name = "lbl_Nome_Completo";
            lbl_Nome_Completo.Size = new Size(122, 18);
            lbl_Nome_Completo.TabIndex = 62;
            lbl_Nome_Completo.Text = "Nome Completo:";
            // 
            // txb_Cargo
            // 
            txb_Cargo.Location = new Point(351, 345);
            txb_Cargo.Margin = new Padding(3, 4, 3, 4);
            txb_Cargo.Name = "txb_Cargo";
            txb_Cargo.Size = new Size(251, 27);
            txb_Cargo.TabIndex = 60;
            // 
            // txb_CPF
            // 
            txb_CPF.Location = new Point(94, 186);
            txb_CPF.Margin = new Padding(3, 4, 3, 4);
            txb_CPF.Name = "txb_CPF";
            txb_CPF.Size = new Size(251, 27);
            txb_CPF.TabIndex = 61;
            // 
            // lbl_Cargo
            // 
            lbl_Cargo.AutoSize = true;
            lbl_Cargo.BackColor = Color.SlateBlue;
            lbl_Cargo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Cargo.ForeColor = Color.White;
            lbl_Cargo.Location = new Point(351, 323);
            lbl_Cargo.Name = "lbl_Cargo";
            lbl_Cargo.Size = new Size(53, 18);
            lbl_Cargo.TabIndex = 58;
            lbl_Cargo.Text = "Cargo:";
            // 
            // lbl_CPF
            // 
            lbl_CPF.AutoSize = true;
            lbl_CPF.BackColor = Color.SlateBlue;
            lbl_CPF.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_CPF.ForeColor = Color.White;
            lbl_CPF.Location = new Point(94, 164);
            lbl_CPF.Name = "lbl_CPF";
            lbl_CPF.Size = new Size(42, 18);
            lbl_CPF.TabIndex = 59;
            lbl_CPF.Text = "CPF:";
            // 
            // lbl_Funcionario
            // 
            lbl_Funcionario.AutoSize = true;
            lbl_Funcionario.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Funcionario.ForeColor = Color.SlateBlue;
            lbl_Funcionario.Location = new Point(94, 127);
            lbl_Funcionario.Name = "lbl_Funcionario";
            lbl_Funcionario.Size = new Size(331, 27);
            lbl_Funcionario.TabIndex = 57;
            lbl_Funcionario.Text = "Informações do Funcionário:";
            // 
            // frm_Funcionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(691, 491);
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
            Controls.Add(pictureBox1);
            Controls.Add(btn_Voltar);
            MaximizeBox = false;
            Name = "frm_Funcionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechCompany™";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Voltar;
        private PictureBox pictureBox1;
        private TextBox txb_RG;
        private Label lbl_RG;
        private TextBox txb_Telefone;
        private Label lbl_Telefone;
        private TextBox txb_Email;
        private Label lbl_Email;
        private TextBox txb_Nome_Completo;
        private Label lbl_Nome_Completo;
        private TextBox txb_Cargo;
        private TextBox txb_CPF;
        private Label lbl_Cargo;
        private Label lbl_CPF;
        private Label lbl_Funcionario;
    }
}