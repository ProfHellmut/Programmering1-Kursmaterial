using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jag behöver en integer, se till att skapa
            // plats på minnet för att kunna lagra int-värden
            int myFirstInteger;

            // Tilldela ett värde
            myFirstInteger = 10;

            // Går att deklarera och tilldela på samma rad
            int mySecondInteger = 20;
            
            // Om 10 är större än 20
            if (myFirstInteger > mySecondInteger)
            {
                // Skriv ut till konsollen
                Console.WriteLine("Det är sant!");
            }
            else // Annars
            {
                // Skriv ut till konsollen
                Console.WriteLine("Det är inte sant!");
            }

            // Lagrar en sträng text
            string marcusForsberg = "Marcus";

            // Tar in ett input från konsollen och
            // lagrar värdet i userInput
            string userInput = Console.ReadLine();

            // Jämför värdena i userInput(vår text från konsollen)
            // och värdet i variabeln marcusForsberg
            if (userInput == marcusForsberg)
            {
                // Om korrekt så skriver vi ut en sträng till konsollen
                Console.WriteLine("Värdena är lika, men marcus är felstavat");
            }
            else // annars
            {
                // Så skriver vi ut en annan sträng
                Console.WriteLine("Värdena är inte lika!");
            }

            // Skapa char-variabler, lagrar ETT tecken
            char myFirstChar = '@';
            char mySecondChar = 'L';

            // Om variablerna INTE är lika
            if (myFirstChar != mySecondChar)
            {
                Console.WriteLine("Det är korrekt, dom är inte lika");
            }
            else
            {
                Console.WriteLine("Dom är lika");
            }
            
            // Vi använder int.Parse för att översätta strängen
            // som kommer från ReadLine() till en integer
            // int.Parse är osäker kod då den kan leda till programkrasch
            int switchTal = int.Parse(Console.ReadLine());
            
            // switch (argument) <- vårat tal som ska jämföras
            switch (switchTal)
            {
                // Kolla om switchTal är 1, om sant, kör koden nedanför
                case 1:
                    Console.WriteLine("Du skrev 1!");
                    break; // hoppa ur vår switch

                case 2:
                    Console.WriteLine("Du skrev 2!");
                    break;

                case 3:
                    Console.WriteLine("Du skrev 3!");
                    break;

                default: // Om inget stämmer, kör denna kod
                    Console.WriteLine("Du skrev: " + switchTal);
                    break;
            }



            // Failsafe så programmet inte stänger ner
            Console.ReadLine();
        }
    }
}
