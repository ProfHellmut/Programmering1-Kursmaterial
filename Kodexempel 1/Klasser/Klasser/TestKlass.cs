using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class TestKlass
    {
        // Instansvariabler
        double dubbelTal;
        List<string> sifferLista;

        // Getter
        public double DubbelTal { get => dubbelTal;}

        // Konstruktor
        public TestKlass ()
        {
            sifferLista = new List<string>();
            GenereraSiffror();
        }

        // Lägger till värdet av i i vår sifferLista
        // med hjälp av metoden ReturneraString
        private void GenereraSiffror()
        {
            for (double i = 0; i < 1.0; i += 0.1)
            {
                sifferLista.Add(ReturneraString(i));
            }
        }

        // Metoden tar in ett tal av datatypen double
        // Returnerar det talet som en sträng
        public string ReturneraString(double dubbelTal)
        {
            // Nyckelordet "this" pekar mot instansvariabeln
            // (Klassens variabel med samma namn)
            this.dubbelTal = dubbelTal;

            return dubbelTal.ToString();
        }
    }
}
