using Shop_Phone2.Brand;
using Shop_Phone2.Category;
using Shop_Phone2.Login;
using Shop_Phone2.People;
using Shop_Phone2.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Phone2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLoginScreen( ));
        }
    }
}
