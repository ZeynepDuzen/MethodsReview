using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndReview2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetinYaz("Merhaba methodlar dersleri");
            Console.WriteLine();
            Fruits("Watermelon, grape, melon, peach");
            Console.WriteLine();
            Vegetables("pea, okra, pumpkin, bell papper");

            Console.Read();
        }

        public static void MetinYaz(string p)
        {
            Console.Write("**********");
            Console.WriteLine();
            Console.Write(p);
            Console.WriteLine();
            Console.Write("**********");

        }

        public static void Fruits(string fruit)
        {
            Console.Write("**********");
            Console.WriteLine();
            Console.Write(fruit);
            Console.WriteLine();
            Console.Write("**********");
        }

        public static void Vegetables(string vegetable)
        {
            Console.Write("**********");
            Console.WriteLine();
            Console.Write(vegetable);
            Console.WriteLine();
            Console.Write("**********");
        }
    }
}
