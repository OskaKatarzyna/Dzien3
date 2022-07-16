using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08DostepDoPlikow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zawartosc = "ala ma kota\ni ma psa\ni jeszcze rybki";
            File.WriteAllText("c:\\dane\\plik.txt",zawartosc); //zawsze dwa razy \\
            File.WriteAllText(@"c:\dane\plik2.txt", zawartosc);
        }
    }
}
