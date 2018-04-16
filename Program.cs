using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolfWatch
{
    static class Program
    {

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splashForm = new SplashScreen();
            Application.Run(splashForm);
        }

        public static SplashScreen splashForm;
        public static WolfWatchMetro mainForm;

    }
}
