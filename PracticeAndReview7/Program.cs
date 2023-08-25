using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview7
{
    internal class Program
    {
        static void Main(string[] args)
        {   // methods overload
            Console.WriteLine("Iki sinavin ortalamasi : "  + Ortalama(85,90));
            Console.WriteLine();
            Console.WriteLine("Uc sinavin ortalamasi : " + Ortalama(85,90,95));

            Console.Read();
        }

        public static int Ortalama(int sinav1,int sinav2)
        {
            int sonuc = (sinav1 + sinav2) / 2;
            return sonuc;
        }

        public static int Ortalama(int sinav1,int sinav2,int sinav3)
        {
            int sonuc = (sinav1 + sinav2 + sinav3) / 3;
            return sonuc;
        }
    }
}
