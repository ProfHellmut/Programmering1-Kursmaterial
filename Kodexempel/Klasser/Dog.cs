using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Dog : Animal
    {
        string says;

        public Dog (string name, string says) : base (name)
        {
            this.says = says;
        }

        public void DogSays()
        {
            Console.WriteLine(says);
        }
    }
}
