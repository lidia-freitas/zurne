namespace Views
{
    partial class listaBicicleta
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
            this.dataGridBicicletas = new System.Windows.Forms.DataGridView();
            this.btnCadastrarBicicleta = new System.Windows.Forms.Button();
            this.btnEditarBicicleta = new System.Windows.Forms.Button();
            this.btnRemoverBicicleta = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBicicletas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBicicletas
            // 
            this.dataGridBicicletas.AllowUserToAddRows = false;
            this.dataGridBicicletas.AllowUserToDeleteRows = false;
            this.dataGridBicicletas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBicicletas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBicicletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBicicletas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id});
            this.dataGridBicicletas.Location = new System.Drawing.Point(13, 80);
            this.dataGridBicicletas.MultiSelect = false;
            this.dataGridBicicletas.Name = "dataGridBicicletas";
            this.dataGridBicicletas.ReadOnly = true;
            this.dataGridBicicletas.Size = new System.Drawing.Size(1192, 544);
            this.dataGridBicicletas.TabIndex = 0;
            this.dataGridBicicletas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.selecionarBicicleta);
            // 
            // btnCadastrarBicicleta
            // 
            this.btnCadastrarBicicleta.Location = new System.Drawing.Point(13, 40);
            this.btnCadastrarBicicleta.Name = "btnCadastrarBicicleta";
            this.btnCadastrarBicicleta.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarBicicleta.TabIndex = 1;
            this.btnCadastrarBicicleta.Text = "Nova";
            this.btnCadastrarBicicleta.UseVisualStyleBackColor = true;
            this.btnCadastrarBicicleta.Click += new System.EventHandler(this.cadastrarBicicleta);
            // 
            // btnEditarBicicleta
            // 
            this.btnEditarBicicleta.Location = new System.Drawing.Point(104, 39);
            this.btnEditarBicicleta.Name = "btnEditarBicicleta";
            this.btnEditarBicicleta.Size = new System.Drawing.Size(75, 23);
            this.btnEditarBicicleta.TabIndex = 2;
            this.btnEditarBicicleta.Text = "Editar";
            this.btnEditarBicicleta.UseVisualStyleBackColor = true;
            this.btnEditarBicicleta.Click += new System.EventHandler(this.editarBicicleta);
            // 
            // btnRemoverBicicleta
            // 
            this.btnRemoverBicicleta.Location = new System.Drawing.Point(203, 39);
            this.btnRemoverBicicleta.Name = "btnRemoverBicicleta";
            this.btnRemoverBicicleta.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverBicicleta.TabIndex = 3;
            this.btnRemoverBicicleta.Text = "Remover";
            this.btnRemoverBicicleta.UseVisualStyleBackColor = true;
            this.btnRemoverBicicleta.Click += new System.EventHandler(this.removerBicicleta);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // listaBicicleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 636);
            this.Controls.Add(this.btnRemoverBicicleta);
            this.Controls.Add(this.btnEditarBicicleta);
            this.Controls.Add(this.btnCadastrarBicicleta);
            this.Controls.Add(this.dataGridBicicletas);
            this.Name = "listaBicicleta";
            this.Text = "Lista de Bicicletas";
            this.Load += new System.EventHandler(this.listarBicicletas);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBicicletas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridBicicletas;
        private System.Windows.Forms.Button btnCadastrarBicicleta;
        private System.Windows.Forms.Button btnEditarBicicleta;
        private System.Windows.Forms.Button btnRemoverBicicleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}