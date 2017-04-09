namespace Views
{
    partial class frmMotocicleta
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
            this.gbMotocicleta = new System.Windows.Forms.GroupBox();
            this.btnVoltarFrmMoto = new System.Windows.Forms.Button();
            this.btnSalvarMotocicleta = new System.Windows.Forms.Button();
            this.textCilindradas_Moto = new System.Windows.Forms.TextBox();
            this.textAno_Moto = new System.Windows.Forms.TextBox();
            this.textCor_Moto = new System.Windows.Forms.TextBox();
            this.textModelo_Moto = new System.Windows.Forms.TextBox();
            this.textMarca_Moto = new System.Windows.Forms.TextBox();
            this.lbCilindradas_Moto = new System.Windows.Forms.Label();
            this.lbAno_Moto = new System.Windows.Forms.Label();
            this.lbCor_Moto = new System.Windows.Forms.Label();
            this.lbModelo_Moto = new System.Windows.Forms.Label();
            this.lbMarca_Moto = new System.Windows.Forms.Label();
            this.gbMotocicleta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMotocicleta
            // 
            this.gbMotocicleta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMotocicleta.Controls.Add(this.btnVoltarFrmMoto);
            this.gbMotocicleta.Controls.Add(this.btnSalvarMotocicleta);
            this.gbMotocicleta.Controls.Add(this.textCilindradas_Moto);
            this.gbMotocicleta.Controls.Add(this.textAno_Moto);
            this.gbMotocicleta.Controls.Add(this.textCor_Moto);
            this.gbMotocicleta.Controls.Add(this.textModelo_Moto);
            this.gbMotocicleta.Controls.Add(this.textMarca_Moto);
            this.gbMotocicleta.Controls.Add(this.lbCilindradas_Moto);
            this.gbMotocicleta.Controls.Add(this.lbAno_Moto);
            this.gbMotocicleta.Controls.Add(this.lbCor_Moto);
            this.gbMotocicleta.Controls.Add(this.lbModelo_Moto);
            this.gbMotocicleta.Controls.Add(this.lbMarca_Moto);
            this.gbMotocicleta.Location = new System.Drawing.Point(7, 33);
            this.gbMotocicleta.Name = "gbMotocicleta";
            this.gbMotocicleta.Size = new System.Drawing.Size(1193, 570);
            this.gbMotocicleta.TabIndex = 6;
            this.gbMotocicleta.TabStop = false;
            this.gbMotocicleta.Text = "Motocicleta";
            // 
            // btnVoltarFrmMoto
            // 
            this.btnVoltarFrmMoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltarFrmMoto.Location = new System.Drawing.Point(1030, 538);
            this.btnVoltarFrmMoto.Name = "btnVoltarFrmMoto";
            this.btnVoltarFrmMoto.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarFrmMoto.TabIndex = 11;
            this.btnVoltarFrmMoto.Text = "Voltar";
            this.btnVoltarFrmMoto.UseVisualStyleBackColor = true;
            this.btnVoltarFrmMoto.Click += new System.EventHandler(this.voltar);
            // 
            // btnSalvarMotocicleta
            // 
            this.btnSalvarMotocicleta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarMotocicleta.Location = new System.Drawing.Point(1111, 539);
            this.btnSalvarMotocicleta.Name = "btnSalvarMotocicleta";
            this.btnSalvarMotocicleta.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarMotocicleta.TabIndex = 10;
            this.btnSalvarMotocicleta.Text = "Salvar";
            this.btnSalvarMotocicleta.UseVisualStyleBackColor = true;
            this.btnSalvarMotocicleta.Click += new System.EventHandler(this.salvarMotocicleta);
            // 
            // textCilindradas_Moto
            // 
            this.textCilindradas_Moto.Location = new System.Drawing.Point(30, 443);
            this.textCilindradas_Moto.Name = "textCilindradas_Moto";
            this.textCilindradas_Moto.Size = new System.Drawing.Size(100, 20);
            this.textCilindradas_Moto.TabIndex = 9;
            // 
            // textAno_Moto
            // 
            this.textAno_Moto.Location = new System.Drawing.Point(30, 347);
            this.textAno_Moto.Name = "textAno_Moto";
            this.textAno_Moto.Size = new System.Drawing.Size(100, 20);
            this.textAno_Moto.TabIndex = 8;
            // 
            // textCor_Moto
            // 
            this.textCor_Moto.Location = new System.Drawing.Point(27, 237);
            this.textCor_Moto.Name = "textCor_Moto";
            this.textCor_Moto.Size = new System.Drawing.Size(100, 20);
            this.textCor_Moto.TabIndex = 7;
            // 
            // textModelo_Moto
            // 
            this.textModelo_Moto.Location = new System.Drawing.Point(30, 152);
            this.textModelo_Moto.Name = "textModelo_Moto";
            this.textModelo_Moto.Size = new System.Drawing.Size(100, 20);
            this.textModelo_Moto.TabIndex = 6;
            // 
            // textMarca_Moto
            // 
            this.textMarca_Moto.Location = new System.Drawing.Point(30, 74);
            this.textMarca_Moto.Name = "textMarca_Moto";
            this.textMarca_Moto.Size = new System.Drawing.Size(100, 20);
            this.textMarca_Moto.TabIndex = 5;
            // 
            // lbCilindradas_Moto
            // 
            this.lbCilindradas_Moto.AutoSize = true;
            this.lbCilindradas_Moto.Location = new System.Drawing.Point(27, 418);
            this.lbCilindradas_Moto.Name = "lbCilindradas_Moto";
            this.lbCilindradas_Moto.Size = new System.Drawing.Size(58, 13);
            this.lbCilindradas_Moto.TabIndex = 4;
            this.lbCilindradas_Moto.Text = "Cilindradas";
            // 
            // lbAno_Moto
            // 
            this.lbAno_Moto.AutoSize = true;
            this.lbAno_Moto.Location = new System.Drawing.Point(27, 327);
            this.lbAno_Moto.Name = "lbAno_Moto";
            this.lbAno_Moto.Size = new System.Drawing.Size(26, 13);
            this.lbAno_Moto.TabIndex = 3;
            this.lbAno_Moto.Text = "Ano";
            // 
            // lbCor_Moto
            // 
            this.lbCor_Moto.AutoSize = true;
            this.lbCor_Moto.Location = new System.Drawing.Point(24, 208);
            this.lbCor_Moto.Name = "lbCor_Moto";
            this.lbCor_Moto.Size = new System.Drawing.Size(23, 13);
            this.lbCor_Moto.TabIndex = 2;
            this.lbCor_Moto.Text = "Cor";
            // 
            // lbModelo_Moto
            // 
            this.lbModelo_Moto.AutoSize = true;
            this.lbModelo_Moto.Location = new System.Drawing.Point(27, 120);
            this.lbModelo_Moto.Name = "lbModelo_Moto";
            this.lbModelo_Moto.Size = new System.Drawing.Size(42, 13);
            this.lbModelo_Moto.TabIndex = 1;
            this.lbModelo_Moto.Text = "Modelo";
            // 
            // lbMarca_Moto
            // 
            this.lbMarca_Moto.AutoSize = true;
            this.lbMarca_Moto.Location = new System.Drawing.Point(24, 46);
            this.lbMarca_Moto.Name = "lbMarca_Moto";
            this.lbMarca_Moto.Size = new System.Drawing.Size(37, 13);
            this.lbMarca_Moto.TabIndex = 0;
            this.lbMarca_Moto.Text = "Marca";
            // 
            // frmMotocicleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 636);
            this.Controls.Add(this.gbMotocicleta);
            this.Name = "frmMotocicleta";
            this.Text = "Motocicleta";
            this.gbMotocicleta.ResumeLayout(false);
            this.gbMotocicleta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMotocicleta;
        private System.Windows.Forms.Button btnVoltarFrmMoto;
        private System.Windows.Forms.Button btnSalvarMotocicleta;
        private System.Windows.Forms.TextBox textCilindradas_Moto;
        private System.Windows.Forms.TextBox textAno_Moto;
        private System.Windows.Forms.TextBox textCor_Moto;
        private System.Windows.Forms.TextBox textModelo_Moto;
        private System.Windows.Forms.TextBox textMarca_Moto;
        private System.Windows.Forms.Label lbCilindradas_Moto;
        private System.Windows.Forms.Label lbAno_Moto;
        private System.Windows.Forms.Label lbCor_Moto;
        private System.Windows.Forms.Label lbModelo_Moto;
        private System.Windows.Forms.Label lbMarca_Moto;
    }
}