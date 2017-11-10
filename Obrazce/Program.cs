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
            Stvorec stvorec = new Stvorec(5);
            Console.WriteLine("Obsah stvorca:{0}", stvorec.VypocitajObsah());
            Stvorec stvorec2 = new Stvorec(10);
            Console.WriteLine("Porovnanie:{0}", Stvorec.Porovnaj(stvorec, stvorec2));
            Console.ReadLine();
        }
    }
}
