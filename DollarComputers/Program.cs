using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public static class Program
    {
        public static SplashScreen MySplashScreen;

        public static StartForm MyStartForm;

        public static SelectForm MySelectForm;

        public static ProductInfoForm MyProductInfoForm;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Program.MySplashScreen = new SplashScreen();
            Program.MyStartForm = new StartForm();
            Program.MySelectForm = new SelectForm();
            Program.MyProductInfoForm = new ProductInfoForm();

            Application.Run(Program.MySplashScreen);
        }
    }
}
