using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performans
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("         YURDUM LOKANTA          ");
            Console.WriteLine("");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            menu();
            secim();
            Console.ReadKey();

        }

        static void menu()
        {
            Console.WriteLine("|             MENÜ          |");
            Console.WriteLine("");
            Console.WriteLine("| - Patates Kızartması 40TL |");
            Console.WriteLine("| - Salata             20TL |");
            Console.WriteLine("| - Ekmek               5TL |");
            Console.WriteLine("| - Reçel              15TL |");
            Console.WriteLine("| - Kaymak             30TL |");
            Console.WriteLine("| - Sosis              19TL |");
            Console.WriteLine("| - Sucuk              25TL |");
            Console.WriteLine("| - Salam              20TL |");
            Console.WriteLine("| - Yumurta            5TL  |");
            Console.WriteLine("");
            Console.WriteLine("-------------(1)--------------");

            Console.WriteLine("Almak İstediğiniz Ürünün Baş Harfini Giriniz: ");
            

        }

        static void secim()
        {
            string secim = Console.ReadLine();
            if (secim == "P" || secim == "p")
            {
                Console.WriteLine("Kaç Adet Patates Kızartması Almak İstiyorsunuz?");
                int adet = Convert.ToInt32(Console.ReadLine());
                int p = 40;
                int hesap = p * adet;
                Console.WriteLine("Hesap Tutarınız Bu kadardır: " + hesap);
                System.Threading.Thread.Sleep(1000);

                Console.Clear();

                Console.WriteLine("Menüye Dönmek İçin (1) , Uygulamayı Kapatmak İçi (2)");
                int menuKapama = Convert.ToInt32(Console.ReadLine());
                if (menuKapama == 1)
                {
                    menu();

                }
                else if (menuKapama == 2)
                {

                    Console.ReadKey();
                }
            }
            else if (secim == "e" || secim == "E")
            {
                Console.WriteLine("Kaç Adet Salata Almak İstiyorsunuz?");
                int adet = Convert.ToInt32(Console.ReadLine());
                int s = 20;
                int hesap = s * adet;
                Console.WriteLine("Hesap Tutarınız Bu kadardır: " + hesap);
                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("Menüye Dönmek İçin (1) , Uygulamayı Kapatmak İçi (2)");
                int menuKapama = Convert.ToInt32(Console.ReadLine());
                if (menuKapama == 1)
                {
                    menu();

                }
                else if (menuKapama == 2)
                {

                    Console.ReadKey();
                }
            }
            else if (secim == "s" || secim == "S")
            {
                Console.WriteLine("Kaç Adet Salata Almak İstiyorsunuz?");
                int adet = Convert.ToInt32(Console.ReadLine());
                int s = 20;
                int hesap = s * adet;
                Console.WriteLine("Hesap Tutarınız Bu kadardır: " + hesap);
                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("Menüye Dönmek İçin (1) , Uygulamayı Kapatmak İçi (2)");
                int menuKapama = Convert.ToInt32(Console.ReadLine());
                if (menuKapama == 1)
                {
                    menu();

                }
                else if (menuKapama == 2)
                {

                    Console.ReadKey();
                }
            }
        }
    }
}
