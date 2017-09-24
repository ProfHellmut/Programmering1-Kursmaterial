using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utmaningar
{
    class Lathund
    {
        /*-----Lathund för C# - Grunder-----*/

        /*-----Vanliga Datatyper-----*/
        // Vissa datatyper behöver inte bokstav efter värdet.

        int myInteger = 40;         // En integer. Dessa lagrar heltal.
        long myLong = 1234567890L;  // En long. Lagrar större heltal än int. ("L" på slutet efter talen)

        float myFloat = 12.34F;     // En float. Lagrar flyttal upp till 7 decimaler med precision. ("F" på slutet efter talen)
        double myDouble = 12.21D;   // En double. Lagrar flyttal upp till 15 decimaler med precision. ("D" på slutet efter talen)
        decimal myDec = 12.65M;     // En decimal. Lagrar flyttal upp till 27 decimaler med precision. ("M" på slutet efter talen, använd decimal för pengahantering)

        char myChar = 'a';          // En char. Lagrar en karaktär. Värdet måste omges av två ' (fnuttar?).
        string myStr = "Hej!";      // En string. Lagrar en sträng av karaktärer. Måste omges av " (citationstecken).

        bool myBool = true;         // En bool. Lagrar sant/falskt värden (true/false).
        
        /*-----Kontroll-satser-----*/

        // If-satser används för att kolla ett argument och
        // gör beslut beroende på om argumentet är sant eller
        // falskt. Om det är sant körs koden innanför "{ }".
        if (true) 
        {
            // Kör koden här inne    
        }

        // Man kan även lägga till else if()-block för att lägga
        // lägga till fler argument som ska kollas.
        if (1 == myInteger)
        {
            // Do this
        }
        else if (1 == myFloat)
        {
            // Do this
        }

        // Och till sist kan man använda else-block för kod man
        // vill ska köras om ett argument inte stämmer alls.
        if (1 == myInteger)
        {
            // Do this
        }
        else
        {
            // Do this if argument is false
        }

        
        // Switch-satser används för att jämföra ett värde med
        // en massa "cases" och se om värdet är lika.

        switch(userInput)       // Här tar vi in userInput och vi låtsas som att det är en integer
        {
            case 1:             // Först kollar vi om userInput är lika med värdet 1
                // Do this      // Om korrekt, kör koden
            break;              // Säg till att vi har jämfört klart och hoppa ur switch-satsen om 1 var rätt

            case 2:             // Är 1 inte korrekt så hoppar vi hit och jämför med värdet 2
                // Do this      // Gör detta om 2 är rätt
            break;              // Hoppa ur switchen om 2 var rätt

            case 3:             // Är 2 inte heller korrekt så jämför vi med detta case
                // Do this      // Kör koden om 3 är korrekt
            break;              // Hoppa ur switchen om case 3 var korrekt

            default:            // Om inget är korrekt kommer vi till default, default är som ett else-block i tidigare exempel
                // Do this      // Kör kod!
            break;              // Hoppa ur! Default behöver man inte använda i en switch, men kan vara bra att använda i vissa fall
        }

        
    }
}
