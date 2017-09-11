using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Animal
    {
        // Protected betyder att alla klasser som ärver
        // från denna har tillgång till variabeln
        protected string namn;

        public Animal (string namn)
        {
            this.namn = namn;
        }

        // Nyckelordet virtual tillåter oss att överskrida
        // metoden i subklasser
        public virtual void MyName()
        {
            Console.WriteLine("This animals name is: " + namn);
        }
    }
}
