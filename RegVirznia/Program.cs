using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace RegVirznia
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter write = new StreamWriter("file2.txt");
            Regex regex = new Regex(@"(0[1-9]|1[12])\.(0[1-9]|[12][0-9]|3[01])\.([0-9]{4})");
            string text = File.ReadAllText("file.txt");
            foreach (Match match in regex.Matches(text))
            {
                if (match.Length != 0)
                {
                    write.WriteLine(match.ToString());
                }
            }
            write.Close();
        }
    }
}
