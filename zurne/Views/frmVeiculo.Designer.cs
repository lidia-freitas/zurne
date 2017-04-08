namespace Views
{
    partial class frmVeiculo
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
            this.rbBicicleta = new System.Windows.Forms.RadioButton();
            this.rbMotocicleta = new System.Windows.Forms.RadioButton();
            this.rbAutomovel = new System.Windows.Forms.RadioButton();
            this.gbBicicleta = new System.Windows.Forms.GroupBox();
            this.btnVoltarFrmBic = new System.Windows.Forms.Button();
            this.btnSalvarBicicleta = new System.Windows.Forms.Button();
            this.textMarchas_Bic = new System.Windows.Forms.TextBox();
            this.textAno_Bic = new System.Windows.Forms.TextBox();
            this.textCor_Bic = new System.Windows.Forms.TextBox();
            this.textModelo_Bic = new System.Windows.Forms.TextBox();
            this.textMarca_Bic = new System.Windows.Forms.TextBox();
            this.lbMarchas_Bic = new System.Windows.Forms.Label();
            this.lbAno_Bic = new System.Windows.Forms.Label();
            this.lbCor_Bic = new System.Windows.Forms.Label();
            this.lbModelo_Bic = new System.Windows.Forms.Label();
            this.lbMarca_Bic = new System.Windows.Forms.Label();
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
            this.gbMotocicleta = new System.Windows.Forms.GroupBox();
            this.btnVoltarFrmMot = new System.Windows.Forms.Button();
            this.btnSalvarMotocicleta = new System.Windows.Forms.Button();
            this.textCilindradas_Mot = new System.Windows.Forms.TextBox();
            this.textAno_Mot = new System.Windows.Forms.TextBox();
            this.textCor_Mot = new System.Windows.Forms.TextBox();
            this.textModelo_Mot = new System.Windows.Forms.TextBox();
            this.textMarca_Mot = new System.Windows.Forms.TextBox();
            this.lbCilindradas_Mot = new System.Windows.Forms.Label();
            this.lbAno_Mot = new System.Windows.Forms.Label();
            this.lbCor_Mot = new System.Windows.Forms.Label();
            this.lbModelo_Mot = new System.Windows.Forms.Label();
            this.lbMarca_Mot = new System.Windows.Forms.Label();
            this.gbBicicleta.SuspendLayout();
            this.gbAutomovel.SuspendLayout();
            this.gbMotocicleta.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbBicicleta
            // 
            this.rbBicicleta.AutoSize = true;
            this.rbBicicleta.Location = new System.Drawing.Point(12, 21);
            this.rbBicicleta.Name = "rbBicicleta";
            this.rbBicicleta.Size = new System.Drawing.Size(65, 17);
            this.rbBicicleta.TabIndex = 0;
            this.rbBicicleta.TabStop = true;
            this.rbBicicleta.Text = "Bicicleta";
            this.rbBicicleta.UseVisualStyleBackColor = true;
            this.rbBicicleta.CheckedChanged += new System.EventHandler(this.mostraFormBicicleta);
            // 
            // rbMotocicleta
            // 
            this.rbMotocicleta.AutoSize = true;
            this.rbMotocicleta.Location = new System.Drawing.Point(101, 21);
            this.rbMotocicleta.Name = "rbMotocicleta";
            this.rbMotocicleta.Size = new System.Drawing.Size(80, 17);
            this.rbMotocicleta.TabIndex = 1;
            this.rbMotocicleta.TabStop = true;
            this.rbMotocicleta.Text = "Motocicleta";
            this.rbMotocicleta.UseVisualStyleBackColor = true;
            this.rbMotocicleta.CheckedChanged += new System.EventHandler(this.mostraFormMotocicleta);
            // 
            // rbAutomovel
            // 
            this.rbAutomovel.AutoSize = true;
            this.rbAutomovel.Location = new System.Drawing.Point(204, 21);
            this.rbAutomovel.Name = "rbAutomovel";
            this.rbAutomovel.Size = new System.Drawing.Size(75, 17);
            this.rbAutomovel.TabIndex = 2;
            this.rbAutomovel.TabStop = true;
            this.rbAutomovel.Text = "Automóvel";
            this.rbAutomovel.UseVisualStyleBackColor = true;
            this.rbAutomovel.CheckedChanged += new System.EventHandler(this.mostraFormAutomovel);
            // 
            // gbBicicleta
            // 
            this.gbBicicleta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBicicleta.Controls.Add(this.btnVoltarFrmBic);
            this.gbBicicleta.Controls.Add(this.btnSalvarBicicleta);
            this.gbBicicleta.Controls.Add(this.textMarchas_Bic);
            this.gbBicicleta.Controls.Add(this.textAno_Bic);
            this.gbBicicleta.Controls.Add(this.textCor_Bic);
            this.gbBicicleta.Controls.Add(this.textModelo_Bic);
            this.gbBicicleta.Controls.Add(this.textMarca_Bic);
            this.gbBicicleta.Controls.Add(this.lbMarchas_Bic);
            this.gbBicicleta.Controls.Add(this.lbAno_Bic);
            this.gbBicicleta.Controls.Add(this.lbCor_Bic);
            this.gbBicicleta.Controls.Add(this.lbModelo_Bic);
            this.gbBicicleta.Controls.Add(this.lbMarca_Bic);
            this.gbBicicleta.Location = new System.Drawing.Point(13, 54);
            this.gbBicicleta.Name = "gbBicicleta";
            this.gbBicicleta.Size = new System.Drawing.Size(1193, 570);
            this.gbBicicleta.TabIndex = 3;
            this.gbBicicleta.TabStop = false;
            this.gbBicicleta.Text = "Bicicleta";
            // 
            // btnVoltarFrmBic
            // 
            this.btnVoltarFrmBic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltarFrmBic.Location = new System.Drawing.Point(1031, 540);
            this.btnVoltarFrmBic.Name = "btnVoltarFrmBic";
            this.btnVoltarFrmBic.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarFrmBic.TabIndex = 11;
            this.btnVoltarFrmBic.Text = "Voltar";
            this.btnVoltarFrmBic.UseVisualStyleBackColor = true;
            this.btnVoltarFrmBic.Click += new System.EventHandler(this.voltar);
            // 
            // btnSalvarBicicleta
            // 
            this.btnSalvarBicicleta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarBicicleta.Location = new System.Drawing.Point(1112, 541);
            this.btnSalvarBicicleta.Name = "btnSalvarBicicleta";
            this.btnSalvarBicicleta.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarBicicleta.TabIndex = 10;
            this.btnSalvarBicicleta.Text = "Salvar";
            this.btnSalvarBicicleta.UseVisualStyleBackColor = true;
            this.btnSalvarBicicleta.Click += new System.EventHandler(this.salvarVeiculo);
            // 
            // textMarchas_Bic
            // 
            this.textMarchas_Bic.Location = new System.Drawing.Point(27, 373);
            this.textMarchas_Bic.Name = "textMarchas_Bic";
            this.textMarchas_Bic.Size = new System.Drawing.Size(100, 20);
            this.textMarchas_Bic.TabIndex = 9;
            // 
            // textAno_Bic
            // 
            this.textAno_Bic.Location = new System.Drawing.Point(24, 301);
            this.textAno_Bic.Name = "textAno_Bic";
            this.textAno_Bic.Size = new System.Drawing.Size(100, 20);
            this.textAno_Bic.TabIndex = 8;
            // 
            // textCor_Bic
            // 
            this.textCor_Bic.Location = new System.Drawing.Point(30, 225);
            this.textCor_Bic.Name = "textCor_Bic";
            this.textCor_Bic.Size = new System.Drawing.Size(100, 20);
            this.textCor_Bic.TabIndex = 7;
            // 
            // textModelo_Bic
            // 
            this.textModelo_Bic.Location = new System.Drawing.Point(27, 152);
            this.textModelo_Bic.Name = "textModelo_Bic";
            this.textModelo_Bic.Size = new System.Drawing.Size(100, 20);
            this.textModelo_Bic.TabIndex = 6;
            // 
            // textMarca_Bic
            // 
            this.textMarca_Bic.Location = new System.Drawing.Point(24, 75);
            this.textMarca_Bic.Name = "textMarca_Bic";
            this.textMarca_Bic.Size = new System.Drawing.Size(100, 20);
            this.textMarca_Bic.TabIndex = 5;
            // 
            // lbMarchas_Bic
            // 
            this.lbMarchas_Bic.AutoSize = true;
            this.lbMarchas_Bic.Location = new System.Drawing.Point(27, 343);
            this.lbMarchas_Bic.Name = "lbMarchas_Bic";
            this.lbMarchas_Bic.Size = new System.Drawing.Size(48, 13);
            this.lbMarchas_Bic.TabIndex = 4;
            this.lbMarchas_Bic.Text = "Marchas";
            // 
            // lbAno_Bic
            // 
            this.lbAno_Bic.AutoSize = true;
            this.lbAno_Bic.Location = new System.Drawing.Point(24, 271);
            this.lbAno_Bic.Name = "lbAno_Bic";
            this.lbAno_Bic.Size = new System.Drawing.Size(26, 13);
            this.lbAno_Bic.TabIndex = 3;
            this.lbAno_Bic.Text = "Ano";
            // 
            // lbCor_Bic
            // 
            this.lbCor_Bic.AutoSize = true;
            this.lbCor_Bic.Location = new System.Drawing.Point(27, 191);
            this.lbCor_Bic.Name = "lbCor_Bic";
            this.lbCor_Bic.Size = new System.Drawing.Size(23, 13);
            this.lbCor_Bic.TabIndex = 2;
            this.lbCor_Bic.Text = "Cor";
            // 
            // lbModelo_Bic
            // 
            this.lbModelo_Bic.AutoSize = true;
            this.lbModelo_Bic.Location = new System.Drawing.Point(24, 120);
            this.lbModelo_Bic.Name = "lbModelo_Bic";
            this.lbModelo_Bic.Size = new System.Drawing.Size(42, 13);
            this.lbModelo_Bic.TabIndex = 1;
            this.lbModelo_Bic.Text = "Modelo";
            // 
            // lbMarca_Bic
            // 
            this.lbMarca_Bic.AutoSize = true;
            this.lbMarca_Bic.Location = new System.Drawing.Point(21, 46);
            this.lbMarca_Bic.Name = "lbMarca_Bic";
            this.lbMarca_Bic.Size = new System.Drawing.Size(37, 13);
            this.lbMarca_Bic.TabIndex = 0;
            this.lbMarca_Bic.Text = "Marca";
            // 
            // gbAutomovel
            // 
            this.gbAutomovel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gbAutomovel.Location = new System.Drawing.Point(13, 54);
            this.gbAutomovel.Name = "gbAutomovel";
            this.gbAutomovel.Size = new System.Drawing.Size(1193, 570);
            this.gbAutomovel.TabIndex = 4;
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
            this.btnSalvarAutomovel.Click += new System.EventHandler(this.salvarVeiculo);
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
            // gbMotocicleta
            // 
            this.gbMotocicleta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMotocicleta.Controls.Add(this.btnVoltarFrmMot);
            this.gbMotocicleta.Controls.Add(this.btnSalvarMotocicleta);
            this.gbMotocicleta.Controls.Add(this.textCilindradas_Mot);
            this.gbMotocicleta.Controls.Add(this.textAno_Mot);
            this.gbMotocicleta.Controls.Add(this.textCor_Mot);
            this.gbMotocicleta.Controls.Add(this.textModelo_Mot);
            this.gbMotocicleta.Controls.Add(this.textMarca_Mot);
            this.gbMotocicleta.Controls.Add(this.lbCilindradas_Mot);
            this.gbMotocicleta.Controls.Add(this.lbAno_Mot);
            this.gbMotocicleta.Controls.Add(this.lbCor_Mot);
            this.gbMotocicleta.Controls.Add(this.lbModelo_Mot);
            this.gbMotocicleta.Controls.Add(this.lbMarca_Mot);
            this.gbMotocicleta.Location = new System.Drawing.Point(13, 54);
            this.gbMotocicleta.Name = "gbMotocicleta";
            this.gbMotocicleta.Size = new System.Drawing.Size(1193, 570);
            this.gbMotocicleta.TabIndex = 5;
            this.gbMotocicleta.TabStop = false;
            this.gbMotocicleta.Text = "Motocicleta";
            // 
            // btnVoltarFrmMot
            // 
            this.btnVoltarFrmMot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltarFrmMot.Location = new System.Drawing.Point(1030, 538);
            this.btnVoltarFrmMot.Name = "btnVoltarFrmMot";
            this.btnVoltarFrmMot.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarFrmMot.TabIndex = 11;
            this.btnVoltarFrmMot.Text = "Voltar";
            this.btnVoltarFrmMot.UseVisualStyleBackColor = true;
            this.btnVoltarFrmMot.Click += new System.EventHandler(this.voltar);
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
            this.btnSalvarMotocicleta.Click += new System.EventHandler(this.salvarVeiculo);
            // 
            // textCilindradas_Mot
            // 
            this.textCilindradas_Mot.Location = new System.Drawing.Point(30, 443);
            this.textCilindradas_Mot.Name = "textCilindradas_Mot";
            this.textCilindradas_Mot.Size = new System.Drawing.Size(100, 20);
            this.textCilindradas_Mot.TabIndex = 9;
            // 
            // textAno_Mot
            // 
            this.textAno_Mot.Location = new System.Drawing.Point(30, 347);
            this.textAno_Mot.Name = "textAno_Mot";
            this.textAno_Mot.Size = new System.Drawing.Size(100, 20);
            this.textAno_Mot.TabIndex = 8;
            // 
            // textCor_Mot
            // 
            this.textCor_Mot.Location = new System.Drawing.Point(27, 237);
            this.textCor_Mot.Name = "textCor_Mot";
            this.textCor_Mot.Size = new System.Drawing.Size(100, 20);
            this.textCor_Mot.TabIndex = 7;
            // 
            // textModelo_Mot
            // 
            this.textModelo_Mot.Location = new System.Drawing.Point(30, 152);
            this.textModelo_Mot.Name = "textModelo_Mot";
            this.textModelo_Mot.Size = new System.Drawing.Size(100, 20);
            this.textModelo_Mot.TabIndex = 6;
            // 
            // textMarca_Mot
            // 
            this.textMarca_Mot.Location = new System.Drawing.Point(30, 74);
            this.textMarca_Mot.Name = "textMarca_Mot";
            this.textMarca_Mot.Size = new System.Drawing.Size(100, 20);
            this.textMarca_Mot.TabIndex = 5;
            // 
            // lbCilindradas_Mot
            // 
            this.lbCilindradas_Mot.AutoSize = true;
            this.lbCilindradas_Mot.Location = new System.Drawing.Point(27, 418);
            this.lbCilindradas_Mot.Name = "lbCilindradas_Mot";
            this.lbCilindradas_Mot.Size = new System.Drawing.Size(58, 13);
            this.lbCilindradas_Mot.TabIndex = 4;
            this.lbCilindradas_Mot.Text = "Cilindradas";
            // 
            // lbAno_Mot
            // 
            this.lbAno_Mot.AutoSize = true;
            this.lbAno_Mot.Location = new System.Drawing.Point(27, 327);
            this.lbAno_Mot.Name = "lbAno_Mot";
            this.lbAno_Mot.Size = new System.Drawing.Size(26, 13);
            this.lbAno_Mot.TabIndex = 3;
            this.lbAno_Mot.Text = "Ano";
            // 
            // lbCor_Mot
            // 
            this.lbCor_Mot.AutoSize = true;
            this.lbCor_Mot.Location = new System.Drawing.Point(24, 208);
            this.lbCor_Mot.Name = "lbCor_Mot";
            this.lbCor_Mot.Size = new System.Drawing.Size(23, 13);
            this.lbCor_Mot.TabIndex = 2;
            this.lbCor_Mot.Text = "Cor";
            // 
            // lbModelo_Mot
            // 
            this.lbModelo_Mot.AutoSize = true;
            this.lbModelo_Mot.Location = new System.Drawing.Point(27, 120);
            this.lbModelo_Mot.Name = "lbModelo_Mot";
            this.lbModelo_Mot.Size = new System.Drawing.Size(42, 13);
            this.lbModelo_Mot.TabIndex = 1;
            this.lbModelo_Mot.Text = "Modelo";
            // 
            // lbMarca_Mot
            // 
            this.lbMarca_Mot.AutoSize = true;
            this.lbMarca_Mot.Location = new System.Drawing.Point(24, 46);
            this.lbMarca_Mot.Name = "lbMarca_Mot";
            this.lbMarca_Mot.Size = new System.Drawing.Size(37, 13);
            this.lbMarca_Mot.TabIndex = 0;
            this.lbMarca_Mot.Text = "Marca";
            // 
            // frmVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 636);
            this.Controls.Add(this.rbAutomovel);
            this.Controls.Add(this.rbMotocicleta);
            this.Controls.Add(this.rbBicicleta);
            this.Controls.Add(this.gbBicicleta);
            this.Controls.Add(this.gbMotocicleta);
            this.Controls.Add(this.gbAutomovel);
            this.Name = "frmVeiculo";
            this.Text = "frmVeiculo";
            this.gbBicicleta.ResumeLayout(false);
            this.gbBicicleta.PerformLayout();
            this.gbAutomovel.ResumeLayout(false);
            this.gbAutomovel.PerformLayout();
            this.gbMotocicleta.ResumeLayout(false);
            this.gbMotocicleta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBicicleta;
        private System.Windows.Forms.RadioButton rbMotocicleta;
        private System.Windows.Forms.RadioButton rbAutomovel;
        private System.Windows.Forms.GroupBox gbBicicleta;
        private System.Windows.Forms.GroupBox gbAutomovel;
        private System.Windows.Forms.GroupBox gbMotocicleta;
        private System.Windows.Forms.Label lbMarchas_Bic;
        private System.Windows.Forms.Label lbAno_Bic;
        private System.Windows.Forms.Label lbCor_Bic;
        private System.Windows.Forms.Label lbModelo_Bic;
        private System.Windows.Forms.Label lbMarca_Bic;
        private System.Windows.Forms.TextBox textMarchas_Bic;
        private System.Windows.Forms.TextBox textAno_Bic;
        private System.Windows.Forms.TextBox textCor_Bic;
        private System.Windows.Forms.TextBox textModelo_Bic;
        private System.Windows.Forms.TextBox textMarca_Bic;
        private System.Windows.Forms.Label lbMarca_Mot;
        private System.Windows.Forms.Label lbCilindradas_Mot;
        private System.Windows.Forms.Label lbAno_Mot;
        private System.Windows.Forms.Label lbCor_Mot;
        private System.Windows.Forms.Label lbModelo_Mot;
        private System.Windows.Forms.TextBox textCilindradas_Mot;
        private System.Windows.Forms.TextBox textAno_Mot;
        private System.Windows.Forms.TextBox textCor_Mot;
        private System.Windows.Forms.TextBox textModelo_Mot;
        private System.Windows.Forms.TextBox textMarca_Mot;
        private System.Windows.Forms.Label lbPotencia_Auto;
        private System.Windows.Forms.Label lbAno_Auto;
        private System.Windows.Forms.Label lbCor_Auto;
        private System.Windows.Forms.Label lbModelo_Auto;
        private System.Windows.Forms.Label lbMarca_Auto;
        private System.Windows.Forms.TextBox textPotencia_Auto;
        private System.Windows.Forms.TextBox textAno_Auto;
        private System.Windows.Forms.TextBox textCor_Auto;
        private System.Windows.Forms.TextBox textModelo_Auto;
        private System.Windows.Forms.TextBox textMarca_Auto;
        private System.Windows.Forms.Button btnVoltarFrmBic;
        private System.Windows.Forms.Button btnSalvarBicicleta;
        private System.Windows.Forms.Button btnVoltarFrmAuto;
        private System.Windows.Forms.Button btnSalvarAutomovel;
        private System.Windows.Forms.Button btnVoltarFrmMot;
        private System.Windows.Forms.Button btnSalvarMotocicleta;
    }
}