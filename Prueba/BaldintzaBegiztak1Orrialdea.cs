using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class BaldintzaBegiztak1Orrialdea
    {
        public static void Exekutatu()
        {
            //hau switchetan sartu
            Console.WriteLine("***** BALDINTZA-BEGIZTAK ***********");
            Console.WriteLine("1.- Bi zenbaki eskatu eta handienetik txikienera zenbaki denak erakutsi");
            Console.WriteLine("2.- Ezkutuko zenbakia asmatu");
            Console.WriteLine("3.- Aurreko programa beste begizta batekin");
            Console.WriteLine("4.- Aurreko programan saiakerak kontatu");
            Console.WriteLine("5.- Aurreko programan sartutako zenbaki guztien batura");
            Console.WriteLine("6.- 0-tik erabiltzailearen input-era bat gehitu");
            Console.WriteLine("7.- Nota kalkulatu");
            Console.WriteLine("8.- Hurrengo eguna zen izango den kalkulatu");
            Console.WriteLine("9.- Nortasun agiriko letra kalkulatu");
            Console.WriteLine("10.- Ikasle taldeko adinaren estatistikak");
            Console.WriteLine("11.- Zenbaki baten biderkadura taula erakutsi");
            Console.WriteLine("12.- Zenbaki baten faktoriala kalkulatu");
            Console.WriteLine("13.- 0-tik 10-erako zenbaki guztien biderkadura taula");
            Console.WriteLine("14.- Zenbaki oso baten erro karratua gertutasun bidez");
            Console.WriteLine("15.- Programatu kalkulagailu mota bat");
            Console.WriteLine("16.- Zenbaki baten zatitzaile guztiak atera");
            Console.Write("Ze ariketa nahi duzun egin? Sartu bere zenbakia:");

            int eragiketa = int.Parse(Console.ReadLine());
            switch (eragiketa)
            {
                case 1:
                    Console.WriteLine("***** HANDIENETIK TXIKIENERA *****");
                    Ariketa1();
                    break;
                case 2:
                    Console.WriteLine("***** ASMATU ZENBAKIA *****");
                    Ariketa2();
                    break;
                case 3:
                    Console.WriteLine("***** AURREKO PROGRAMA BESTE BEGIZTA BATEKIN *****");
                    Ariketa3();
                    break;
                case 4:
                    Console.WriteLine("***** SAIAKERAK KONTATU *****");
                    Ariketa4();
                    break;
                case 5:
                    Console.WriteLine(" ***** SARTUTAKO ZENBAKI GUZTIEN BATUTA *****");
                    Ariketa5();
                    break;
                case 6:
                    Console.WriteLine(" ***** 0-TIK ERABILTZAILEAREN INPUT-ERAINO *****");
                    Ariketa6();
                    break;
                case 7:
                    Console.WriteLine(" ***** NOTA KALKULATU *****");
                    Ariketa7();
                    break;
                case 8:
                    Console.WriteLine(" ***** HURRENGO EGUNA KALKULATU *****");
                    Ariketa8();
                    break;
                case 9:
                    Console.WriteLine(" ***** NORTASUN AGIRIKO LETRA KALKULATU *****");
                    Ariketa9();
                    break;
                case 10:
                    Console.WriteLine(" ***** IKASLE TALDEKO ADINAREN ESTATISTIKAK *****");
                    Ariketa10();
                    break;
                case 11:
                    Console.WriteLine(" ***** BIDERKADURA TAULA ERAKUTSI *****");
                    Ariketa11();
                    break;
                case 12:
                    Console.WriteLine(" ***** FAKTORIALA KALKULATU *****");
                    Ariketa12();
                    break;
                case 13:
                    Console.WriteLine(" ***** 0TIK 10ERA ZENBAKI GUZTIEN BIDERKADURA TAULA *****");
                    Ariketa13();
                    break;
                case 14:
                    Console.WriteLine(" ***** ZENBAKI OSO BATEN ERRO KARRATUA *****");
                    Ariketa14();
                    break;
                case 15:
                    Console.WriteLine(" ***** KALKULAGAILUA *****");
                    Ariketa15();
                    break;
                case 16:
                    Console.WriteLine(" ***** ZENBAKI BATEN ZATITZAILE GUZTIAK ATERA *****");
                    Ariketa16();
                    break;
                case 17:
                    return;
                default:
                    Console.WriteLine(" *****ERAGIKETA EZ ONARTUA *****");
                    break;
            }
        }

        static void Ariketa1()
        {
            Console.WriteLine("Zenbaki 1: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Zenbaki 2: ");
            int b = int.Parse(Console.ReadLine());

            for (int i = Math.Max(a, b); i >= Math.Min(a, b); i--)
            {
                Console.WriteLine(i);
            }

        }
        static void Ariketa2()
        {

        }
        static void Ariketa3()
        {

        }
        static void Ariketa4()
        {

        }
        static void Ariketa5()
        {

        }
        static void Ariketa6()
        {

        }
        static void Ariketa7()
        {

        }
        static void Ariketa8()
        {

        }
        static void Ariketa9()
        {

        }
        static void Ariketa10()
        {

        }
        static void Ariketa11()
        {

        }
        static void Ariketa12()
        {

        }
        static void Ariketa13()
        {

        }
        static void Ariketa14()
        {

        }
        static void Ariketa15()
        {

        }
        static void Ariketa16()
        {

        }
    }
}
