using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menytest
{
    internal class Beställa
    {
        public static void Projekt()
        {
            Console.WriteLine("Skriv in dina val");
            Console.WriteLine("Skriv s för att summera din beställning");
        }
        public static string läsSumma()
        {
            string x;
            x =  Console.ReadLine();
            return x;

        }
        public static char läsAlternativ()
        {
            return Convert.ToChar(Console.ReadLine());
        }
         public static string summera(string v, string y, string z)
        {
            return ( v + y + z);
        }
        string v, y, z;
        char svar;

        Beställa.Projekt();
        v = läsSumma();
        y = läsSumma();
        z = läsSumma();
        svar = Beställa.läsAlternativ();
        if (svar == 'S')
        {
            Console.WriteLine("Summan blir" + summera(v, y, z));
        }


}

