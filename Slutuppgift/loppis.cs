using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutuppgift
{
    internal class loppis
    {
        private static string[] fixa = new string[8];
        public static void loppisfynd()
        {
          //The users choice for time and mentor
            fixa[0] = "1.Måndag 9.00 - 11.00.";
            fixa[1] = "2.Tisdag 13.00 - 15.00.";
            fixa[2] = "3.Onsdag 9.00 - 11.00.";
            fixa[3] = "4.Torsdag 15.00 - 17.00";
            fixa[4] = "";
            fixa[5] = "6.Lotta Larsson";
            fixa[6] = "7.Oscar Pettersson";
            fixa[7] = "8.Hannah Håkansson";

            foreach (string i in fixa)
            {
                Console.WriteLine(i);
            }
        }

            public static string hämtaVal(int val)
            {
                return fixa[val];
            }
    }
}
