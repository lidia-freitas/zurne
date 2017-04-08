namespace Views
{
    partial class frmCliente
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
            this.rbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.rbPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.gbPessoaFiscia = new System.Windows.Forms.GroupBox();
            this.btnSalvarPessoaFisica = new System.Windows.Forms.Button();
            this.btnVoltarFrmPJ = new System.Windows.Forms.Button();
            this.textEndereco_PF = new System.Windows.Forms.TextBox();
            this.textEmail_PF = new System.Windows.Forms.TextBox();
            this.textCpf_PF = new System.Windows.Forms.TextBox();
            this.lbEndereco_PF = new System.Windows.Forms.Label();
            this.lbEmail_PF = new System.Windows.Forms.Label();
            this.lbCpf_PF = new System.Windows.Forms.Label();
            this.textNome_PF = new System.Windows.Forms.TextBox();
            this.lbNome_PF = new System.Windows.Forms.Label();
            this.gbPessoaJuridica = new System.Windows.Forms.GroupBox();
            this.btnVoltarFrmPF = new System.Windows.Forms.Button();
            this.btnSalvarPessoaJuridica = new System.Windows.Forms.Button();
            this.textEndereco_PJ = new System.Windows.Forms.TextBox();
            this.textEmail_PJ = new System.Windows.Forms.TextBox();
            this.textCnpj_PJ = new System.Windows.Forms.TextBox();
            this.textRazaoSocial_PJ = new System.Windows.Forms.TextBox();
            this.lbEndereco_PJ = new System.Windows.Forms.Label();
            this.lbEmail_PJ = new System.Windows.Forms.Label();
            this.lbCnpj_PJ = new System.Windows.Forms.Label();
            this.lbRazaoSocial_PJ = new System.Windows.Forms.Label();
            this.gbPessoaFiscia.SuspendLayout();
            this.gbPessoaJuridica.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbPessoaFisica
            // 
            this.rbPessoaFisica.AutoSize = true;
            this.rbPessoaFisica.Location = new System.Drawing.Point(12, 22);
            this.rbPessoaFisica.Name = "rbPessoaFisica";
            this.rbPessoaFisica.Size = new System.Drawing.Size(92, 17);
            this.rbPessoaFisica.TabIndex = 0;
            this.rbPessoaFisica.TabStop = true;
            this.rbPessoaFisica.Text = "Pessoa Física";
            this.rbPessoaFisica.UseVisualStyleBackColor = true;
            this.rbPessoaFisica.CheckedChanged += new System.EventHandler(this.mostraFormPessoaFisica);
            // 
            // rbPessoaJuridica
            // 
            this.rbPessoaJuridica.AutoSize = true;
            this.rbPessoaJuridica.Location = new System.Drawing.Point(130, 22);
            this.rbPessoaJuridica.Name = "rbPessoaJuridica";
            this.rbPessoaJuridica.Size = new System.Drawing.Size(101, 17);
            this.rbPessoaJuridica.TabIndex = 1;
            this.rbPessoaJuridica.TabStop = true;
            this.rbPessoaJuridica.Text = "Pessoa Jurídica";
            this.rbPessoaJuridica.UseVisualStyleBackColor = true;
            this.rbPessoaJuridica.CheckedChanged += new System.EventHandler(this.mostraFormPessoaJuridica);
            // 
            // gbPessoaFiscia
            // 
            this.gbPessoaFiscia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPessoaFiscia.Controls.Add(this.btnSalvarPessoaFisica);
            this.gbPessoaFiscia.Controls.Add(this.btnVoltarFrmPJ);
            this.gbPessoaFiscia.Controls.Add(this.textEndereco_PF);
            this.gbPessoaFiscia.Controls.Add(this.textEmail_PF);
            this.gbPessoaFiscia.Controls.Add(this.textCpf_PF);
            this.gbPessoaFiscia.Controls.Add(this.lbEndereco_PF);
            this.gbPessoaFiscia.Controls.Add(this.lbEmail_PF);
            this.gbPessoaFiscia.Controls.Add(this.lbCpf_PF);
            this.gbPessoaFiscia.Controls.Add(this.textNome_PF);
            this.gbPessoaFiscia.Controls.Add(this.lbNome_PF);
            this.gbPessoaFiscia.Location = new System.Drawing.Point(12, 60);
            this.gbPessoaFiscia.Name = "gbPessoaFiscia";
            this.gbPessoaFiscia.Size = new System.Drawing.Size(1120, 550);
            this.gbPessoaFiscia.TabIndex = 2;
            this.gbPessoaFiscia.TabStop = false;
            this.gbPessoaFiscia.Text = "Pessoa Fisica";
            this.gbPessoaFiscia.Visible = false;
            // 
            // btnSalvarPessoaFisica
            // 
            this.btnSalvarPessoaFisica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarPessoaFisica.Location = new System.Drawing.Point(1039, 521);
            this.btnSalvarPessoaFisica.Name = "btnSalvarPessoaFisica";
            this.btnSalvarPessoaFisica.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarPessoaFisica.TabIndex = 8;
            this.btnSalvarPessoaFisica.Text = "Salvar";
            this.btnSalvarPessoaFisica.UseVisualStyleBackColor = true;
            this.btnSalvarPessoaFisica.Click += new System.EventHandler(this.salvarCliente);
            // 
            // btnVoltarFrmPJ
            // 
            this.btnVoltarFrmPJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltarFrmPJ.Location = new System.Drawing.Point(958, 521);
            this.btnVoltarFrmPJ.Name = "btnVoltarFrmPJ";
            this.btnVoltarFrmPJ.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarFrmPJ.TabIndex = 11;
            this.btnVoltarFrmPJ.Text = "Voltar";
            this.btnVoltarFrmPJ.UseVisualStyleBackColor = true;
            this.btnVoltarFrmPJ.Click += new System.EventHandler(this.voltar);
            // 
            // textEndereco_PF
            // 
            this.textEndereco_PF.Location = new System.Drawing.Point(28, 310);
            this.textEndereco_PF.Name = "textEndereco_PF";
            this.textEndereco_PF.Size = new System.Drawing.Size(595, 20);
            this.textEndereco_PF.TabIndex = 7;
            // 
            // textEmail_PF
            // 
            this.textEmail_PF.Location = new System.Drawing.Point(28, 222);
            this.textEmail_PF.Name = "textEmail_PF";
            this.textEmail_PF.Size = new System.Drawing.Size(191, 20);
            this.textEmail_PF.TabIndex = 6;
            // 
            // textCpf_PF
            // 
            this.textCpf_PF.Location = new System.Drawing.Point(25, 137);
            this.textCpf_PF.Name = "textCpf_PF";
            this.textCpf_PF.Size = new System.Drawing.Size(138, 20);
            this.textCpf_PF.TabIndex = 5;
            // 
            // lbEndereco_PF
            // 
            this.lbEndereco_PF.AutoSize = true;
            this.lbEndereco_PF.Location = new System.Drawing.Point(25, 293);
            this.lbEndereco_PF.Name = "lbEndereco_PF";
            this.lbEndereco_PF.Size = new System.Drawing.Size(53, 13);
            this.lbEndereco_PF.TabIndex = 4;
            this.lbEndereco_PF.Text = "Endereço";
            // 
            // lbEmail_PF
            // 
            this.lbEmail_PF.AutoSize = true;
            this.lbEmail_PF.Location = new System.Drawing.Point(25, 205);
            this.lbEmail_PF.Name = "lbEmail_PF";
            this.lbEmail_PF.Size = new System.Drawing.Size(35, 13);
            this.lbEmail_PF.TabIndex = 3;
            this.lbEmail_PF.Text = "E-mail";
            // 
            // lbCpf_PF
            // 
            this.lbCpf_PF.AutoSize = true;
            this.lbCpf_PF.Location = new System.Drawing.Point(25, 120);
            this.lbCpf_PF.Name = "lbCpf_PF";
            this.lbCpf_PF.Size = new System.Drawing.Size(27, 13);
            this.lbCpf_PF.TabIndex = 2;
            this.lbCpf_PF.Text = "CPF";
            // 
            // textNome_PF
            // 
            this.textNome_PF.Location = new System.Drawing.Point(25, 70);
            this.textNome_PF.Name = "textNome_PF";
            this.textNome_PF.Size = new System.Drawing.Size(369, 20);
            this.textNome_PF.TabIndex = 1;
            // 
            // lbNome_PF
            // 
            this.lbNome_PF.AutoSize = true;
            this.lbNome_PF.Location = new System.Drawing.Point(22, 41);
            this.lbNome_PF.Name = "lbNome_PF";
            this.lbNome_PF.Size = new System.Drawing.Size(35, 13);
            this.lbNome_PF.TabIndex = 0;
            this.lbNome_PF.Text = "Nome";
            // 
            // gbPessoaJuridica
            // 
            this.gbPessoaJuridica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPessoaJuridica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbPessoaJuridica.Controls.Add(this.btnVoltarFrmPF);
            this.gbPessoaJuridica.Controls.Add(this.btnSalvarPessoaJuridica);
            this.gbPessoaJuridica.Controls.Add(this.textEndereco_PJ);
            this.gbPessoaJuridica.Controls.Add(this.textEmail_PJ);
            this.gbPessoaJuridica.Controls.Add(this.textCnpj_PJ);
            this.gbPessoaJuridica.Controls.Add(this.textRazaoSocial_PJ);
            this.gbPessoaJuridica.Controls.Add(this.lbEndereco_PJ);
            this.gbPessoaJuridica.Controls.Add(this.lbEmail_PJ);
            this.gbPessoaJuridica.Controls.Add(this.lbCnpj_PJ);
            this.gbPessoaJuridica.Controls.Add(this.lbRazaoSocial_PJ);
            this.gbPessoaJuridica.Location = new System.Drawing.Point(12, 60);
            this.gbPessoaJuridica.Name = "gbPessoaJuridica";
            this.gbPessoaJuridica.Size = new System.Drawing.Size(1120, 550);
            this.gbPessoaJuridica.TabIndex = 0;
            this.gbPessoaJuridica.TabStop = false;
            this.gbPessoaJuridica.Text = "Pessoa Juridica";
            // 
            // btnVoltarFrmPF
            // 
            this.btnVoltarFrmPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltarFrmPF.Location = new System.Drawing.Point(958, 521);
            this.btnVoltarFrmPF.Name = "btnVoltarFrmPF";
            this.btnVoltarFrmPF.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarFrmPF.TabIndex = 12;
            this.btnVoltarFrmPF.Text = "Voltar";
            this.btnVoltarFrmPF.UseVisualStyleBackColor = true;
            this.btnVoltarFrmPF.Click += new System.EventHandler(this.voltar);
            // 
            // btnSalvarPessoaJuridica
            // 
            this.btnSalvarPessoaJuridica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarPessoaJuridica.Location = new System.Drawing.Point(1039, 521);
            this.btnSalvarPessoaJuridica.Name = "btnSalvarPessoaJuridica";
            this.btnSalvarPessoaJuridica.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarPessoaJuridica.TabIndex = 10;
            this.btnSalvarPessoaJuridica.Text = "Salvar";
            this.btnSalvarPessoaJuridica.UseVisualStyleBackColor = true;
            this.btnSalvarPessoaJuridica.Click += new System.EventHandler(this.salvarCliente);
            // 
            // textEndereco_PJ
            // 
            this.textEndereco_PJ.Location = new System.Drawing.Point(25, 337);
            this.textEndereco_PJ.Name = "textEndereco_PJ";
            this.textEndereco_PJ.Size = new System.Drawing.Size(465, 20);
            this.textEndereco_PJ.TabIndex = 9;
            // 
            // textEmail_PJ
            // 
            this.textEmail_PJ.Location = new System.Drawing.Point(25, 236);
            this.textEmail_PJ.Name = "textEmail_PJ";
            this.textEmail_PJ.Size = new System.Drawing.Size(157, 20);
            this.textEmail_PJ.TabIndex = 8;
            // 
            // textCnpj_PJ
            // 
            this.textCnpj_PJ.Location = new System.Drawing.Point(25, 148);
            this.textCnpj_PJ.Name = "textCnpj_PJ";
            this.textCnpj_PJ.Size = new System.Drawing.Size(194, 20);
            this.textCnpj_PJ.TabIndex = 6;
            // 
            // textRazaoSocial_PJ
            // 
            this.textRazaoSocial_PJ.Location = new System.Drawing.Point(25, 70);
            this.textRazaoSocial_PJ.Name = "textRazaoSocial_PJ";
            this.textRazaoSocial_PJ.Size = new System.Drawing.Size(369, 20);
            this.textRazaoSocial_PJ.TabIndex = 5;
            // 
            // lbEndereco_PJ
            // 
            this.lbEndereco_PJ.AutoSize = true;
            this.lbEndereco_PJ.Location = new System.Drawing.Point(22, 309);
            this.lbEndereco_PJ.Name = "lbEndereco_PJ";
            this.lbEndereco_PJ.Size = new System.Drawing.Size(53, 13);
            this.lbEndereco_PJ.TabIndex = 4;
            this.lbEndereco_PJ.Text = "Endereço";
            // 
            // lbEmail_PJ
            // 
            this.lbEmail_PJ.AutoSize = true;
            this.lbEmail_PJ.Location = new System.Drawing.Point(22, 205);
            this.lbEmail_PJ.Name = "lbEmail_PJ";
            this.lbEmail_PJ.Size = new System.Drawing.Size(35, 13);
            this.lbEmail_PJ.TabIndex = 3;
            this.lbEmail_PJ.Text = "E-mail";
            // 
            // lbCnpj_PJ
            // 
            this.lbCnpj_PJ.AutoSize = true;
            this.lbCnpj_PJ.Location = new System.Drawing.Point(22, 121);
            this.lbCnpj_PJ.Name = "lbCnpj_PJ";
            this.lbCnpj_PJ.Size = new System.Drawing.Size(34, 13);
            this.lbCnpj_PJ.TabIndex = 1;
            this.lbCnpj_PJ.Text = "CNPJ";
            // 
            // lbRazaoSocial_PJ
            // 
            this.lbRazaoSocial_PJ.AutoSize = true;
            this.lbRazaoSocial_PJ.Location = new System.Drawing.Point(22, 41);
            this.lbRazaoSocial_PJ.Name = "lbRazaoSocial_PJ";
            this.lbRazaoSocial_PJ.Size = new System.Drawing.Size(70, 13);
            this.lbRazaoSocial_PJ.TabIndex = 0;
            this.lbRazaoSocial_PJ.Text = "Razão Social";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 628);
            this.Controls.Add(this.rbPessoaJuridica);
            this.Controls.Add(this.rbPessoaFisica);
            this.Controls.Add(this.gbPessoaJuridica);
            this.Controls.Add(this.gbPessoaFiscia);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.gbPessoaFiscia.ResumeLayout(false);
            this.gbPessoaFiscia.PerformLayout();
            this.gbPessoaJuridica.ResumeLayout(false);
            this.gbPessoaJuridica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPessoaFisica;
        private System.Windows.Forms.RadioButton rbPessoaJuridica;
        private System.Windows.Forms.GroupBox gbPessoaFiscia;
        private System.Windows.Forms.GroupBox gbPessoaJuridica;
        private System.Windows.Forms.TextBox textNome_PF;
        private System.Windows.Forms.Label lbNome_PF;
        private System.Windows.Forms.TextBox textEndereco_PF;
        private System.Windows.Forms.TextBox textEmail_PF;
        private System.Windows.Forms.TextBox textCpf_PF;
        private System.Windows.Forms.Label lbEndereco_PF;
        private System.Windows.Forms.Label lbEmail_PF;
        private System.Windows.Forms.Label lbCpf_PF;
        private System.Windows.Forms.Button btnSalvarPessoaFisica;
        private System.Windows.Forms.Label lbRazaoSocial_PJ;
        private System.Windows.Forms.Label lbEmail_PJ;
        private System.Windows.Forms.Label lbCnpj_PJ;
        private System.Windows.Forms.Label lbEndereco_PJ;
        private System.Windows.Forms.TextBox textEndereco_PJ;
        private System.Windows.Forms.TextBox textEmail_PJ;
        private System.Windows.Forms.TextBox textCnpj_PJ;
        private System.Windows.Forms.TextBox textRazaoSocial_PJ;
        private System.Windows.Forms.Button btnSalvarPessoaJuridica;
        private System.Windows.Forms.Button btnVoltarFrmPJ;
        private System.Windows.Forms.Button btnVoltarFrmPF;
    }
}