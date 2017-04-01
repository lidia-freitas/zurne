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
            this.gbPessoaJuridica = new System.Windows.Forms.GroupBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.textCpf = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbPessoaFiscia.SuspendLayout();
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
            this.rbPessoaFisica.CheckedChanged += new System.EventHandler(this.rbPessoaFisica_CheckedChanged);
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
            this.rbPessoaJuridica.CheckedChanged += new System.EventHandler(this.rbPessoaJuridica_CheckedChanged);
            // 
            // gbPessoaFiscia
            // 
            this.gbPessoaFiscia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPessoaFiscia.Controls.Add(this.btnSalvar);
            this.gbPessoaFiscia.Controls.Add(this.textEndereco);
            this.gbPessoaFiscia.Controls.Add(this.textEmail);
            this.gbPessoaFiscia.Controls.Add(this.textCpf);
            this.gbPessoaFiscia.Controls.Add(this.lbEndereco);
            this.gbPessoaFiscia.Controls.Add(this.lbEmail);
            this.gbPessoaFiscia.Controls.Add(this.lbCpf);
            this.gbPessoaFiscia.Controls.Add(this.textNome);
            this.gbPessoaFiscia.Controls.Add(this.lbNome);
            this.gbPessoaFiscia.Location = new System.Drawing.Point(12, 60);
            this.gbPessoaFiscia.Name = "gbPessoaFiscia";
            this.gbPessoaFiscia.Size = new System.Drawing.Size(1120, 550);
            this.gbPessoaFiscia.TabIndex = 2;
            this.gbPessoaFiscia.TabStop = false;
            this.gbPessoaFiscia.Text = "Pessoa Fisica";
            this.gbPessoaFiscia.Visible = false;
            this.gbPessoaFiscia.Enter += new System.EventHandler(this.gbPessoalFiscia_Enter);
            // 
            // gbPessoaJuridica
            // 
            this.gbPessoaJuridica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPessoaJuridica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbPessoaJuridica.Location = new System.Drawing.Point(12, 60);
            this.gbPessoaJuridica.Name = "gbPessoaJuridica";
            this.gbPessoaJuridica.Size = new System.Drawing.Size(1120, 550);
            this.gbPessoaJuridica.TabIndex = 0;
            this.gbPessoaJuridica.TabStop = false;
            this.gbPessoaJuridica.Text = "Pessoa Juridica";
            this.gbPessoaJuridica.Enter += new System.EventHandler(this.gbPessoaJuridica_Enter);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(22, 41);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(25, 70);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(369, 20);
            this.textNome.TabIndex = 1;
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(25, 120);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(27, 13);
            this.lbCpf.TabIndex = 2;
            this.lbCpf.Text = "CPF";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(25, 205);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "E-mail";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(25, 293);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(53, 13);
            this.lbEndereco.TabIndex = 4;
            this.lbEndereco.Text = "Endereço";
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(25, 137);
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(138, 20);
            this.textCpf.TabIndex = 5;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(28, 222);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(191, 20);
            this.textEmail.TabIndex = 6;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(28, 310);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(595, 20);
            this.textEndereco.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(1039, 521);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 628);
            this.Controls.Add(this.gbPessoaFiscia);
            this.Controls.Add(this.rbPessoaJuridica);
            this.Controls.Add(this.rbPessoaFisica);
            this.Controls.Add(this.gbPessoaJuridica);
            this.Name = "frmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.gbPessoaFiscia.ResumeLayout(false);
            this.gbPessoaFiscia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPessoaFisica;
        private System.Windows.Forms.RadioButton rbPessoaJuridica;
        private System.Windows.Forms.GroupBox gbPessoaFiscia;
        private System.Windows.Forms.GroupBox gbPessoaJuridica;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textCpf;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Button btnSalvar;
    }
}