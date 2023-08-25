using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yazdir();
            ToplamaMethodu();
            SayiListe();


            Console.Read();
        }

        public static void Yazdir()
        {
            Console.WriteLine("Bu bir methoddur");
            Console.WriteLine();
            Console.WriteLine("Bu, methodun bir diger satiridir");
            Console.WriteLine();
        }

        public static void ToplamaMethodu()
        {
            int sayi1 = 25, sayi2 = 20, sayi3 = 30;
            int toplam = sayi1 + sayi2 + sayi3;
            Console.WriteLine("Toplam : " + toplam);
            Console.WriteLine();
        }

        public static void SayiListe()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
