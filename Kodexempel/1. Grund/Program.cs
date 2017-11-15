using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodexempel1
{
    class Program
    { // Inne i klassen skapar vi metoder, och i metoder skriver vi kod

        static void Main(string[] args)
        { // Main metoden börjar

            // Här skapar vi en variabel av typen "string"(lagrar en sträng av karaktärer)
            // och tilldelar(=) texten "Random text" och avslutar kodsatsen med ";" som kan ses som en punkt i en mening
            string text = "Random text";

            // Här använder vi Console.WriteLine() med variabeln "text"
            // inom parenteserna. Det gör att texten "Random text" skrivs ut till konsollen
            Console.WriteLine(text);

            // Här låter vi användaren skriva in text med hjälp av
            // Console.ReadLine() som läser av ett input användaren skrivit,
            // Därefter ser vi till att all text sparas med små bokstäver med .ToLower()
            // och sedan tilldelas värdet till variabeln text
            text = Console.ReadLine().ToLower();

            // Här används en if-sats för att göra beslut.
            // Här kollar vi om text innehåller värdet "hej", om detta är sant
            // så skriver vi ut "Hej du med!" till konsollen.
            if(text == "hej")
            {
                Console.WriteLine("Hej du med!");
            }
            // Om variabeln text är lika med "katt" så skriver vi istället ut hund
            else if(text == "katt")
            {
                Console.WriteLine("Hund");
            }
            // Annars om variabeln text varken innehåller "hej" eller "katt"
            // så skriver vi ut "Blabla" till konsollen.
            else {
                Console.WriteLine("Blabla");    

            }            

            // Vänta på input för att undvika att
            // programmet stänger ner
            Console.ReadLine();

        } // Main-metoden slut
    } // Klass slut
}
