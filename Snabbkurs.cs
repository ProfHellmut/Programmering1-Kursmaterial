using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresher
{
    class Program
    {
        static void Main(string[] args)
        {
            // variabler/datatyper
            byte heltalKort = 255;
            int tal = 1234;
            long långtTal = 19910529;

            float flyttal1 = 2.12F;
            double flyttal2 = 3.14 * 5;
            decimal pengar = 12.123M;

            char tecken = '@';
            string strängAvTecken = "Hellu";

            bool santEllerFalskt = true;

            int[] talArray = new int[10]; // 0-9

            // Operander och beslut
            if (flyttal1 <= flyttal2)
                Console.WriteLine("Hellu");
            
            // ! - Not-operand.
            if (!santEllerFalskt)
                Console.WriteLine("Inte sant!");

            if ( (santEllerFalskt) && (tal != långtTal) )
                Console.WriteLine("woooh");

            if ( (flyttal1 == 2) || (flyttal1 != 4) )
                Console.WriteLine("Wiie");
            else if (!santEllerFalskt)          // Ett till argument
                Console.WriteLine("Do this");
            else
                Console.WriteLine("blabla");    // Annars do this

            // "(argument || argument)" en måste vara true
            // &&
            // "(argument && argument)" båda måste vara true
            // Om båda blocken resulterar i true körs koden
            if ( (flyttal1 > 2.4 || flyttal1 == 3) && (flyttal2 > 3 && santEllerFalskt) )
                Console.WriteLine("Kaos!");


            switch (tecken)
            {
                case '@':
                    Console.WriteLine();
                    break;

                case '"':
                    Console.WriteLine();
                    break;

                default:        // Om inget stämmer, kör default, default behövs ej
                    Console.WriteLine();
                    break;
            }

            // Loopar

            // Först "int i = 0" tilldelar vi värdet 0 till vår räknare "i"
            // Sen kollar vi om "i < 10", om sant, kör koden
            // Sedan inkrementerar vi "i" med 1. i++
            // Sedan kollar vi argumentet "i < 10" igen, om sant, kör kod
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Katt");
            }

            // För varje int "nummer" i talArray
            // Kör koden inuti
            foreach (int nummer in talArray)
            {
                if (nummer % 2 == 0) // om talet är 40. 40 / 2 == 20, rest 0
                    Console.WriteLine();
            }

            // Körs så länge argumentet är sant
            while (tal < 10)
            {
                Console.WriteLine();
            }

            // Precis som while, fast kör koden minst EN gång
            do
            {
                Console.WriteLine();
            }
            while (tal < 10);

            // Arrays!
            string[] namn = new string[5];
            namn[0] = "Slarvid";
            namn[1] = "Marsus";
            namn[2] = "Eddie";
            namn[3] = "Viktor";
            namn[4] = "Doktorn";

            string[] efternamn = new string[] { "Nordin", "Forsberg", "Bonde" };

            int[] femmans = new int[10];

            for (int i = 0; i < 10; i++)
            {
                femmans[i] = 5 * (i + 1);
            }         
        }

        // Metoder/funktioner
        // Accesstyp static/dynamisk returvärde namn (indata)
        public static int TalKonverterare(string input)
        {
            int tal = int.Parse(input);

            return tal;
        }

        // Inget returvärde
        public static void Koolmetod()
        {
            int tal = TalKonverterare("12");
            Console.WriteLine("Metoooooood");
        }

        // Metoder används när vi vill gruppera kod för återanvändning, 
        // läsbarhet
    }
}
