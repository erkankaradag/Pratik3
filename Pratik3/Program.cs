using System;
namespace Pratik3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan sayı int olarak dönüştürülür ve ardından sayı, 10 sayısından küçük, büyük veya eşitmi olarak if else yapısı kullanılarak kontrol edilir. 
            
            Console.Write("Lüften bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

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

            // sayı tek mi çift mi olarak kontol edilir ve ekrana sonuç yazdırılır.
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
