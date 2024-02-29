using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Slutuppgift
    
{

    internal class Program
    {
        public static void meny()
        {
            Console.WriteLine("\nGör din beställning i menyn.");
            Console.WriteLine("Sammanställ din beställning med bokstaven s.");
        }
        public static string läsText()
        {
            string x;
            x = Console.ReadLine();
            return x;
        }
        public static char läsSumman()
        {
            return Convert.ToChar(Console.ReadLine());
        }
       
        static void Main(string[] args)



        {  // Variable to show the users choice
            int x = 0;

            while (true)
            {
                try { 

                  //The users choice in the menu
                    Console.WriteLine("VARMT VÄLKOMMEN TILL HÅLARPSGÅRDEN!");
                    Console.WriteLine("------------------------------------\n");
                    Console.WriteLine("1.Målning.");
                    Console.WriteLine("2.Fixa ditt eget loppisfynd.");
                    Console.WriteLine("3.Meditation.");
                    Console.WriteLine("4.Prislista.");
                    Console.WriteLine("5.Avsluta.\n");


                  // Getting the users choice
                    Console.WriteLine("Gör ditt val i menyn och följ stegen för att boka din aktivitet.");
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                

                    //Function of choice in the mainmenu
                    if (x == 1)
                    {
                    try { 
                        Console.Clear();



                            while (x <= 2)
                            {

                                //Choice in submenu
                                Console.WriteLine("\n1.Beställa material.");
                                Console.WriteLine("\n2.Boka ateljetid för självstudier.");
                                Console.WriteLine("\nGör ditt val i menyn.");
                                x = Convert.ToInt32(Console.ReadLine());

                                Console.Clear();

                                //Getting the users choice in the submenu
                                if (x == 1)
                                {

                                    // This runs from an external class
                                    målning.målningsmaterial();

                                    //Return the users choice
                                    meny();

                                    string val = "";
                                    List<string> allaVal = new List<string>();
                                    while (val != "s")
                                    {
                                        val = läsText();
                                        if (val != "s")
                                        {
                                            allaVal.Add(val);
                                        }
                                    }

                                    foreach (string gjordaVal in allaVal)
                                    {
                                        Console.WriteLine(målning.hämtaVal(Convert.ToInt32(gjordaVal) - 1));
                                    }
                                    Console.WriteLine("\nTryck ENTER för att komma tillbaka till menyn.");
                                    Console.ReadLine();
                                    Console.Clear();
                                    x = x + 1;

                                }


                                //Choice of day and time in the submenu 
                                else if (x == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Du får boka max 3 tim/tillfälle!\n");
                                    string[] tid = new string[] { "1.Måndag 9.00 - 12.00", "2.Tisdag 13.00 - 18.00", "3.Onsdag 9.00 - 12.00", "4.Torsdag 13.00 - 18.00" };

                                    foreach (string i in tid)
                                    {
                                        Console.WriteLine(i);
                                    }

                                    string tider = Console.ReadLine();
                                    Console.WriteLine(tid[Convert.ToInt32(tider) - 1]);

                                }
                                // To get back to the menu
                                Console.WriteLine("\nTryck ENTER för att komma tillbaka till menyn.");
                                Console.ReadLine();
                                Console.Clear();
                                x = x + 1;
                               

                        }
                            
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Fel val i menyn!");

                    }
                }


                    //Function of choice in the mainmenu
                    else if (x == 2)
                    {
                    try 
                    { 
                        Console.Clear();

                          //Choices in submenu
                            Console.WriteLine("\n1.Boka tid och handledare för planering av ditt projekt");
                            Console.WriteLine("\n2.Boka verkstadstid för egenarbete.");
                            Console.WriteLine("\nGör ditt val i menyn");
                            x = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();
                        
                     //Getting the users choice in the submenu
                        switch (x)
                        {
                        
                            case 1:
                          //This runs from an external class
                            loppis.loppisfynd();
                              

                            meny();

                            string val = "";
                            List<string> allaVal = new List<string>();
                            while (val != "s")
                            {
                                val = läsText();
                                if (val != "s")
                                {
                                    allaVal.Add(val);
                                }
                            }

                             foreach (string gjordaVal in allaVal)
                             {
                                 Console.WriteLine(loppis.hämtaVal(Convert.ToInt32(gjordaVal) - 1));
                             }

                             Console.ReadLine();
                             Console.Clear();
                             break;

    
                          case 2:
                              Console.WriteLine("Maxtid du kan boka för egenarbete är 3 tim/tillfälle.\n");
                              Console.WriteLine("Välj tid i menyn.");
                              string[] tid = new string[] { "1.Mån 9.00 - 12.00", "2.Mån 13.00 - 16.00", "3.Ons 9.00 - 12.00", "4.Ons 15.00 - 18.00",
                                                                 "5.Fre 9.00 - 12.00"};
                                foreach (string i in tid)
                                {
                                    Console.WriteLine(i);
                                }
                                string tider = Console.ReadLine();
                                Console.WriteLine(tid[Convert.ToInt32(tider) - 1]);

                            //To get back to the menu
                              Console.WriteLine("\nTryck ENTER för att komma tillbaka till menyn.");
                              Console.ReadLine();
                              Console.Clear();

                              break;

                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Fel val i menyn!");

                    }

                }

                    //function of choise in main menu
                    else if (x == 3)
                    {
                    try { 
                        Console.Clear();

                        x = 1;
                        while (x <= 2)
                        {

                          //Choices in submenu
                            Console.WriteLine("\n1.Boka tid, nybörjare");
                            Console.WriteLine("\n2.Boka gruppmeditation som van utövare.");
                            Console.WriteLine("\nGör ditt val i menyn");
                            x = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();

                           //Getting the users choice in the submenu
                            if (x == 1)
                            {
                                Console.WriteLine("Välj den tid du vill ha.");
                                string[] välj = new string[] { "1.Måndag    18.00 - 19.30", "2.Onsdag    18.00 - 19.30"};

                                foreach (string i in välj)
                                {
                                    Console.WriteLine(i);
                                }
                                string tider = Console.ReadLine();
                                Console.WriteLine(välj[Convert.ToInt32(tider) - 1]);

                            }

                            else if (x == 2)
                            {

                                Console.WriteLine("Välj den tid du vill ha.");
                                string[] välj = new string[] { "1.Tisdag    18.00 - 19.00", "2.Torsdag   18.00 - 19.00" };

                                foreach (string i in välj)
                                {
                                    Console.WriteLine(i);
                                }
                                string tider = Console.ReadLine();
                                Console.WriteLine(välj[Convert.ToInt32(tider) - 1]);

                            }
                            Console.ReadLine();
                            Console.WriteLine("Tryck ENTER för att gå tillbaka till menyn");
                            Console.Clear();
                            x = x + 1;
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Fel val i menyn!");
                    }

                }

                  //Function of choice in the main menu
                    else if (x == 4)
                    {
                        try { 
                            Console.Clear();

                      
                            Console.WriteLine("\nPRISLISTA.");
                            Console.WriteLine("----------");

                          //This runs from an external class
                            Console.Clear();
                            Priser.Prislista();
                        }
                        catch
                        {
                            Console.Clear();
                            Console.WriteLine("Fel val i menyn!");

                        }
                    }

                  //Funtion of choice to stop the program
                    else if (x == 5)
                    {
                    try { 
                            Console.Clear();

                            Console.WriteLine("\nDu har valt att avsluta menyn.");
                            Console.WriteLine("\nTryck ENTER för att avsluta");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("VÄLKOMMEN ÅTER!");
                            break;
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Fel val i menyn!");

                    }
                }

                  // If the user makes a choice outside the menu
                    else
                    {

                        Console.Clear();

                        Console.WriteLine("Ditt val finns inte i menyn.\nGå tillbaka till menyn och gör ett nytt val\n");
                        Console.WriteLine("Tryck ENTER för att gå tillbaka till menyn.\n");
                        
                    }
                }         
                catch
                {
                 Console.Clear();
                 Console.WriteLine("Fel val i menyn!");

                }

             }

           }

        }

    }


