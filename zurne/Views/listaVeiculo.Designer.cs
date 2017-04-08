namespace Views
{
    partial class listaVeiculo
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
            this.dataGridVeiculos = new System.Windows.Forms.DataGridView();
            this.btnCadastrarVeiculo = new System.Windows.Forms.Button();
            this.btnEditarVeiculo = new System.Windows.Forms.Button();
            this.btnRemoverVeiculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVeiculos
            // 
            this.dataGridVeiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridVeiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVeiculos.Location = new System.Drawing.Point(13, 78);
            this.dataGridVeiculos.Name = "dataGridVeiculos";
            this.dataGridVeiculos.Size = new System.Drawing.Size(1188, 548);
            this.dataGridVeiculos.TabIndex = 0;
            this.dataGridVeiculos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.selecionarVeiculo);
            // 
            // btnCadastrarVeiculo
            // 
            this.btnCadastrarVeiculo.Location = new System.Drawing.Point(12, 27);
            this.btnCadastrarVeiculo.Name = "btnCadastrarVeiculo";
            this.btnCadastrarVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarVeiculo.TabIndex = 1;
            this.btnCadastrarVeiculo.Text = "Novo";
            this.btnCadastrarVeiculo.UseVisualStyleBackColor = true;
            this.btnCadastrarVeiculo.Click += new System.EventHandler(this.cadastrarVeiculo);
            // 
            // btnEditarVeiculo
            // 
            this.btnEditarVeiculo.Location = new System.Drawing.Point(106, 26);
            this.btnEditarVeiculo.Name = "btnEditarVeiculo";
            this.btnEditarVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnEditarVeiculo.TabIndex = 2;
            this.btnEditarVeiculo.Text = "Editar";
            this.btnEditarVeiculo.UseVisualStyleBackColor = true;
            this.btnEditarVeiculo.Click += new System.EventHandler(this.editarVeiculo);
            // 
            // btnRemoverVeiculo
            // 
            this.btnRemoverVeiculo.Location = new System.Drawing.Point(200, 26);
            this.btnRemoverVeiculo.Name = "btnRemoverVeiculo";
            this.btnRemoverVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverVeiculo.TabIndex = 3;
            this.btnRemoverVeiculo.Text = "Remover";
            this.btnRemoverVeiculo.UseVisualStyleBackColor = true;
            this.btnRemoverVeiculo.Click += new System.EventHandler(this.removerVeiculo);
            // 
            // listaVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 638);
            this.Controls.Add(this.btnRemoverVeiculo);
            this.Controls.Add(this.btnEditarVeiculo);
            this.Controls.Add(this.btnCadastrarVeiculo);
            this.Controls.Add(this.dataGridVeiculos);
            this.Name = "listaVeiculo";
            this.Text = "Lista de Veiculo";
            this.Load += new System.EventHandler(this.listarVeiculos);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVeiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVeiculos;
        private System.Windows.Forms.Button btnCadastrarVeiculo;
        private System.Windows.Forms.Button btnEditarVeiculo;
        private System.Windows.Forms.Button btnRemoverVeiculo;
    }
}