using P03AplikacjaKalkulator.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaKalkulator.Tools
{
    internal class Kalkulator
    {
        public double WykonajDzialanie(string rownanie)
        {
            int pozycjaPlus = rownanie.IndexOf('+');
            int pozycjaMinus = rownanie.IndexOf('-');
            int pozycjaMnozenie = rownanie.IndexOf('*');
            int pozycjaDzielenie = rownanie.IndexOf('/');


            if (pozycjaPlus > -1)
            {
                int liczbaB = Convert.ToInt32(rownanie.Substring(pozycjaPlus + 1));
                int liczbaA = Convert.ToInt32(rownanie.Substring(0, pozycjaPlus));

                int wynik = liczbaA + liczbaB;
                return wynik;
            }
            else if (pozycjaMinus > -1)
            {
                int liczbaB = Convert.ToInt32(rownanie.Substring(pozycjaMinus + 1));
                int liczbaA = Convert.ToInt32(rownanie.Substring(0, pozycjaMinus));

                int wynik = liczbaA - liczbaB;
                return wynik;
            }
            else if (pozycjaMnozenie > -1)
            {
                int liczbaB = Convert.ToInt32(rownanie.Substring(pozycjaMnozenie + 1));
                int liczbaA = Convert.ToInt32(rownanie.Substring(0, pozycjaMnozenie));

                int wynik = liczbaA * liczbaB;
                return wynik;
            }
            else if (pozycjaDzielenie > -1)
            {
                string podciag = rownanie.Substring(pozycjaDzielenie + 1);
                double liczbaB = Convert.ToDouble(podciag);
                int liczbaA = Convert.ToInt32(rownanie.Substring(0, pozycjaDzielenie));

                double wynik = liczbaA / liczbaB;
                if (double.IsInfinity(wynik)) //dzielenie przy double daje Ifinity
                    throw new DivideByZeroException();

                return wynik;
            }
            else
            {
                throw new InvalidOperatorException();
            }

        }
    }
}
