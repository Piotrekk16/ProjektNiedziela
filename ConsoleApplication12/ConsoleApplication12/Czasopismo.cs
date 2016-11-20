using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Czasopismo :Publikacja
    {
        private int nr;

        public void WypiszInfo()
        {
            Console.WriteLine("Tytuł {0}",tytul);
            Console.WriteLine("Numer {0}", nr);
        }

        public Czasopismo() { nr = 1; }

        public Czasopismo(string tytul,int nr)
        {
            this.tytul = tytul;
            this.nr = nr;
        }
    }
}
