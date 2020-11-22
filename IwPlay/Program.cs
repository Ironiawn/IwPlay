using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IwPlay.Systems;

namespace IwPlay
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Verifica se a máquina rodando a IwPlay é VM
            // Negar acesso, caso for
            if (IwP_Main_Security.IsVM)
                Application.Exit();

            Application.Run(new IwPlay.IwP_Login());
        }
    }
}
