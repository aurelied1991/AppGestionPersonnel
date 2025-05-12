using System;
using System.Windows.Forms;

namespace AppGestionPersonnel
{
    /// <summary>
    /// Application de gestion du personnel et des absences
    /// </summary>
    internal class AppGestionPersonnelDoc
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
            Application.Run(new view.FrmAuthentification());
        }
    }
}
