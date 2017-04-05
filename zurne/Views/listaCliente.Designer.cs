namespace Views
{
    partial class listaCliente
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
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.dataGridClientesPF = new System.Windows.Forms.DataGridView();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnRemoverCliente = new System.Windows.Forms.Button();
            this.dataGridClientesPJ = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientesPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientesPJ)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(21, 22);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarCliente.TabIndex = 0;
            this.btnCadastrarCliente.Text = "Novo";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.cadastrarCliente);
            // 
            // dataGridClientesPF
            // 
            this.dataGridClientesPF.AllowUserToAddRows = false;
            this.dataGridClientesPF.AllowUserToDeleteRows = false;
            this.dataGridClientesPF.AllowUserToOrderColumns = true;
            this.dataGridClientesPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridClientesPF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClientesPF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientesPF.Location = new System.Drawing.Point(12, 94);
            this.dataGridClientesPF.MultiSelect = false;
            this.dataGridClientesPF.Name = "dataGridClientesPF";
            this.dataGridClientesPF.ReadOnly = true;
            this.dataGridClientesPF.Size = new System.Drawing.Size(536, 535);
            this.dataGridClientesPF.TabIndex = 3;
            this.dataGridClientesPF.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.selecionarClientePF);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(115, 22);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCliente.TabIndex = 4;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.editarCliente);
            // 
            // btnRemoverCliente
            // 
            this.btnRemoverCliente.Location = new System.Drawing.Point(211, 22);
            this.btnRemoverCliente.Name = "btnRemoverCliente";
            this.btnRemoverCliente.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverCliente.TabIndex = 5;
            this.btnRemoverCliente.Text = "Remover";
            this.btnRemoverCliente.UseVisualStyleBackColor = true;
            this.btnRemoverCliente.Click += new System.EventHandler(this.removerCliente);
            // 
            // dataGridClientesPJ
            // 
            this.dataGridClientesPJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridClientesPJ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClientesPJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientesPJ.Location = new System.Drawing.Point(554, 94);
            this.dataGridClientesPJ.Name = "dataGridClientesPJ";
            this.dataGridClientesPJ.Size = new System.Drawing.Size(580, 535);
            this.dataGridClientesPJ.TabIndex = 6;
            // 
            // listaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 641);
            this.Controls.Add(this.btnRemoverCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.dataGridClientesPJ);
            this.Controls.Add(this.dataGridClientesPF);
            this.Name = "listaCliente";
            this.Text = "Lista de Clientes";
            this.Load += new System.EventHandler(this.listaClientesLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientesPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientesPJ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.DataGridView dataGridClientesPF;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnRemoverCliente;
        private System.Windows.Forms.DataGridView dataGridClientesPJ;
    }
}