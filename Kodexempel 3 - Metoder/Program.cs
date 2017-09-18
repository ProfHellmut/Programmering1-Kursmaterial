using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Anropar metoden Addition som returnerar
            // summan av två tal och lägger värdet i 
            // variabeln "summa"
            int summa = Addition(5, 3);

            // Anropar metoden PrintTenTimes och tar in
            // en sträng som argument. Skriver ut texten
            // 10 gånger
            PrintTenTimes("Arvid");

            Console.WriteLine(summa);

            Console.ReadLine();
        }

        // En metod som utför simpel addition på heltal
        // Tar in två integer som argument och
        // returnerar summan av dessa två tal
        public static int Addition(int tal1, int tal2)
        {
            int summa = tal1 + tal2;
            return summa;
        }

        // En metod som tar in en sträng som sedan
        // skrivs ut 10 gånger till vår konsol
        // Inget returvärde
        public static void PrintTenTimes(string text)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(text);
            }
        }
    }
}
