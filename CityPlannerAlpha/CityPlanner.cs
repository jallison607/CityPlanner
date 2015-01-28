using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class CityPlanner
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        public static Random r = new Random();

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
