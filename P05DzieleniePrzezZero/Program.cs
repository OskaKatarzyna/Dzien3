using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05DzieleniePrzezZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 0;
            int c = a / b; //dzielenie double przez 0 daje blad

            double d = 12;
            double e = 0;
            double f = d / e; //dzielenie double przez 0 daje nieskończoność
        }
    }
}
