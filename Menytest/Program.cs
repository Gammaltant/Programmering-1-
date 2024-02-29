using Menytest;
using System;
using System.Collections;





int x = 0;

while (true)
{

    Console.WriteLine("VARMT VÄLKOMMEN TILL HÅLARPSGÅRDEN!");
    Console.WriteLine("------------------------------------\n");
    Console.WriteLine("1.Målning.");
    Console.WriteLine("2.Fixa ditt eget loppisfynd.");
    Console.WriteLine("3.Skrivträffar.");
    Console.WriteLine("4.Meditation.");
    Console.WriteLine("5.Prislista.");
    Console.WriteLine("6.Avsluta.\n");



    Console.WriteLine("Gör ditt val i menyn och följ stegen för att boka din aktivitet.");
    x = Convert.ToInt32(Console.ReadLine());



    Console.Clear();

    if (x == 2)
    {
        Console.Clear();

        //Getting the users choice in the submenu
        Console.WriteLine("1.Boka tid för planering av ditt projekt\n");
        Console.WriteLine("2.Boka verkstadstid för egenarbete.\n");
        Console.WriteLine("Gör ditt val i menyn");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Clear();
        switch (x)
        {
            case 1:
                Console.WriteLine("1.Beräknad tid för planering är ca. 2 tim. \n");
                Console.WriteLine("2.Måndag 9.00 - 11.00.");
                Console.WriteLine("3.Tisdag 13.00 - 15.00.");
                Console.WriteLine("4.Onsdag 9.00 - 11.00.");
                Console.WriteLine("5.Torsdag 15.00 - 17.00");
                break;
            case 2:
                Console.WriteLine("Maxtid du kan boka för egenarbete är 3 tim/tillfälle.\n");
                Console.WriteLine("Mån - Fre, 9.00 - 12.00");
                Console.WriteLine("Mån - Fre, 13.00 - 18.00");
                break;

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




        Console.ReadLine();
        Console.WriteLine("Tryck ENTER för att komma tillbaka till menyn.");
        Console.ReadKey();

        Console.Clear();

    }




}

        
   


