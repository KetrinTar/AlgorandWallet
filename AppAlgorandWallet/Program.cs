using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAlgorandWallet
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
            Application.Run(new SendForm("OE3AVNBKGT5QYQ4MKFA6TQOZXP4EI4TUNEEP7RI5EJLHTXWDGY5AOSL2DM", "e4aebf103fd889c5a8b33541eddc507c1be395f3c819436a567b0b41f2032554"));
        }
    }
}
