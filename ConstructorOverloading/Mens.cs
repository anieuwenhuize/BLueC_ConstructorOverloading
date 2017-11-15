using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorOverloading
{
    class Mens: IKanLopen
    {
        // velden
        private string naam;
        private Mens heeftRelatieMet;
        private IEnumerable<Mens> kinderen;

        public Mens(string naam)
        {
            this.naam = naam;
            kinderen = new List<Mens>();
        }

        // signature
        public Mens(string naam, Mens relatieMet)
        {
            this.naam = naam;
            this.heeftRelatieMet = relatieMet;
            kinderen = new List<Mens>();
        }

        // signature
        public Mens(string naam, IEnumerable<Mens> kinderen)
        {
            this.naam = naam;
            this.kinderen = kinderen;
        }

        public void Loop()
        {
            // Doe iets met jouw twee voeten.
        }
    }
}
