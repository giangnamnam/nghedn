using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyThiNghe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            try
            {
                //Application.Run(new Forms.frmMain());
                //Application.Run(new Forms.frmGioiThieu());
                Application.Run(new Forms.frmChiaHoiDongThi());


            }
            catch (Exception)
            {
            }
            
        }
    }
}

