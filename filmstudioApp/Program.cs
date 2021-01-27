using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmstudioApp
{
    static class Program
    {
        private static string _idauth = "";
        public static string Idauth
        {
            get { return _idauth; }
            set { _idauth = value; }
        }
        private static int _id = -1;
        public static int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Auth());
        }
    }
}
