using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using StudentManagementSystem2._0.Data_Layer;
using StudentManagementSystem2._0.Business_Logic_Layer;
using StudentManagementSystem2._0.Presentation_Layer;

namespace StudentManagementSystem2._0
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}