using System;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
        // Dodati jedna privatno polje (podatkovni član)
        private int x = 1;

        // Dodati javnu metodu koja će ispisati podatkovni član
        public int IspisiX()
        {
            return this.x;
        }
    }


    struct MojaStruktura
    {
        // Dodati jedna privatno polje (podatkovni član)
        string s = "tekst";

        // Dodati javnu metodu koja će ispisati podatkovni član
        public string DajTekst() 
        {
            return s;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Inicijalizirati objekt tipa MojaKlasa i pozvati njegovu metodu
            MojaKlasa a = new MojaKlasa();
            a.IspisiX();
            // Inicijalizirati objekt tipa MojaStruktura i pozvati njegovu metodu
            MojaStruktura b = new MojaStruktura();
            b.DajTekst();

            Console.ReadKey();
        }
    }
}
