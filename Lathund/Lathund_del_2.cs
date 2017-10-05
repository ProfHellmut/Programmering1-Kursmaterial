using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Lathund_del_2
    {
        /*-----Lathund för C# - Grunder del 2-----*/

        /*-----Loopar-----*/

        // For-loopen är en loop som används när man
        // behöver iterera ett bestämt antal gånger.
        // "for" indikerar att det är en for-loop, därefter
        // följer en parentes där vi först deklarerar och
        // tilldelar vår räknare "i" med värdet 0. Sen
        // kommer ett argument för hur många iterationer
        // som ska ske (i < length) följt av "i++"
        // som adderar 1 till vår räknare.
        for (int i = 0; i < length; i++)
		{
            // Hur loopen fungerar:
            // 1. Räknaren deklareras och tilldelas(int i = 0)
            // 2. Argumentet kollas (i < length)
            // 3. Om i är lägre körs koden i "{ }"
            // 4. i inkrementeras med 1 (i++)
            // 2. Argumentet kollas
            // 3. Kod körs om i är mindre än längd
            // 4. i inkrementeras
            // Detta pågår tills argumentet är falskt
		}
        
        // Foreach-loopen används för att iterera igenom
        // samlingar(array, List, Dictionary osv).
        // För att lättare förstå denna loop så kan man
        // översätta koden direkt till svenska och säga
        // "För varje (datatyp) namn i samling".
        // Den fungerar genom att kolla den datatyp
        // man specificerar som finns i en samling.
        // Varje datatyp i en loop/iteration har ett namn
        // som nedan fått namnet "namn" som vi sedan kan
        // "peka" på och utföra kod på. Denna loop körs
        // tills samlingen är slut.
        foreach (datatyp namn in samling)
	    {
            Console.WriteLine(namn);
	    }

        // While-loopen är en simpel loop. Denna körs
        // så länge argumentet inom parenteserna är sant
        // och avbryts när argumentet blir falskt.
        while (argument)
	    {

	    }    

        // Do..while-loopen är precis som en while-loop
        // med ett undantag. Här körs koden inuti "do"
        // innan vi kollar argumentet. Denna loop är bra
        // att använda när vi har kod som vi vill köra
        // minst en gång och så länge som argumentet
        // är sant.
        do {

        }
        while (argument);
    }
}
