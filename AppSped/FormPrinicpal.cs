using AppSped.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSped
{
    public partial class FormPrincipal : Form
    {
        private FormArquivos _formArquivos;

        public FormPrincipal(Usuario user)
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void leituraEAnáliseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _formArquivos = new FormArquivos();

                ((System.Windows.Forms.ToolStripMenuItem)sender).Enabled = false;

                _formArquivos.MdiParent = this;

                _formArquivos.menu = (ToolStripMenuItem)sender;

                _formArquivos.WindowState = FormWindowState.Maximized;

                _formArquivos.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção!");
            }

        }
    }
}
