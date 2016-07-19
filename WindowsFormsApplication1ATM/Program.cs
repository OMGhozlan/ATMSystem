using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        public static int NameHasher(String s1, String s2, String s3)
        {
            int hashed = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                hashed += (int)s1.ElementAt(i);
            }
            hashed += s1.Length;
            for (int i = 0; i < s2.Length; i++)
            {
                hashed += (int)s2.ElementAt(i);
            }
            hashed += s2.Length;
            for (int i = 0; i < s3.Length; i++)
            {
                hashed += (int)s3.ElementAt(i);
            }
            hashed += s3.Length;
            return hashed;
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
