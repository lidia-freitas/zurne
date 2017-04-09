namespace Views
{
    partial class listaMotocicleta
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
            this.btnCadastrarMotocicleta = new System.Windows.Forms.Button();
            this.btnEditarMotocicleta = new System.Windows.Forms.Button();
            this.btnRemoverMotocicleta = new System.Windows.Forms.Button();
            this.dataGridMotocicletas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMotocicletas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarMotocicleta
            // 
            this.btnCadastrarMotocicleta.Location = new System.Drawing.Point(13, 30);
            this.btnCadastrarMotocicleta.Name = "btnCadastrarMotocicleta";
            this.btnCadastrarMotocicleta.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarMotocicleta.TabIndex = 0;
            this.btnCadastrarMotocicleta.Text = "Nova";
            this.btnCadastrarMotocicleta.UseVisualStyleBackColor = true;
            this.btnCadastrarMotocicleta.Click += new System.EventHandler(this.cadastrarMotocicleta);
            // 
            // btnEditarMotocicleta
            // 
            this.btnEditarMotocicleta.Location = new System.Drawing.Point(95, 29);
            this.btnEditarMotocicleta.Name = "btnEditarMotocicleta";
            this.btnEditarMotocicleta.Size = new System.Drawing.Size(75, 23);
            this.btnEditarMotocicleta.TabIndex = 1;
            this.btnEditarMotocicleta.Text = "Editar";
            this.btnEditarMotocicleta.UseVisualStyleBackColor = true;
            this.btnEditarMotocicleta.Click += new System.EventHandler(this.editarMotocicleta);
            // 
            // btnRemoverMotocicleta
            // 
            this.btnRemoverMotocicleta.Location = new System.Drawing.Point(177, 29);
            this.btnRemoverMotocicleta.Name = "btnRemoverMotocicleta";
            this.btnRemoverMotocicleta.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverMotocicleta.TabIndex = 2;
            this.btnRemoverMotocicleta.Text = "Remover";
            this.btnRemoverMotocicleta.UseVisualStyleBackColor = true;
            this.btnRemoverMotocicleta.Click += new System.EventHandler(this.removerMotocicleta);
            // 
            // dataGridMotocicletas
            // 
            this.dataGridMotocicletas.AllowUserToAddRows = false;
            this.dataGridMotocicletas.AllowUserToDeleteRows = false;
            this.dataGridMotocicletas.AllowUserToOrderColumns = true;
            this.dataGridMotocicletas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMotocicletas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMotocicletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMotocicletas.Location = new System.Drawing.Point(13, 73);
            this.dataGridMotocicletas.MultiSelect = false;
            this.dataGridMotocicletas.Name = "dataGridMotocicletas";
            this.dataGridMotocicletas.ReadOnly = true;
            this.dataGridMotocicletas.Size = new System.Drawing.Size(1194, 549);
            this.dataGridMotocicletas.TabIndex = 3;
            this.dataGridMotocicletas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.selecionarMotocicleta);
            // 
            // listaMotocicleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 634);
            this.Controls.Add(this.dataGridMotocicletas);
            this.Controls.Add(this.btnRemoverMotocicleta);
            this.Controls.Add(this.btnEditarMotocicleta);
            this.Controls.Add(this.btnCadastrarMotocicleta);
            this.Name = "listaMotocicleta";
            this.Text = "Lista de Motocicleta";
            this.Load += new System.EventHandler(this.listarMotocicletas);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMotocicletas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarMotocicleta;
        private System.Windows.Forms.Button btnEditarMotocicleta;
        private System.Windows.Forms.Button btnRemoverMotocicleta;
        private System.Windows.Forms.DataGridView dataGridMotocicletas;
    }
}