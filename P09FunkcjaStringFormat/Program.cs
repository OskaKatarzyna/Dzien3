using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09FunkcjaStringFormat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wiek = 30;
            int waga = 50;
            DateTime dataUr = new DateTime(2000, 01, 12);

            string raport = "Jan Kowalski ma " + wiek + " lat" + " waży" + waga + " kg";
            string raport2 = $"Jan Kowalski ma { wiek} lat waży { waga} kg";
            string raport3 = string.Format( "Jan Kowalski ma {0:00.00} lat i waży {1:000 000}kg. Jego data urodzenia to {2:dd-MMMM-yyy} ", wiek, waga,dataUr);

            Console.WriteLine( raport3);
            Console.ReadKey();

            //dd dzien
            // MM miesiac lub MMM lub MMMM
            // yyyy rok
            //ss - sekundy
            //mm minuty
            //hh godziny

        }
    }
}
