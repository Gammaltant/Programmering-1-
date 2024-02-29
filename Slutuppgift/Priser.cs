using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Slutuppgift
{
    internal class Priser
    {
        public static void Prislista()
        {
          //A list to show the price of the products and service
            List<string> pris = new List<string>();

            Console.WriteLine("PRIS PÅ MATERIAL OCH TIDER.");
            Console.WriteLine("---------------------------\n");

            pris.Add("1.Målarduk 50 x 50 cm:                            80 kr.");
            pris.Add("2.Målarduk 100 x 100 cm:                         120 kr.");
            pris.Add("3.Akvarellpapper 300g                            105 kr");
            pris.Add("4.Akvarellpenslar 5 st:                          120 kr.");
            pris.Add("5.Penselset för olja och akrylfärg 10 st:        120 kr.");
            pris.Add("6.Akvarellfärg, rött,blått,gult,svart och vitt:   50 kr.");
            pris.Add("7.Akrylfärg, rött,blått,gult,vitt och svart:      50 kr");
            pris.Add("8.Oljefärg, rött,blått,gult,vitt och svart:       50 kr");
            pris.Add("9.Projektplanering, ca 2 tim:                  * 400 kr.");
            pris.Add("10.Verkstadstid:                                 150 kr/tim.");
            pris.Add("11.Meditation för nybörjare, ca 1,5 tim:         200 kr.");
            pris.Add("12.Meditation för icke nybörjare, ca 1 tim:      100 kr.\n");


            foreach (string i in pris)
            {
                Console.WriteLine(i);
            }

           Console.WriteLine("*Projektplanering är att man tillsammans med handledare planerar tid och kostnad för hela projektet.");
           Console.WriteLine();
           Console.WriteLine("**Kaffe, te el.vatten och en fralla ingår i alla bokningar. Vill man ta med egen mat och värma, så finns det micro.");

           Console.ReadLine();
           Console.WriteLine("Tryck ENTER för att komma tillbaka till menyn");
           Console.ReadKey();

            Console.Clear();
        }
    }
}

