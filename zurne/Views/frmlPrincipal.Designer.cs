namespace Views
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automóvelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motocicletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bicicletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            resources.ApplyResources(this.menuPrincipal, "menuPrincipal");
            this.menuPrincipal.Name = "menuPrincipal";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.funcionarioToolStripMenuItem,
            this.veículoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            resources.ApplyResources(this.cadastrosToolStripMenuItem, "cadastrosToolStripMenuItem");
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            resources.ApplyResources(this.clienteToolStripMenuItem, "clienteToolStripMenuItem");
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.listarClientes);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            resources.ApplyResources(this.funcionarioToolStripMenuItem, "funcionarioToolStripMenuItem");
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.listarFuncionarios);
            // 
            // veículoToolStripMenuItem
            // 
            this.veículoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.automóvelToolStripMenuItem,
            this.motocicletaToolStripMenuItem,
            this.bicicletaToolStripMenuItem});
            this.veículoToolStripMenuItem.Name = "veículoToolStripMenuItem";
            resources.ApplyResources(this.veículoToolStripMenuItem, "veículoToolStripMenuItem");
            // 
            // automóvelToolStripMenuItem
            // 
            this.automóvelToolStripMenuItem.Name = "automóvelToolStripMenuItem";
            resources.ApplyResources(this.automóvelToolStripMenuItem, "automóvelToolStripMenuItem");
            this.automóvelToolStripMenuItem.Click += new System.EventHandler(this.listarAutomoveis);
            // 
            // motocicletaToolStripMenuItem
            // 
            this.motocicletaToolStripMenuItem.Name = "motocicletaToolStripMenuItem";
            resources.ApplyResources(this.motocicletaToolStripMenuItem, "motocicletaToolStripMenuItem");
            this.motocicletaToolStripMenuItem.Click += new System.EventHandler(this.listarMotocicletas);
            // 
            // bicicletaToolStripMenuItem
            // 
            this.bicicletaToolStripMenuItem.Name = "bicicletaToolStripMenuItem";
            resources.ApplyResources(this.bicicletaToolStripMenuItem, "bicicletaToolStripMenuItem");
            this.bicicletaToolStripMenuItem.Click += new System.EventHandler(this.listarBicicletas);
            // 
            // frmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automóvelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motocicletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bicicletaToolStripMenuItem;
    }
}

