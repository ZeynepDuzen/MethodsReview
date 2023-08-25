using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayiyi girin : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci sayiyi girin  :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplama islemi sonucu : " + Topla(sayi1,sayi2));
            Console.WriteLine("Cikarma islemi sonucu : " + Cikar(sayi1,sayi2));
            Console.WriteLine("Carpma islemi sonucu : " + Carp(sayi1,sayi2));
            Console.WriteLine("Bolme islemi sonucu : " + Bol(sayi1,sayi2));
            Console.WriteLine("Bolme2 islemi sonucu : " + Bol2(8,2));

            Console.Read();
        }

        public static int Topla(int sayi1,int sayi2)
        {
            int topla = sayi1 + sayi2;
            return topla;
        }

        public static int Cikar(int sayi1,int sayi2)
        {
            int fark = sayi1 - sayi2;
            return fark;
        }

        public static int Carp(int sayi1,int sayi2)
        {
            int carp = sayi1 * sayi2;
            return carp;
        }

        public static int Bol(int sayi1,int sayi2)
        {
            int bol = sayi1 / sayi2;
            return bol;
        }

        public static int Bol2(int sayi1,int sayi2)
        {
            int bol = sayi1 / sayi2;
            return bol;
        }
       
    }
}
