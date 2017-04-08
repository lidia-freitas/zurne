namespace Views
{
    partial class listaFuncionario
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
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnEditarFuncionario = new System.Windows.Forms.Button();
            this.btnRemoverFuncionario = new System.Windows.Forms.Button();
            this.dataGridFuncionarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(14, 24);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarFuncionario.TabIndex = 0;
            this.btnCadastrarFuncionario.Text = "Novo";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.cadastrarFuncionario);
            // 
            // btnEditarFuncionario
            // 
            this.btnEditarFuncionario.Location = new System.Drawing.Point(107, 23);
            this.btnEditarFuncionario.Name = "btnEditarFuncionario";
            this.btnEditarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnEditarFuncionario.TabIndex = 1;
            this.btnEditarFuncionario.Text = "Editar";
            this.btnEditarFuncionario.UseVisualStyleBackColor = true;
            this.btnEditarFuncionario.Click += new System.EventHandler(this.editarFuncionario);
            // 
            // btnRemoverFuncionario
            // 
            this.btnRemoverFuncionario.Location = new System.Drawing.Point(202, 22);
            this.btnRemoverFuncionario.Name = "btnRemoverFuncionario";
            this.btnRemoverFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverFuncionario.TabIndex = 2;
            this.btnRemoverFuncionario.Text = "Remover";
            this.btnRemoverFuncionario.UseVisualStyleBackColor = true;
            this.btnRemoverFuncionario.Click += new System.EventHandler(this.removerFuncionario);
            // 
            // dataGridFuncionarios
            // 
            this.dataGridFuncionarios.AllowUserToAddRows = false;
            this.dataGridFuncionarios.AllowUserToDeleteRows = false;
            this.dataGridFuncionarios.AllowUserToOrderColumns = true;
            this.dataGridFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFuncionarios.Location = new System.Drawing.Point(13, 74);
            this.dataGridFuncionarios.MultiSelect = false;
            this.dataGridFuncionarios.Name = "dataGridFuncionarios";
            this.dataGridFuncionarios.ReadOnly = true;
            this.dataGridFuncionarios.Size = new System.Drawing.Size(1200, 554);
            this.dataGridFuncionarios.TabIndex = 3;
            this.dataGridFuncionarios.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.selecionarFuncionario);
            // 
            // listaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 640);
            this.Controls.Add(this.dataGridFuncionarios);
            this.Controls.Add(this.btnRemoverFuncionario);
            this.Controls.Add(this.btnEditarFuncionario);
            this.Controls.Add(this.btnCadastrarFuncionario);
            this.Name = "listaFuncionario";
            this.Text = "Lista de Funcionários";
            this.Load += new System.EventHandler(this.listarFuncionarios);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.Button btnEditarFuncionario;
        private System.Windows.Forms.Button btnRemoverFuncionario;
        private System.Windows.Forms.DataGridView dataGridFuncionarios;
    }
}