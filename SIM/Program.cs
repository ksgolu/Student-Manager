using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM
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

            //Application.Run(new Login(0));
            //Application.Run(new whatsApp());
            // Application.Run(new Form1("satyam"));
            //Application.Run(new SIM_Admin("satyam"));
            //Application.Run(new whatsAppRegistration(2));
            //Application.Run(new Email());
            // Application.Run(new TextMessage());
            Application.Run(new Test());
          
        }
    }
}
