using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ObsługaBledow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 0;

            try
            {
                double c = a / b;
            }
            catch (Exception)
            {

                Console.WriteLine("Podane niepoprawne wartości liczbowe");
            }

            try
            {
                double c = a / b;
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Podane niepoprawne wartości liczbowe. Szczegóły błędu: "+ex.Message);
            }

            Console.ReadKey();
            
        }
    }
}
