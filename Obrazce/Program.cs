using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrazce
{
    class Program
    {
        static void Main(string[] args)
        {
            Obrazec kruh = new Kruh(10);
            Console.WriteLine("Obsah kruhu:{0}", kruh.VypocitajObsah());
            Stvorec stvorec1 = new Stvorec(5);
            Console.WriteLine("Obsah stvorca:{0}", stvorec1.VypocitajObsah());
            Stvorec stvorec2 = new Stvorec(10);
            Console.WriteLine("Porovnanie:{0}", Stvorec.Porovnaj(stvorec1, stvorec2));

            IKreslenie K = stvorec2;
            IKreslenie K1 = new Kruh(10);
            K.Vykresli();
            K1.Vykresli();

            Kruh Kruh1 = new Kruh(3);
            IZmenRozmer zmenaKruhu = Kruh1;
            zmenaKruhu.ZmenRozmer(2);
            Kruh1.VypocitajObsah();
            Console.WriteLine(Kruh1.VypocitajObsah());

            Stvorec Stvorec1 = new Stvorec(6);
            IZmenRozmer zmenaStvorca = stvorec1;
            zmenaStvorca.ZmenRozmer(3);
            Stvorec1.VypocitajObsah();
            Console.WriteLine(Stvorec1.VypocitajObsah());

            Console.ReadLine();
        }
    }
}
