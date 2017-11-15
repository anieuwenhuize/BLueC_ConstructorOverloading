using System;
using System.Collections.Generic;

namespace ConstructorOverloading
{
    class Program
    {

        private static void Loopband(IKanLopen ietsdatkanlopen)
        {
            ietsdatkanlopen.Loop();
        }
        static void Main(string[] args)
        {
            Mens jsaak = new Mens("Sjaak");
            Mens kees = new Mens("Kees");

            Mens jannie = new Mens("Jannie", jsaak);

            IEnumerable<Mens> kinderen = 
                new List<Mens>() { kees, jannie };

            Mens opa = new Mens("Ouwe Kees", kinderen);

            Dier hond = new Dier();

            Loopband(hond);
        }
    }
}
