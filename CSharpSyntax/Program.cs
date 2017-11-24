using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntax
{
    class Program
    {
        public int globalniPremenna = 7;

        void TestGlobalniPremennej()
        {
            int lokalniPremenna = 9;
            globalniPremenna++;
        }
        void TestLokalniPremennej()
        {

        }

        // navrat MenoMetody(parametre 0... do nekonecna)
        void bezNavratu() //nemusi vratit nic
        {

        }
        int sNavratom()
        {
            return 8;  // musi nieco vratit
        }

        int scitaj(int a, int b)
        {
            int vysledok = a + b;
            return vysledok;
        }
        int scitajRychlejsie(int a,int b)
        {
            return a + b;
        }
        int scitajRychlejsie(int a, int b, int c)
        {
            return a + b + c;
        }
        void pouzivaj()
        {
            int vysledok = scitajRychlejsie(10, 6);
            vysledok = scitajRychlejsie(10, 6, 7);

        }
        static void Main(string[] args)
        {
            const int mojeKonstanta = 4; //nezmenitelna premenna, konstatna hodnota, musi byt priradena hodnota ktora sa nezmeni
            int polomer = 6;
            //polomer = polomer + 1;
            //polomer +=8;
            Console.WriteLine("Povodny polomer {0}", polomer);
            int novyPolomer = polomer++; //prefix
            Console.WriteLine("Novy polomer {0}", novyPolomer);
            int zaseNovyPolomer = ++polomer; //postfix
            Console.WriteLine("Zase novy polomer {0}", zaseNovyPolomer);

            //pouzi kalkulator
            Kalkulator.Scitaj("4", "5");



            // var vari = 6;  //variabilna premenna, musi byt priradena hodnota
            int vysledok = 5;
            switch (vysledok)
            {
                case 2:
                    Console.WriteLine("vysledok je 2");
                    break;
                case 3:
                    Console.WriteLine("vysledok je 3");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("vysledok je 4 alebo 5");
                    break;
                default:
                    Console.WriteLine("vysledok je nebol 2,3,4,5");
                    break;
            }
            // vysledok je 10-20 alebo 40-60, a zaroven nemoze byt 16
            if ((vysledok >= 10 && vysledok <= 20) || (vysledok >=40 && vysledok <=60) && (vysledok !=16))
            {

            }
            

            Console.ReadLine();
        }
    }
}
