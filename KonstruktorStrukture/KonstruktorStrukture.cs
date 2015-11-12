using System;

namespace Vsite.CSharp
{
    class KonstruktorStrukture
    {
        struct MojaStruktura
        {
            //public MojaStruktura() 
            //{
            //    a=10;
            //    s="pero";  
            //}
            public MojaStruktura(int a, string s) 
            {
                this.a=a;
                this.s=s;
            }

            public int a;
            public string s;
        }

        static void Main(string[] args)
        {
            // Stvoriti objekt strukture MojaStruktura i ispisati vrijednosti članova
            MojaStruktura mk = new MojaStruktura();
            Console.WriteLine(mk.a);
            Console.WriteLine(mk.s);


            // U strukturi MojaStruktura promijeniti prazan konstruktor tako da prima dva argumenta kojima se inicijaliziraju članovi te ponoviti gornji postupak
            MojaStruktura mk1 = new MojaStruktura(3,"zagreb");
            Console.WriteLine(mk1.a);
            Console.WriteLine(mk1.s);

            Console.ReadKey();

        }
    }
}
