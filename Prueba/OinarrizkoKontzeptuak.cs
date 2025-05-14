using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class OinarrizkoKontzeptuak
    {
        public static void Exekutatu()
        {
            //hau switchetan sartu
            Console.WriteLine("***** OINARRIZKO ERAGIKETAK LANTZEN ***********");
            Console.WriteLine("1.- Adina eskatu eta hurrengo urteko adina erakutsi");
            Console.WriteLine("2.- Bi zenbaki osoren batazbestekoa kalkulatu");
            Console.WriteLine("3.- Bikoitia den edo ez adierazi");
            Console.WriteLine("4.- BEZaren kalkulua");
            Console.WriteLine("5.- 7ren multiploa");
            Console.WriteLine("6.- Triangeluaren azalera kalkulatu");
            Console.WriteLine("7.- Bigarren mailako ekuazioa askatu");
            Console.WriteLine("8.- Jolas parkea kudeatzen");
            Console.WriteLine("9.- Zenbaki handiena");
            Console.WriteLine("10.- BUELTATU");
            Console.Write("Ze ariketa nahi duzun egin? Sartu bere zenbakia:");
            
            int eragiketa = int.Parse(Console.ReadLine());
            switch (eragiketa)
            {
                case 1:
                    Console.WriteLine("***** ADINAREN KALKULUA *****");
                    Ariketa1();
                    break;
                case 2:
                    Console.WriteLine("***** BI ZENBAKI OSOREN BATAZBESTEKOA *****");
                    Ariketa2();
                    break;
                case 3:
                    Console.WriteLine("***** BIKOITIA OTE DEN JAKITEA *****");
                    Ariketa3();
                    break;
                case 4:
                    Console.WriteLine("***** BEZaren KALKULUA *****");
                    Ariketa4();
                    break;
                case 5:
                    Console.WriteLine(" *****7-ren MULTIPLOA *****");
                    Ariketa5();
                    break;
                case 6:
                    Console.WriteLine(" *****TRAINGELUAREN AZALERA *****");
                    Ariketa6();
                    break;
                case 7:
                    Console.WriteLine(" *****BIGARREN MAILAKO EKUAZIOA *****");
                    Ariketa7();
                    break;
                case 8:
                    Console.WriteLine(" *****JOLAS PARKEA KUDEATZEN *****");
                    Ariketa8();
                    break;
                case 9:
                    Console.WriteLine(" *****ZENBAKI HANDIENA *****");
                    Ariketa9();
                    break;
                case 10:
                    return;
                default:
                    Console.WriteLine(" *****ERAGIKETA EZ ONARTUA *****");
                    break;
            }
        }
        static void Ariketa1()
        {
            Console.WriteLine("Sartu adina: ");
            int adina = int.Parse(Console.ReadLine());
            Console.WriteLine("Hurrengo urtean {0} urte izango dituzu.", adina + 1);
        }
        static void Ariketa2()
        {
            Console.WriteLine("Sartu lehen nota: ");
            int bat = int.Parse(Console.ReadLine());
            Console.WriteLine("Sartu bigarren nota: ");
            int bi = int.Parse(Console.ReadLine());

            double bataz_bestekoa = (bat + bi) / 2.0;

            Console.WriteLine("Bataz bestekoa {0}" , bataz_bestekoa);
            Console.WriteLine("Boletinean agertuko litzateke: {0}", (int)bataz_bestekoa);
        }
        static void Ariketa3()
        {
            Console.WriteLine("Sartu zenbaki: ");
            int zenbakia = int.Parse(Console.ReadLine());

            if (zenbakia % 2 == 0) {
                Console.WriteLine("Bikoitia da");
            } else { Console.WriteLine("Bakoitia da"); }
        }
        static void Ariketa4()
        {
            Console.WriteLine("Oinarria: ");
            double oinarria = double.Parse(Console.ReadLine());
            Console.WriteLine("BEZ-a: ");
            double bez_ehunekoa = double.Parse(Console.ReadLine());

            double bez_zatia = (oinarria * bez_ehunekoa) / 100;
            double kopuru_osoa = oinarria + bez_zatia;

            Console.WriteLine("Bez-a: {0}", bez_zatia);
            Console.WriteLine("Guztira: {0}",kopuru_osoa);
        }
        static void Ariketa5()
        {
            Console.WriteLine("Sartu zenbaki: ");
            int zenbakia = int.Parse(Console.ReadLine());

            int gehitu = (7 - (zenbakia % 7)) % 7;

            Console.WriteLine("{0} gehitu behar zaio 7ren multiploa izateko.", gehitu);
        }
        static void Ariketa6()
        {
            Console.WriteLine("Oinarria: ");
            int oinarria = int.Parse(Console.ReadLine());

            Console.WriteLine("Altuera: ");
            int altuera = int.Parse(Console.ReadLine());

            double azalera = oinarria * altuera / 2;

            Console.WriteLine("Triangeluaren azalera: {0}", azalera);
        }
        static void Ariketa7()
        {
            Console.WriteLine("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("x: ");
            double x   = double.Parse(Console.ReadLine());

            double y = a * x * x + b * x + c;

            Console.WriteLine("Emaitza: Y={0}",y);
        }
        static void Ariketa8()
        {
            Console.WriteLine("Haurrentzako sarrerak: ");
            int haur_kopurua = int.Parse(Console.ReadLine());
            Console.WriteLine("Helduentzako sarrerak: ");
            int heldu_kopurua = int.Parse(Console.ReadLine());

            double sarrerak = (haur_kopurua * 15.5) + (heldu_kopurua * 20);

            if (sarrerak > 100.0)
            {
                sarrerak = (sarrerak * 5) / 100;
                Console.WriteLine("Guztira: {0}", sarrerak);
            }
            else { 
                Console.WriteLine("Guztira: {0}", sarrerak);
            }
            
        }
        static void Ariketa9()
        {
            Console.WriteLine("a zenbakia: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("b zenbakia: ");
            int b = int.Parse(Console.ReadLine());

            if (a > b) 
            {
                Console.WriteLine("True");
            } else 
            { 
                Console.WriteLine("False");
                Console.WriteLine("Handiena: {0}", a>b ? a:b);
            }


        }
    }
}
