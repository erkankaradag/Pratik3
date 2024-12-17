using System;
namespace Pratik3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lüften bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.Read());

            if (sayi == 10)
            {
                Console.WriteLine("Girdiğiniz sayı 10'a eşittir.");
            }
            else if (sayi < 10)
            {
                Console.WriteLine("Girilen sayı 10'dan küçüktür.");
            }
            else
            {
                Console.WriteLine("Girilen sayı 10'dan büyüktür.");
            }
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Sayı tektir.");
            }
        }
    }
}