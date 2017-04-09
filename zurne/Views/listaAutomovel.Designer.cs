namespace Views
{
    partial class listaAutomovel
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
            this.btnCadastrarAutomovel = new System.Windows.Forms.Button();
            this.btnEditarAutomovel = new System.Windows.Forms.Button();
            this.btnRemoverAutomovel = new System.Windows.Forms.Button();
            this.dataGridAutomoveis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutomoveis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarAutomovel
            // 
            this.btnCadastrarAutomovel.Location = new System.Drawing.Point(12, 28);
            this.btnCadastrarAutomovel.Name = "btnCadastrarAutomovel";
            this.btnCadastrarAutomovel.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarAutomovel.TabIndex = 0;
            this.btnCadastrarAutomovel.Text = "Novo";
            this.btnCadastrarAutomovel.UseVisualStyleBackColor = true;
            this.btnCadastrarAutomovel.Click += new System.EventHandler(this.cadastrarAutomovel);
            // 
            // btnEditarAutomovel
            // 
            this.btnEditarAutomovel.Location = new System.Drawing.Point(93, 28);
            this.btnEditarAutomovel.Name = "btnEditarAutomovel";
            this.btnEditarAutomovel.Size = new System.Drawing.Size(75, 23);
            this.btnEditarAutomovel.TabIndex = 1;
            this.btnEditarAutomovel.Text = "Editar";
            this.btnEditarAutomovel.UseVisualStyleBackColor = true;
            this.btnEditarAutomovel.Click += new System.EventHandler(this.editarAutomovel);
            // 
            // btnRemoverAutomovel
            // 
            this.btnRemoverAutomovel.Location = new System.Drawing.Point(174, 28);
            this.btnRemoverAutomovel.Name = "btnRemoverAutomovel";
            this.btnRemoverAutomovel.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverAutomovel.TabIndex = 2;
            this.btnRemoverAutomovel.Text = "Remover";
            this.btnRemoverAutomovel.UseVisualStyleBackColor = true;
            this.btnRemoverAutomovel.Click += new System.EventHandler(this.removerAutomovel);
            // 
            // dataGridAutomoveis
            // 
            this.dataGridAutomoveis.AllowUserToAddRows = false;
            this.dataGridAutomoveis.AllowUserToDeleteRows = false;
            this.dataGridAutomoveis.AllowUserToOrderColumns = true;
            this.dataGridAutomoveis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAutomoveis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAutomoveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAutomoveis.Location = new System.Drawing.Point(12, 77);
            this.dataGridAutomoveis.Name = "dataGridAutomoveis";
            this.dataGridAutomoveis.Size = new System.Drawing.Size(1190, 543);
            this.dataGridAutomoveis.TabIndex = 3;
            this.dataGridAutomoveis.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.selecionarAutomovel);
            // 
            // listaAutomovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 632);
            this.Controls.Add(this.dataGridAutomoveis);
            this.Controls.Add(this.btnRemoverAutomovel);
            this.Controls.Add(this.btnEditarAutomovel);
            this.Controls.Add(this.btnCadastrarAutomovel);
            this.Name = "listaAutomovel";
            this.Text = "Lista de Automoveis";
            this.Load += new System.EventHandler(this.listarAutomoveis);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAutomoveis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarAutomovel;
        private System.Windows.Forms.Button btnEditarAutomovel;
        private System.Windows.Forms.Button btnRemoverAutomovel;
        private System.Windows.Forms.DataGridView dataGridAutomoveis;
    }
}