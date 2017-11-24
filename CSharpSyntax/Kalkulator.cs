using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntax
{
    class Kalkulator
    {
       public static int Scitaj(int a, int b)
        {
           int vysledok = a + b;
            return vysledok;
        }
       public static int Scitaj(int a, int b, int c)
        {
           int vysledok = a + b + c;
            return vysledok;
        }
      public static int Scitaj(string a, string b)
        {
          return int.Parse(a) + int.Parse(b); //Parse prerobi strig na int

            
        }

    }
}
