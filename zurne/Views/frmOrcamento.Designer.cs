namespace Views
{
    partial class frmOrcamento
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
            this.lbOrigem = new System.Windows.Forms.Label();
            this.lbDestino = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbVeiculo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btCalcularOrcamento = new System.Windows.Forms.Button();
            this.lbDistancia = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.btGerarOrdemDeServico = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // lbOrigem
            // 
            this.lbOrigem.AutoSize = true;
            this.lbOrigem.Location = new System.Drawing.Point(9, 28);
            this.lbOrigem.Name = "lbOrigem";
            this.lbOrigem.Size = new System.Drawing.Size(40, 13);
            this.lbOrigem.TabIndex = 0;
            this.lbOrigem.Text = "Origem";
            this.lbOrigem.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbDestino
            // 
            this.lbDestino.AutoSize = true;
            this.lbDestino.Location = new System.Drawing.Point(335, 28);
            this.lbDestino.Name = "lbDestino";
            this.lbDestino.Size = new System.Drawing.Size(43, 13);
            this.lbDestino.TabIndex = 1;
            this.lbDestino.Text = "Destino";
            this.lbDestino.Click += new System.EventHandler(this.lbDestino_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(338, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(320, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbVeiculo
            // 
            this.lbVeiculo.AutoSize = true;
            this.lbVeiculo.Location = new System.Drawing.Point(661, 28);
            this.lbVeiculo.Name = "lbVeiculo";
            this.lbVeiculo.Size = new System.Drawing.Size(44, 13);
            this.lbVeiculo.TabIndex = 4;
            this.lbVeiculo.Text = "Veículo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(664, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // btCalcularOrcamento
            // 
            this.btCalcularOrcamento.Location = new System.Drawing.Point(842, 48);
            this.btCalcularOrcamento.Name = "btCalcularOrcamento";
            this.btCalcularOrcamento.Size = new System.Drawing.Size(125, 23);
            this.btCalcularOrcamento.TabIndex = 6;
            this.btCalcularOrcamento.Text = "Calcular Orçamento";
            this.btCalcularOrcamento.UseVisualStyleBackColor = true;
            this.btCalcularOrcamento.Click += new System.EventHandler(this.btOrcamento_Click);
            // 
            // lbDistancia
            // 
            this.lbDistancia.AutoSize = true;
            this.lbDistancia.Location = new System.Drawing.Point(13, 110);
            this.lbDistancia.Name = "lbDistancia";
            this.lbDistancia.Size = new System.Drawing.Size(35, 13);
            this.lbDistancia.TabIndex = 7;
            this.lbDistancia.Text = "label1";
            this.lbDistancia.Click += new System.EventHandler(this.lbDistancia_Click);
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(239, 110);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(35, 13);
            this.lbValor.TabIndex = 8;
            this.lbValor.Text = "label2";
            this.lbValor.Click += new System.EventHandler(this.lbValor_Click);
            // 
            // btGerarOrdemDeServico
            // 
            this.btGerarOrdemDeServico.Location = new System.Drawing.Point(375, 105);
            this.btGerarOrdemDeServico.Name = "btGerarOrdemDeServico";
            this.btGerarOrdemDeServico.Size = new System.Drawing.Size(143, 23);
            this.btGerarOrdemDeServico.TabIndex = 9;
            this.btGerarOrdemDeServico.Text = "Gerar ordem de serviço";
            this.btGerarOrdemDeServico.UseVisualStyleBackColor = true;
            this.btGerarOrdemDeServico.Click += new System.EventHandler(this.btGerarOrdemDeServico_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(13, 150);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(954, 335);
            this.webBrowser1.TabIndex = 10;
            // 
            // frmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 497);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btGerarOrdemDeServico);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbDistancia);
            this.Controls.Add(this.btCalcularOrcamento);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbVeiculo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbDestino);
            this.Controls.Add(this.lbOrigem);
            this.Name = "frmOrcamento";
            this.Text = "Orçamento";
            this.Load += new System.EventHandler(this.frmOrcamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOrigem;
        private System.Windows.Forms.Label lbDestino;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbVeiculo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btCalcularOrcamento;
        private System.Windows.Forms.Label lbDistancia;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Button btGerarOrdemDeServico;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}