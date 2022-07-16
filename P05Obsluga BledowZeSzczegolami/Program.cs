using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05Obsluga_BledowZeSzczegolami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string s = "ala ma kota";
                int a = Convert.ToInt32(s);

                int b = 5;
                int c = 0;
                int d = b / c;

                int[] tab = { 1, 2, 3 };
                int e = tab[3];

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Dzielenie przez 0");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Wyjście poza zakres tablicy");
            }
            catch (FormatException)
            {
                Console.WriteLine("Błąd formatowania");
            }
            catch (Exception)
            {
              Console.WriteLine("Nieznany blad");
            }
            Console.ReadKey();

        }
    }
}
