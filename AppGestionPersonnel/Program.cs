using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionPersonnel
{
    /// <summary>
    /// Application de gestion du personnel et des absences
    /// </summary>
    internal class NamesSpaceDoc
    {
    }

    /// <summary>
    /// Classe principale de l'application
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmAuthentification());
        }
    }
}
