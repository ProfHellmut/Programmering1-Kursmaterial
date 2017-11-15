using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    // Klassen vi ärver ifrån efter ":"
    class Cat : Animal
    {
        string says;

        // Ta in två strängar för namn och says
        // tilldela instansvariabeln says med värdet och
        // skicka name till basklassen Animal
        public Cat(string name, string says) : base(name)
        {
            this.says = says;
        }

        public void CatSays()
        {
            Console.WriteLine(says);
        }

        // Med nyckelordet "override" kan vi överskrida basklassens
        // metod och definiera vår egna text
        public override void MyName()
        {
            Console.WriteLine("This cats name is: " + namn);
        }
    }
}
