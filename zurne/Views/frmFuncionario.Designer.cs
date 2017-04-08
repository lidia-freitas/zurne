namespace Views
{
    partial class frmFuncionario
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
            this.lbNome_PF = new System.Windows.Forms.Label();
            this.lbCpf_PF = new System.Windows.Forms.Label();
            this.lbEmail_PF = new System.Windows.Forms.Label();
            this.lbEndereco_PF = new System.Windows.Forms.Label();
            this.textNome_PF = new System.Windows.Forms.TextBox();
            this.textCpf_PF = new System.Windows.Forms.TextBox();
            this.textEmail_PF = new System.Windows.Forms.TextBox();
            this.textEndereco_PF = new System.Windows.Forms.TextBox();
            this.btnSalvarPessoaFisica = new System.Windows.Forms.Button();
            this.btnVoltarFrmPF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNome_PF
            // 
            this.lbNome_PF.AutoSize = true;
            this.lbNome_PF.Location = new System.Drawing.Point(31, 58);
            this.lbNome_PF.Name = "lbNome_PF";
            this.lbNome_PF.Size = new System.Drawing.Size(35, 13);
            this.lbNome_PF.TabIndex = 0;
            this.lbNome_PF.Text = "Nome";
            // 
            // lbCpf_PF
            // 
            this.lbCpf_PF.AutoSize = true;
            this.lbCpf_PF.Location = new System.Drawing.Point(34, 164);
            this.lbCpf_PF.Name = "lbCpf_PF";
            this.lbCpf_PF.Size = new System.Drawing.Size(27, 13);
            this.lbCpf_PF.TabIndex = 1;
            this.lbCpf_PF.Text = "CPF";
            // 
            // lbEmail_PF
            // 
            this.lbEmail_PF.AutoSize = true;
            this.lbEmail_PF.Location = new System.Drawing.Point(34, 293);
            this.lbEmail_PF.Name = "lbEmail_PF";
            this.lbEmail_PF.Size = new System.Drawing.Size(35, 13);
            this.lbEmail_PF.TabIndex = 2;
            this.lbEmail_PF.Text = "E-mail";
            // 
            // lbEndereco_PF
            // 
            this.lbEndereco_PF.AutoSize = true;
            this.lbEndereco_PF.Location = new System.Drawing.Point(34, 423);
            this.lbEndereco_PF.Name = "lbEndereco_PF";
            this.lbEndereco_PF.Size = new System.Drawing.Size(53, 13);
            this.lbEndereco_PF.TabIndex = 3;
            this.lbEndereco_PF.Text = "Endereço";
            // 
            // textNome_PF
            // 
            this.textNome_PF.Location = new System.Drawing.Point(37, 89);
            this.textNome_PF.Name = "textNome_PF";
            this.textNome_PF.Size = new System.Drawing.Size(376, 20);
            this.textNome_PF.TabIndex = 4;
            // 
            // textCpf_PF
            // 
            this.textCpf_PF.Location = new System.Drawing.Point(37, 198);
            this.textCpf_PF.Name = "textCpf_PF";
            this.textCpf_PF.Size = new System.Drawing.Size(160, 20);
            this.textCpf_PF.TabIndex = 5;
            // 
            // textEmail_PF
            // 
            this.textEmail_PF.Location = new System.Drawing.Point(37, 336);
            this.textEmail_PF.Name = "textEmail_PF";
            this.textEmail_PF.Size = new System.Drawing.Size(231, 20);
            this.textEmail_PF.TabIndex = 6;
            // 
            // textEndereco_PF
            // 
            this.textEndereco_PF.Location = new System.Drawing.Point(37, 456);
            this.textEndereco_PF.Name = "textEndereco_PF";
            this.textEndereco_PF.Size = new System.Drawing.Size(407, 20);
            this.textEndereco_PF.TabIndex = 7;
            // 
            // btnSalvarPessoaFisica
            // 
            this.btnSalvarPessoaFisica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarPessoaFisica.Location = new System.Drawing.Point(1135, 605);
            this.btnSalvarPessoaFisica.Name = "btnSalvarPessoaFisica";
            this.btnSalvarPessoaFisica.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarPessoaFisica.TabIndex = 8;
            this.btnSalvarPessoaFisica.Text = "Salvar";
            this.btnSalvarPessoaFisica.UseVisualStyleBackColor = true;
            this.btnSalvarPessoaFisica.Click += new System.EventHandler(this.salvarFuncionario);
            // 
            // btnVoltarFrmPF
            // 
            this.btnVoltarFrmPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltarFrmPF.Location = new System.Drawing.Point(1054, 605);
            this.btnVoltarFrmPF.Name = "btnVoltarFrmPF";
            this.btnVoltarFrmPF.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarFrmPF.TabIndex = 9;
            this.btnVoltarFrmPF.Text = "Voltar";
            this.btnVoltarFrmPF.UseVisualStyleBackColor = true;
            this.btnVoltarFrmPF.Click += new System.EventHandler(this.voltar);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 640);
            this.Controls.Add(this.btnVoltarFrmPF);
            this.Controls.Add(this.btnSalvarPessoaFisica);
            this.Controls.Add(this.textEndereco_PF);
            this.Controls.Add(this.textEmail_PF);
            this.Controls.Add(this.textCpf_PF);
            this.Controls.Add(this.textNome_PF);
            this.Controls.Add(this.lbEndereco_PF);
            this.Controls.Add(this.lbEmail_PF);
            this.Controls.Add(this.lbCpf_PF);
            this.Controls.Add(this.lbNome_PF);
            this.Name = "frmFuncionario";
            this.Text = "Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome_PF;
        private System.Windows.Forms.Label lbCpf_PF;
        private System.Windows.Forms.Label lbEmail_PF;
        private System.Windows.Forms.Label lbEndereco_PF;
        private System.Windows.Forms.TextBox textNome_PF;
        private System.Windows.Forms.TextBox textCpf_PF;
        private System.Windows.Forms.TextBox textEmail_PF;
        private System.Windows.Forms.TextBox textEndereco_PF;
        private System.Windows.Forms.Button btnSalvarPessoaFisica;
        private System.Windows.Forms.Button btnVoltarFrmPF;
    }
}