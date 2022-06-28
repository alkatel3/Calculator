using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool help = true;
            while (help)
            {
                Application.Run(new Form1());
                switch (Form1.Choose)
                {
                    case 1:
                        Application.Run(new Calculator_2());
                        break;
                    case 2:
                        Application.Run(new Calculator_10());
                        break;
                    case 3:
                        Application.Run(new Calculator_16());
                        break;
                    case 0:
                        help = false;
                        break;
                }
            }
        }
    }
}
