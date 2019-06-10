using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionIstaLibrary;
using GestionIstaLibrary.Model;
namespace GestionIsta
{
    static class Program
    {
        public static UserModel User;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            GlobalConfig.SetConnection(ConnectionType.SqlServer);
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
