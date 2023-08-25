using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lutfen bir kelime girin : ");
            string kelime = Console.ReadLine();
            MetinYaz(kelime);

            Console.WriteLine("Lutfen bir sayi girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            SayiYaz(sayi);

            Console.WriteLine("Lutfen bir renk ismi girin : ");
            string renkInput = Console.ReadLine();

            RenkYaz(renkInput);

            Console.Read();
        }

        public static void MetinYaz(string kelime)
        {
            Console.WriteLine("Girilen kelime :" + kelime);
        }

        public static void SayiYaz(int sayi)
        {
            Console.WriteLine("Girilen sayi : " + sayi);
        }

        public static void RenkYaz(string renkInput)
        {
            Console.WriteLine("Girdiginiz renk : " + renkInput);
        }
    }
}
