using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Slutuppgift
{
    internal class målning
    {
        private static string[] material = new string[6];
        public static void målningsmaterial()
        {
           //The users choice of paintingmaterial
            material[0] = "1.Penselset:      akvarell.";
            material[1] = "2.Penselset: olja el.akryl.";
            material[2] = "3.Målarduk:     50 x 50 cm.";
            material[3] = "4.Målarduk:   100 x 100 cm.";
            material[4] = "5.Färger:         akvarell.";
            material[5] = "6.Färger:    olja el. akryl";

            foreach (string i in material)
            {
                Console.WriteLine(i);
            }    
        }

        public static string hämtaVal(int val)
        {
            return material[val];
        }
    }
}
