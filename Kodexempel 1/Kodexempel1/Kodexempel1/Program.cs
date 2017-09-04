using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodexempel1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Random text";

            Console.WriteLine(text);

            text = Console.ReadLine().ToLower();

            if(text == "hej")
            {
                Console.WriteLine("Hej du med!");
            }
            else if(text == "katt")
            {
                Console.WriteLine("Hund");
            }
            else {
                Console.WriteLine("Blabla");    

            }

            Console.WriteLine("Skriv in ett tal 1-3");
            int tal = int.Parse(Console.ReadLine());

            // Vi demonstrerar en switch-sats
            switch (tal)
            {
                // Om tal är lika med 1
                case 1:
                    // Skriv ut menyval1 till konsollen och addera till tal
                    Console.WriteLine("Menyval 1");
                    tal += tal;
                    Console.WriteLine(tal);
                    break;
                case 2:
                    Console.WriteLine("Menyval 2");
                    tal *= tal;
                    Console.WriteLine(tal);
                    break;
                case 3:
                    Console.WriteLine("Menyval 3");
                    tal -= tal + 1;
                    Console.WriteLine(tal);
                    break;
            }
            

            // Vänta på input för att undvika att
            // programmet stänger ner
            Console.ReadLine();
        }
    }
}
