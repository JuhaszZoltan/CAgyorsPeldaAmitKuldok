using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAgyorsPeldaAmitKuldok
{
    struct Struktura
    {
        public string SzovegesAdattag;
        public int[] VektorAdattag;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //elemi értékadás sok sorban:

            Struktura s1 = new Struktura();
            s1.SzovegesAdattag = "valami";
            s1.VektorAdattag = new int[2];
            s1.VektorAdattag[0] = 10;
            s1.VektorAdattag[1] = 20;

            //kicsit kevesebbben:

            Struktura s2 = new Struktura();
            s2.SzovegesAdattag = "valami más";
            s2.VektorAdattag = new int[] { 30, 40 };

            //ahogy én szoktam:
            var s3 = new Struktura()
            {
                SzovegesAdattag = "nem jut eszembe más",
                VektorAdattag = new int[] { 50, 60 },
            };

            //struktúra vektorban:
            var st = new Struktura[]
            {
                new Struktura()
                {
                    SzovegesAdattag = "asdf",
                    VektorAdattag=  new int[] { 1, 2 },
                },
                new Struktura()
                {
                    SzovegesAdattag = "jklé",
                    VektorAdattag=  new int[] { 3, 4 },
                },
            };
        }
    }
}
