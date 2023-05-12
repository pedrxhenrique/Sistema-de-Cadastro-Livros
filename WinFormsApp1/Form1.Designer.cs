namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuaplicacao = new System.Windows.Forms.MenuStrip();
            this.cadastroMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcoesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuaplicacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuaplicacao
            // 
            this.menuaplicacao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroMenuItem,
            this.opcoesMenuItem});
            this.menuaplicacao.Location = new System.Drawing.Point(0, 0);
            this.menuaplicacao.Name = "menuaplicacao";
            this.menuaplicacao.Size = new System.Drawing.Size(800, 24);
            this.menuaplicacao.TabIndex = 1;
            this.menuaplicacao.Text = "menuStrip1";
            // 
            // cadastroMenuItem
            // 
            this.cadastroMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosMenuItem});
            this.cadastroMenuItem.Name = "cadastroMenuItem";
            this.cadastroMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroMenuItem.Text = "Cadastro";
            // 
            // livrosMenuItem
            // 
            this.livrosMenuItem.Name = "livrosMenuItem";
            this.livrosMenuItem.Size = new System.Drawing.Size(180, 22);
            this.livrosMenuItem.Text = "Livros";
            this.livrosMenuItem.Click += new System.EventHandler(this.livrosMenuItem_Click);
            // 
            // opcoesMenuItem
            // 
            this.opcoesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siteMenuItem});
            this.opcoesMenuItem.Name = "opcoesMenuItem";
            this.opcoesMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opcoesMenuItem.Text = "Opcoes";
            this.opcoesMenuItem.Click += new System.EventHandler(this.opcoesToolStripMenuItem_Click);
            // 
            // siteMenuItem
            // 
            this.siteMenuItem.Name = "siteMenuItem";
            this.siteMenuItem.Size = new System.Drawing.Size(93, 22);
            this.siteMenuItem.Text = "Site";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuaplicacao);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuaplicacao;
            this.Name = "Form1";
            this.Text = "Sebo";
            this.menuaplicacao.ResumeLayout(false);
            this.menuaplicacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuaplicacao;
        private ToolStripMenuItem cadastroMenuItem;
        private ToolStripMenuItem livrosMenuItem;
        private ToolStripMenuItem opcoesMenuItem;
        private ToolStripMenuItem siteMenuItem;
    }
}