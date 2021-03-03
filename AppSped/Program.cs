using AppSped.Models;
using System;
using System.Windows.Forms;

namespace AppSped
{
    static class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            Usuario user = new Usuario();

            user.Codigo = 1;
            user.Razao = "ADM";
            user.Senha = "123456";
            /*
            if (args.Length == 0)
            {
                RunCommand.SetarBanco("SERVIDOR");
            }
            else
            {
                RunCommand.SetarBanco(args[0]);
            }
            */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MDISingleton.MDIParentPrincipal(user));

            /*
            FormLogin Login = null;

            Login = new FormLogin();

            if (Login.ShowDialog() == DialogResult.OK)
            {

                Application.Run(MDISingleton.MDIParentPrincipal(Login.usuario));

            }
            */
        }
    }
}
