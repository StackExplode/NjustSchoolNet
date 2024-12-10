using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NjustSchoolNet
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static int Main(string[] args)
        {
            if(args.Length > 0)
            {
                int rt = 0;
                if (args[0].ToLower() == "login")
                    rt = Helpers.Login(args[1], args[2]);
                else if (args[0].ToLower() == "logout")
                    rt = Helpers.Logout();
                else if (args[0].ToLower() == "logauto")
                    rt = Helpers.LogAuto();
                else if (args[0].ToLower() == "dial")
                {
                    if (args.Length > 3)
                        rt = Helpers.Dial(args[1], args[2], args[3]);
                    else if (args.Length == 1)
                        rt = Helpers.Dial("0");
                    else
                        rt = Helpers.Dial(args[1]);
                }
                else if (args[0].ToLower() == "dialauto")
                    rt = Helpers.Dial(null);
                else if (args[0].ToLower() == "hang")
                    rt = Helpers.HangUp(args.Length > 1 ? int.Parse(args[1]) : 0);
                else
                    rt = 160; //Bad argument
                Console.WriteLine(rt);
                return rt;
            }

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            return 0;
        }
    }
}
