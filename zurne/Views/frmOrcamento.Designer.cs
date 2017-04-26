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
            this.components = new System.ComponentModel.Container();
            this.lbOrigem = new System.Windows.Forms.Label();
            this.lbDestino = new System.Windows.Forms.Label();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lbVeiculo = new System.Windows.Forms.Label();
            this.cbVeiculo = new System.Windows.Forms.ComboBox();
            this.btCalcularOrcamento = new System.Windows.Forms.Button();
            this.lbDistancia = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.btGerarOrdemDeServico = new System.Windows.Forms.Button();
            this.btnSatelite = new System.Windows.Forms.Button();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.btnRelevo = new System.Windows.Forms.Button();
            this.trackZoom = new System.Windows.Forms.TrackBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbZoom = new System.Windows.Forms.Label();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOrigem
            // 
            this.lbOrigem.AutoSize = true;
            this.lbOrigem.Location = new System.Drawing.Point(21, 52);
            this.lbOrigem.Name = "lbOrigem";
            this.lbOrigem.Size = new System.Drawing.Size(40, 13);
            this.lbOrigem.TabIndex = 0;
            this.lbOrigem.Text = "Origem";
            // 
            // lbDestino
            // 
            this.lbDestino.AutoSize = true;
            this.lbDestino.Location = new System.Drawing.Point(18, 113);
            this.lbDestino.Name = "lbDestino";
            this.lbDestino.Size = new System.Drawing.Size(43, 13);
            this.lbDestino.TabIndex = 1;
            this.lbDestino.Text = "Destino";
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(20, 68);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(266, 20);
            this.txtOrigem.TabIndex = 2;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(20, 129);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(266, 20);
            this.txtDestino.TabIndex = 3;
            // 
            // lbVeiculo
            // 
            this.lbVeiculo.AutoSize = true;
            this.lbVeiculo.Location = new System.Drawing.Point(17, 196);
            this.lbVeiculo.Name = "lbVeiculo";
            this.lbVeiculo.Size = new System.Drawing.Size(44, 13);
            this.lbVeiculo.TabIndex = 4;
            this.lbVeiculo.Text = "Veículo";
            // 
            // cbVeiculo
            // 
            this.cbVeiculo.FormattingEnabled = true;
            this.cbVeiculo.Location = new System.Drawing.Point(20, 212);
            this.cbVeiculo.Name = "cbVeiculo";
            this.cbVeiculo.Size = new System.Drawing.Size(117, 21);
            this.cbVeiculo.TabIndex = 5;
            // 
            // btCalcularOrcamento
            // 
            this.btCalcularOrcamento.Location = new System.Drawing.Point(168, 212);
            this.btCalcularOrcamento.Name = "btCalcularOrcamento";
            this.btCalcularOrcamento.Size = new System.Drawing.Size(118, 23);
            this.btCalcularOrcamento.TabIndex = 6;
            this.btCalcularOrcamento.Text = "Calcular Orçamento";
            this.btCalcularOrcamento.UseVisualStyleBackColor = true;
            this.btCalcularOrcamento.Click += new System.EventHandler(this.btCalcularOrcamento_Click);
            // 
            // lbDistancia
            // 
            this.lbDistancia.AutoSize = true;
            this.lbDistancia.Location = new System.Drawing.Point(21, 283);
            this.lbDistancia.Name = "lbDistancia";
            this.lbDistancia.Size = new System.Drawing.Size(35, 13);
            this.lbDistancia.TabIndex = 7;
            this.lbDistancia.Text = "label1";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(152, 283);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(35, 13);
            this.lbValor.TabIndex = 8;
            this.lbValor.Text = "label2";
            // 
            // btGerarOrdemDeServico
            // 
            this.btGerarOrdemDeServico.Location = new System.Drawing.Point(12, 334);
            this.btGerarOrdemDeServico.Name = "btGerarOrdemDeServico";
            this.btGerarOrdemDeServico.Size = new System.Drawing.Size(143, 23);
            this.btGerarOrdemDeServico.TabIndex = 9;
            this.btGerarOrdemDeServico.Text = "Gerar ordem de serviço";
            this.btGerarOrdemDeServico.UseVisualStyleBackColor = true;
            // 
            // btnSatelite
            // 
            this.btnSatelite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSatelite.Location = new System.Drawing.Point(20, 533);
            this.btnSatelite.Name = "btnSatelite";
            this.btnSatelite.Size = new System.Drawing.Size(75, 23);
            this.btnSatelite.TabIndex = 11;
            this.btnSatelite.Text = "Satelite";
            this.btnSatelite.UseVisualStyleBackColor = true;
            this.btnSatelite.Click += new System.EventHandler(this.btnSatelite_Click);
            // 
            // btnOriginal
            // 
            this.btnOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOriginal.Location = new System.Drawing.Point(112, 533);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(75, 23);
            this.btnOriginal.TabIndex = 12;
            this.btnOriginal.Text = "Original";
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // btnRelevo
            // 
            this.btnRelevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRelevo.Location = new System.Drawing.Point(203, 533);
            this.btnRelevo.Name = "btnRelevo";
            this.btnRelevo.Size = new System.Drawing.Size(75, 23);
            this.btnRelevo.TabIndex = 13;
            this.btnRelevo.Text = "Relevo";
            this.btnRelevo.UseVisualStyleBackColor = true;
            this.btnRelevo.Click += new System.EventHandler(this.btnRelevo_Click);
            // 
            // trackZoom
            // 
            this.trackZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackZoom.Location = new System.Drawing.Point(12, 573);
            this.trackZoom.Maximum = 25;
            this.trackZoom.Name = "trackZoom";
            this.trackZoom.Size = new System.Drawing.Size(274, 45);
            this.trackZoom.TabIndex = 14;
            this.trackZoom.ValueChanged += new System.EventHandler(this.trackZoom_ValueChanged);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbZoom
            // 
            this.lbZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbZoom.AutoSize = true;
            this.lbZoom.Location = new System.Drawing.Point(17, 609);
            this.lbZoom.Name = "lbZoom";
            this.lbZoom.Size = new System.Drawing.Size(34, 13);
            this.lbZoom.TabIndex = 15;
            this.lbZoom.Text = "Zoom";
            // 
            // gMapControl
            // 
            this.gMapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemmory = 5;
            this.gMapControl.Location = new System.Drawing.Point(307, 1);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 2;
            this.gMapControl.MinZoom = 2;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(921, 630);
            this.gMapControl.TabIndex = 10;
            this.gMapControl.Zoom = 0D;
            // 
            // frmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 631);
            this.Controls.Add(this.gMapControl);
            this.Controls.Add(this.lbZoom);
            this.Controls.Add(this.lbOrigem);
            this.Controls.Add(this.btCalcularOrcamento);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.lbDistancia);
            this.Controls.Add(this.trackZoom);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbDestino);
            this.Controls.Add(this.btGerarOrdemDeServico);
            this.Controls.Add(this.btnRelevo);
            this.Controls.Add(this.lbVeiculo);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.btnSatelite);
            this.Controls.Add(this.btnOriginal);
            this.Controls.Add(this.cbVeiculo);
            this.Name = "frmOrcamento";
            this.Text = "Orçamento";
            this.Load += new System.EventHandler(this.frmOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOrigem;
        private System.Windows.Forms.Label lbDestino;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lbVeiculo;
        private System.Windows.Forms.ComboBox cbVeiculo;
        private System.Windows.Forms.Button btCalcularOrcamento;
        private System.Windows.Forms.Label lbDistancia;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Button btGerarOrdemDeServico;
        private System.Windows.Forms.Button btnSatelite;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.Button btnRelevo;
        private System.Windows.Forms.TrackBar trackZoom;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbZoom;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
    }
}