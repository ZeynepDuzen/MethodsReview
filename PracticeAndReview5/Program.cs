using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toplama islemi sonucu : " + Toplama(10,20));
            Console.WriteLine("Cikarma islemi sonucu : " + Cikarma(50,20));
            Console.WriteLine("Carpma islemi sonucu : " + Carpma(11,11));
            Console.WriteLine("Bolme isleminin sonucu : " + Bolme(100,10));

            Console.Read();
        }

        public static int Toplama(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }

        public static int Cikarma(int sayi1,int sayi2)
        {
            int fark = sayi1 - sayi2;
            return fark;
        }

        public static int Carpma(int sayi1,int sayi2)
        {
            int carpim = sayi1 * sayi2;
            return carpim;
        }

        public static int Bolme(int sayi1,int sayi2)
        {
            int bolum = sayi1 / sayi2;
            return bolum;
        }
    }
}
