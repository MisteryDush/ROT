using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROT13
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
            Application.Run(new Form1());
        }

        public static string Rot(string input, bool mode, int steps)
        {
            if (mode)
            {
                var result = string.Empty;
                const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                const string lower = "abcdefghijklmnopqrstuvwxyz";
                foreach (var ch in input)
                {
                    if (!char.IsLetter(ch))
                    {
                        result += ch;
                        continue;
                    } 
                    var set = char.IsUpper(ch) ? upper : lower;
                    var letter = set[(set.IndexOf(ch) + steps) % 26];
                    result += letter;
                }

                return result;
            }
            else
            {

                var result = string.Empty;
                const string upper = "ZYXWVUTSRQPONMLKJIHGFEDCBA";
                const string lower = "zyxwvutsrqponmlkjihgfedcba";
                foreach (var ch in input)
                {
                    if (!char.IsLetter(ch))
                    {
                        result += ch;
                        continue;
                    }

                    var set = char.IsUpper(ch) ? upper : lower;
                    var letter = set[(set.IndexOf(ch) + steps) % 26];
                    result += letter;
                }

                return result;
            }
        }
    }
}