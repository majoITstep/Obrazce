using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrazce
{
    class Kruh : Obrazec
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
    }
}
