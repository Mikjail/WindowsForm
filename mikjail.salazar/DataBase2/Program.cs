using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase2
{
    static class Program
    {
        public static System.Data.DataSet dsADO_2015;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            dsADO_2015 = new System.Data.DataSet();
            Application.Run(new frmPrincipal());

        }
    }
}
