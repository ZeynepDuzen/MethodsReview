using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Toplama islemi sonucu : " + ToplamaIslemi());
            Console.WriteLine();
            Console.WriteLine("Cikarma islemi sonucu : " + CikarmaIslemi());
            Console.WriteLine();
            Console.WriteLine("Bolme islemi sonucu : " + BolmeIslemi());
            Console.WriteLine();
            Console.WriteLine("Carpma islemi sonucu : " + CarpmaIslemi());

            Console.Read();
        }

        public static int ToplamaIslemi()
        {
            int sayi1 = 20;
            int sayi2 = 10;
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        public static int CikarmaIslemi()
        {
            int sayi1 = 50;
            int sayi2 = 30;
            int fark = sayi1 - sayi2;
            return fark;
        }

        public static int BolmeIslemi()
        {
            int sayi1 = 70;
            int sayi2 = 35;
            int bolum = sayi1 / sayi2;
            return bolum;
        }

        public static int CarpmaIslemi()
        {
            int sayi1 = 11;
            int sayi2 = 2;
            int carpim = sayi1 * sayi2;
            return carpim;
        }

    }
}
