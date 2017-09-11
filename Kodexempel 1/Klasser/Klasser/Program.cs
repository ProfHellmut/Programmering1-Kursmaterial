using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            // Skapa objekt av klassen TestKlass
            TestKlass test = new TestKlass();

            Console.WriteLine(test.DubbelTal);

            string text = test.ReturneraString(10.0);
            Console.WriteLine(text);
            #endregion

            Console.WriteLine();

            Dog fido = new Dog("Hund", "Woof");

            fido.MyName();
            fido.DogSays();

            // Skapa objekt av klassen Cat och skicka med två strängar
            Cat snowball = new Cat("Snowball", "Meow");

            // Anropa metoderna
            snowball.MyName();      // Finns i klassen Animal
            snowball.CatSays();     // Finns i klassen Cat

            Console.ReadLine();
        }
    }
}
