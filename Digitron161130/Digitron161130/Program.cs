using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Digitron161130
{
    class Program
    {


        // private static double prvaD;
        //  private static int prvaI;

        public static int operacija { get; private set; }
        public static string x { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("APLIKACIJA DIGITRON");
            {
                int a; int b; double aa;
                string i; string d; string I; double cc; int ccc;/* int sabInt = 0; int odInt = 0; int mnInt = 0; int dljInt = 0;*/ int ostInt = 0;
                /*double sabDab = 0; double odDab = 0; double mnDab = 0; double dljDab = 0;*/
                int rezInt = 0; double rezDab = 0;
                while (true)
                {
                    Console.Write("Uneti tip digitrona\n\nInteger(i)\tDouble(d)\n");

                    // args = new string[] { Console.ReadLine() };

                    I = Console.ReadLine();
                    //  Console.WriteLine("Unešeno je" + I);


                    if (I != "i" && I != "d")
                    {
                        Console.WriteLine("Nije  unešeno ni slovo \"i\" ni slovo \"d\"" + "\tUnešeno je:\t" + I);

                    }
                    else



                        while (true)
                        {
                            Console.Write("\nUnesi prvu vrednost:");
                            string x = Console.ReadLine();

                            if (!double.TryParse(x, out aa) && I == "d")
                            {

                                {

                                    Console.WriteLine("\nNije izvršen unos u vidu vlada cifara; ponovite unos");
                                    continue;
                                }

                            }
                            else if (!int.TryParse(x, out a) && I == "i")
                            {






                                Console.WriteLine("\nNije izvršen unos u vidu vlada cifara; ponovite unos");
                                continue;
                            }





                            double prvaD = aa;
                            int prvaI = a;


                            // Console.WriteLine("\n Prva uneta  vrednost je double" + "    " + prvaD);
                            //  Console.WriteLine("\n Prva uneta  vrednost je int" + "    " + prvaI);
                            while (true)
                            {


                                Console.WriteLine("\nUnesi broj Željene operacije:\t");
                                Console.WriteLine("\n1 Sabiranje\n2 Oduzimanje\n3 Množenje\n4 Deljenje\n5 Brisanje\n6 izlaz iz programa\n");

                                Console.Write("\nUnesi broj Željene operacije:\t");
                                string y = Console.ReadLine();
                                if (!int.TryParse(y, out b))
                                {
                                    Console.WriteLine("\nNije izvršen unos u vidu cifara; ponovite unos");
                                    continue;
                                }


                                // int operacija = b;
                                //  Console.WriteLine("\n Uneta  vrednost je operacije je" + "    " + operacija);

                                if (b == 6)
                                {
                                    Thread.Sleep(1000);
                                    System.Environment.Exit(1);
                                    break;
                                }


                                if (b == 5)
                                {
                                    rezDab = 0; rezInt = 0;
                                    Console.WriteLine("\nBrisanje");
                                    break;
                                }

                                else
                                {

                                    if (b < 1 || b > 6)

                                    {
                                        Console.Write("\nPogrešan unos ");
                                        Console.WriteLine(b);
                                        return;
                                    }

                                    if (b == 1)
                                    {
                                        string sb = "sabiranje";
                                        Console.Write("\nUnesi vrednost za operaciju {0}:\t", sb);
                                    }
                                    else if (b == 2)
                                    {
                                        string od = "oduzimanje";
                                        Console.Write("\nUnesi vrednost za operaciju {0}:\t", od);
                                    }
                                    else if (b == 3)
                                    {
                                        string mn = "množenje";
                                        Console.Write("\nUnesi vrednost za operaciju {0}:\t", mn);
                                    }
                                    else if (b == 4)
                                    {
                                        string dl = "deljenje";
                                        Console.Write("\nUnesi vrednost za operaciju {0}:\t", dl);
                                    }
                                    while (true)
                                    {

                                        string yy = Console.ReadLine();

                                        if (!double.TryParse(yy, out cc))
                                        {

                                            Console.WriteLine("\nNijeee izvršen unos u vidu cifara; ponovite unos");
                                            continue;


                                        }
                                        else if (!int.TryParse(yy, out ccc) && I == "i")
                                        {

                                            Console.WriteLine("\nNijeee izvršen unos u vidu cifara; ponovite unos");
                                            continue;


                                        }

                                        double drugaD = cc;
                                            int drugaI = ccc;

                                            // Console.WriteLine("\n Druga uneta  vrednost je double" + "    " + drugaD);
                                            //  Console.WriteLine("\n Druga uneta  vrednost je int" + "    " + drugaI);


                                            if (I == "i" && b == 1)
                                            {
                                                rezInt = rezInt + prvaI + drugaI; prvaI = 0;
                                                Console.WriteLine("sabiranje\tint:\t" + rezInt);
                                                break;
                                            }

                                            if (I == "i" && b == 2)
                                            {

                                                rezInt = rezInt + prvaI - drugaI; prvaI = 0;
                                                Console.WriteLine("oduzimanje\tint:\t" + rezInt);
                                                break;
                                            }
                                            if (I == "i" && b == 3)
                                            {

                                                rezInt = (rezInt + prvaI) * drugaI; prvaI = 0;
                                                Console.WriteLine("množenje\tint:\t" + rezInt);
                                                break;
                                            }
                                            if (I == "i" && b == 4)
                                            {
                                                ostInt = (rezInt + prvaI) % drugaI;
                                                rezInt = (rezInt + prvaI) / drugaI; prvaI = 0;

                                                Console.WriteLine("deljenje\tint:\t" + rezInt);
                                                Console.WriteLine("ostatak\tint:\t\t" + ostInt);
                                                break;
                                            }

                                            if (I == "d" && b == 1)
                                            {

                                                rezDab = rezDab + prvaD + drugaD; prvaD = 0;
                                                Console.WriteLine("sabiranje\tDab:\t" + rezDab);
                                                break;

                                            }
                                            if (I == "d" && b == 2)
                                            {

                                                rezDab = rezDab + prvaD - drugaD; prvaD = 0;
                                                Console.WriteLine("oduzimanje\tDab:\t" + rezDab);
                                                break;

                                            }
                                            if (I == "d" && b == 3)
                                            {

                                                rezDab = (rezDab + prvaD) * drugaD; prvaD = 0;
                                                Console.WriteLine("množenje\tDab:\t" + rezDab);
                                                break;

                                            }
                                            if (I == "d" && b == 4)
                                            {

                                                rezDab = (rezDab + prvaD) / drugaD; prvaD = 0;
                                                Console.WriteLine("deljenje\tDab:\t" + rezDab);
                                                break;
                                            }

                                        }

                                    }
                                }
                            }
                        }
                }
            }
        }
    }





                                 




                                  







    

                           