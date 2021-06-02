
namespace AppSped
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.opUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.opFim = new System.Windows.Forms.ToolStripMenuItem();
            this.opArquivos = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leituraEAnáliseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opCadastros,
            this.opArquivos,
            this.janelasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.janelasToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opCadastros
            // 
            this.opCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opUsuarios,
            this.toolStripSeparator1,
            this.opFim});
            this.opCadastros.Name = "opCadastros";
            this.opCadastros.Size = new System.Drawing.Size(71, 20);
            this.opCadastros.Text = "Cadastros";
            // 
            // opUsuarios
            // 
            this.opUsuarios.Name = "opUsuarios";
            this.opUsuarios.Size = new System.Drawing.Size(119, 22);
            this.opUsuarios.Text = "Usuários";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(116, 6);
            // 
            // opFim
            // 
            this.opFim.Name = "opFim";
            this.opFim.Size = new System.Drawing.Size(119, 22);
            this.opFim.Text = "Fim";
            // 
            // opArquivos
            // 
            this.opArquivos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leituraEAnáliseToolStripMenuItem});
            this.opArquivos.Name = "opArquivos";
            this.opArquivos.Size = new System.Drawing.Size(66, 20);
            this.opArquivos.Text = "Arquivos";
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.janelasToolStripMenuItem.Text = "Janelas";
            // 
            // leituraEAnáliseToolStripMenuItem
            // 
            this.leituraEAnáliseToolStripMenuItem.Name = "leituraEAnáliseToolStripMenuItem";
            this.leituraEAnáliseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.leituraEAnáliseToolStripMenuItem.Text = "Leitura E Análise";
            this.leituraEAnáliseToolStripMenuItem.Click += new System.EventHandler(this.leituraEAnáliseToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.Text = "Formulário Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opCadastros;
        private System.Windows.Forms.ToolStripMenuItem opUsuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem opFim;
        private System.Windows.Forms.ToolStripMenuItem opArquivos;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leituraEAnáliseToolStripMenuItem;
    }
}

