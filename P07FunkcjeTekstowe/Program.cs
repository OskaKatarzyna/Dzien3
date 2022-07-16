using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07FunkcjeTekstowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Ala ma kota";

            int dlugosc = s.Length;//liczba znakow

            string podciag = s.Substring(4,2); //"ma"

            string wynik1 =s.ToUpper();//ALA MA KOTA
            string wynik2 = s.ToLower();

            int wynik3 = s.IndexOf("ma");
            int wynik4 = s.IndexOf('a');

            string[] wyrazy = s.Split(' '); //rozbij ciąg na tablice elementów wg separatorow

            string s2 = "ala*^ma*^kota";
            string[] separatory = { "*^" };
            string[] wyrazy2 = s2.Split(separatory,StringSplitOptions.RemoveEmptyEntries);

            string s3 = "ala%^ma$#kota";
            string[] separatory3 = { "%^", "$#" };
            string[] wyrazy3 = s3.Split(separatory3, StringSplitOptions.RemoveEmptyEntries);

            for(int i=0; i<wyrazy3.Length; i++)
                Console.WriteLine(wyrazy3[i]);


            string[] zdanie = { "dzisiaj", "jest", "ładna", "pogoda" };

            string wynik7 = string.Join(" ", zdanie);

            Console.ReadKey();



        }
    }
}
