using AppSped.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSped
{
    public class MDISingleton
    {
        private MDISingleton() { }

        private static FormPrincipal instanceFormPrincipal;

        public static FormPrincipal MDIParentPrincipal(Usuario usuario)
        {

            if (instanceFormPrincipal == null)
            {

                instanceFormPrincipal = new FormPrincipal(usuario);

                instanceFormPrincipal.WindowState = System.Windows.Forms.FormWindowState.Maximized;

                return instanceFormPrincipal;

            }

            return instanceFormPrincipal;

        }
    }
}
