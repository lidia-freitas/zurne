namespace Views
{
    partial class frmAutomovel
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
            this.gbAutomovel = new System.Windows.Forms.GroupBox();
            this.btnVoltarFrmAuto = new System.Windows.Forms.Button();
            this.btnSalvarAutomovel = new System.Windows.Forms.Button();
            this.textPotencia_Auto = new System.Windows.Forms.TextBox();
            this.textAno_Auto = new System.Windows.Forms.TextBox();
            this.textCor_Auto = new System.Windows.Forms.TextBox();
            this.textModelo_Auto = new System.Windows.Forms.TextBox();
            this.textMarca_Auto = new System.Windows.Forms.TextBox();
            this.lbPotencia_Auto = new System.Windows.Forms.Label();
            this.lbAno_Auto = new System.Windows.Forms.Label();
            this.lbCor_Auto = new System.Windows.Forms.Label();
            this.lbModelo_Auto = new System.Windows.Forms.Label();
            this.lbMarca_Auto = new System.Windows.Forms.Label();
            this.textAutonomia_Auto = new System.Windows.Forms.TextBox();
            this.lbAutonomia_Auto = new System.Windows.Forms.Label();
            this.gbAutomovel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAutomovel
            // 
            this.gbAutomovel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAutomovel.Controls.Add(this.lbAutonomia_Auto);
            this.gbAutomovel.Controls.Add(this.textAutonomia_Auto);
            this.gbAutomovel.Controls.Add(this.btnVoltarFrmAuto);
            this.gbAutomovel.Controls.Add(this.btnSalvarAutomovel);
            this.gbAutomovel.Controls.Add(this.textPotencia_Auto);
            this.gbAutomovel.Controls.Add(this.textAno_Auto);
            this.gbAutomovel.Controls.Add(this.textCor_Auto);
            this.gbAutomovel.Controls.Add(this.textModelo_Auto);
            this.gbAutomovel.Controls.Add(this.textMarca_Auto);
            this.gbAutomovel.Controls.Add(this.lbPotencia_Auto);
            this.gbAutomovel.Controls.Add(this.lbAno_Auto);
            this.gbAutomovel.Controls.Add(this.lbCor_Auto);
            this.gbAutomovel.Controls.Add(this.lbModelo_Auto);
            this.gbAutomovel.Controls.Add(this.lbMarca_Auto);
            this.gbAutomovel.Location = new System.Drawing.Point(12, 31);
            this.gbAutomovel.Name = "gbAutomovel";
            this.gbAutomovel.Size = new System.Drawing.Size(1193, 570);
            this.gbAutomovel.TabIndex = 5;
            this.gbAutomovel.TabStop = false;
            this.gbAutomovel.Text = "Automóvel";
            // 
            // btnVoltarFrmAuto
            // 
            this.btnVoltarFrmAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltarFrmAuto.Location = new System.Drawing.Point(1029, 541);
            this.btnVoltarFrmAuto.Name = "btnVoltarFrmAuto";
            this.btnVoltarFrmAuto.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarFrmAuto.TabIndex = 11;
            this.btnVoltarFrmAuto.Text = "Voltar";
            this.btnVoltarFrmAuto.UseVisualStyleBackColor = true;
            this.btnVoltarFrmAuto.Click += new System.EventHandler(this.voltar);
            // 
            // btnSalvarAutomovel
            // 
            this.btnSalvarAutomovel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarAutomovel.Location = new System.Drawing.Point(1110, 541);
            this.btnSalvarAutomovel.Name = "btnSalvarAutomovel";
            this.btnSalvarAutomovel.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarAutomovel.TabIndex = 10;
            this.btnSalvarAutomovel.Text = "Salvar";
            this.btnSalvarAutomovel.UseVisualStyleBackColor = true;
            this.btnSalvarAutomovel.Click += new System.EventHandler(this.salvarAutomovel);
            // 
            // textPotencia_Auto
            // 
            this.textPotencia_Auto.Location = new System.Drawing.Point(30, 372);
            this.textPotencia_Auto.Name = "textPotencia_Auto";
            this.textPotencia_Auto.Size = new System.Drawing.Size(100, 20);
            this.textPotencia_Auto.TabIndex = 9;
            // 
            // textAno_Auto
            // 
            this.textAno_Auto.Location = new System.Drawing.Point(27, 288);
            this.textAno_Auto.Name = "textAno_Auto";
            this.textAno_Auto.Size = new System.Drawing.Size(100, 20);
            this.textAno_Auto.TabIndex = 8;
            // 
            // textCor_Auto
            // 
            this.textCor_Auto.Location = new System.Drawing.Point(27, 211);
            this.textCor_Auto.Name = "textCor_Auto";
            this.textCor_Auto.Size = new System.Drawing.Size(100, 20);
            this.textCor_Auto.TabIndex = 7;
            // 
            // textModelo_Auto
            // 
            this.textModelo_Auto.Location = new System.Drawing.Point(27, 137);
            this.textModelo_Auto.Name = "textModelo_Auto";
            this.textModelo_Auto.Size = new System.Drawing.Size(100, 20);
            this.textModelo_Auto.TabIndex = 6;
            // 
            // textMarca_Auto
            // 
            this.textMarca_Auto.Location = new System.Drawing.Point(27, 74);
            this.textMarca_Auto.Name = "textMarca_Auto";
            this.textMarca_Auto.Size = new System.Drawing.Size(100, 20);
            this.textMarca_Auto.TabIndex = 5;
            // 
            // lbPotencia_Auto
            // 
            this.lbPotencia_Auto.AutoSize = true;
            this.lbPotencia_Auto.Location = new System.Drawing.Point(27, 354);
            this.lbPotencia_Auto.Name = "lbPotencia_Auto";
            this.lbPotencia_Auto.Size = new System.Drawing.Size(49, 13);
            this.lbPotencia_Auto.TabIndex = 4;
            this.lbPotencia_Auto.Text = "Potência";
            // 
            // lbAno_Auto
            // 
            this.lbAno_Auto.AutoSize = true;
            this.lbAno_Auto.Location = new System.Drawing.Point(24, 270);
            this.lbAno_Auto.Name = "lbAno_Auto";
            this.lbAno_Auto.Size = new System.Drawing.Size(26, 13);
            this.lbAno_Auto.TabIndex = 3;
            this.lbAno_Auto.Text = "Ano";
            // 
            // lbCor_Auto
            // 
            this.lbCor_Auto.AutoSize = true;
            this.lbCor_Auto.Location = new System.Drawing.Point(24, 191);
            this.lbCor_Auto.Name = "lbCor_Auto";
            this.lbCor_Auto.Size = new System.Drawing.Size(23, 13);
            this.lbCor_Auto.TabIndex = 2;
            this.lbCor_Auto.Text = "Cor";
            // 
            // lbModelo_Auto
            // 
            this.lbModelo_Auto.AutoSize = true;
            this.lbModelo_Auto.Location = new System.Drawing.Point(24, 119);
            this.lbModelo_Auto.Name = "lbModelo_Auto";
            this.lbModelo_Auto.Size = new System.Drawing.Size(42, 13);
            this.lbModelo_Auto.TabIndex = 1;
            this.lbModelo_Auto.Text = "Modelo";
            // 
            // lbMarca_Auto
            // 
            this.lbMarca_Auto.AutoSize = true;
            this.lbMarca_Auto.Location = new System.Drawing.Point(24, 55);
            this.lbMarca_Auto.Name = "lbMarca_Auto";
            this.lbMarca_Auto.Size = new System.Drawing.Size(37, 13);
            this.lbMarca_Auto.TabIndex = 0;
            this.lbMarca_Auto.Text = "Marca";
            // 
            // textAutonomia_Auto
            // 
            this.textAutonomia_Auto.Location = new System.Drawing.Point(27, 447);
            this.textAutonomia_Auto.Name = "textAutonomia_Auto";
            this.textAutonomia_Auto.Size = new System.Drawing.Size(100, 20);
            this.textAutonomia_Auto.TabIndex = 12;
            // 
            // lbAutonomia_Auto
            // 
            this.lbAutonomia_Auto.AutoSize = true;
            this.lbAutonomia_Auto.Location = new System.Drawing.Point(27, 431);
            this.lbAutonomia_Auto.Name = "lbAutonomia_Auto";
            this.lbAutonomia_Auto.Size = new System.Drawing.Size(57, 13);
            this.lbAutonomia_Auto.TabIndex = 13;
            this.lbAutonomia_Auto.Text = "Autonomia";
            // 
            // frmAutomovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 633);
            this.Controls.Add(this.gbAutomovel);
            this.Name = "frmAutomovel";
            this.Text = "Automovel";
            this.gbAutomovel.ResumeLayout(false);
            this.gbAutomovel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAutomovel;
        private System.Windows.Forms.Button btnVoltarFrmAuto;
        private System.Windows.Forms.Button btnSalvarAutomovel;
        private System.Windows.Forms.TextBox textPotencia_Auto;
        private System.Windows.Forms.TextBox textAno_Auto;
        private System.Windows.Forms.TextBox textCor_Auto;
        private System.Windows.Forms.TextBox textModelo_Auto;
        private System.Windows.Forms.TextBox textMarca_Auto;
        private System.Windows.Forms.Label lbPotencia_Auto;
        private System.Windows.Forms.Label lbAno_Auto;
        private System.Windows.Forms.Label lbCor_Auto;
        private System.Windows.Forms.Label lbModelo_Auto;
        private System.Windows.Forms.Label lbMarca_Auto;
        private System.Windows.Forms.Label lbAutonomia_Auto;
        private System.Windows.Forms.TextBox textAutonomia_Auto;
    }
}