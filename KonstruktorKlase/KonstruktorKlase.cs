using System;
using System;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
        public MojaKlasa(int a, string s)
        {
            this.a = a;
            this.s = s;
        }
        public MojaKlasa() 
        {
            a = 10;
            s = "pero";
        }
        public int a;
        public string s;
    }

    class KonstruktorKlase
    {
        static void Main(string[] args)
        {
            // Stvoriti objekt klase MojaKlasa i ispisati vrijednosti članova
            MojaKlasa X = new MojaKlasa();
            Console.WriteLine(X.a);
            Console.WriteLine(X.s);


            //  U klasu MojaKlasa dodati prazan konstruktor koji inicijalizira svoje članove na neku vrijednost te ponoviti gornji postupak
            MojaKlasa X2 = new MojaKlasa();
            Console.WriteLine(X2.a);
            Console.WriteLine(X2.s);


            // TODO: U klasi MojaKlasa promijeniti prazan konstruktor tako da prima dva argumenta kojima se inicijaliziraju članovi te ponoviti gornji postupak
            MojaKlasa X3 = new MojaKlasa(100, "stol");
            Console.WriteLine(X3.a);
            Console.WriteLine(X3.s);

            Console.ReadKey();
        }
    }
}
