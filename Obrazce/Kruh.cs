using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrazce
{
    sealed class Kruh : Obrazec,IKreslenie, IZmenRozmer
    {
        double polomer;
        public Kruh(double polomer)
        {
            this.polomer = polomer;
        }

        public override double VypocitajObsah()
        {
            return Math.PI * polomer * polomer;
        }
        public void Vytlac()
        {
            Console.WriteLine("Tlacim kruh");
        }
        public void Vykresli()
        {
            Console.WriteLine("Kreslim kruh");
        }
        public void ZmenRozmer(double rozdiel)
        {
            polomer = polomer - rozdiel;
        }
    }
}
