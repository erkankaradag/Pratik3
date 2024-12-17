# C# If-Else Yapısı ile Sayı Kontrolü

Bu proje, C# programlama dilinde **if-else** yapısı kullanarak bir sayının çeşitli özelliklerini kontrol eden basit bir uygulamadır.

## Proje Açıklaması

Program kullanıcıdan bir sayı alır ve aşağıdaki kontrolleri yapar:

1. **Sayının 10 ile ilişkisi**
   - Sayı 10'dan küçük mü?
   - Sayı 10'a eşit mi?
   - Sayı 10'dan büyük mü?
2. **Sayının tek veya çift olup olmadığı**
   - Sayı çiftse: "Sayı çifttir."
   - Sayı tekse: "Sayı tektir."

## Kullanılan Araçlar ve Teknolojiler
- **Dil**: C#
- **Platform**: .NET Console Application

## Kod Parçacığı

```csharp
using System;

namespace Pratik3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan bir sayı al
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            // Sayının 10 ile ilişkisini kontrol et
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

            // Sayının tek mi çift mi olduğunu kontrol et
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
```

## Kurulum ve Çalıştırma

1. Projeyi bir **.NET Console Application** projesi olarak oluşturun.
2. Yukarıdaki kodu **Program.cs** dosyanıza yapıştırın.
3. Uygulamayı çalıştırarak bir sayı girin ve sonucu gözlemleyin.

## Örnek Çıktı

### Girdi: 7
```
Lütfen bir sayı giriniz: 7
Girilen sayı 10'dan küçüktür.
Sayı tektir.
```

### Girdi: 10
```
Lütfen bir sayı giriniz: 10
Girdiğiniz sayı 10'a eşittir.
Sayı çifttir.
```

### Girdi: 14
```
Lütfen bir sayı giriniz: 14
Girilen sayı 10'dan büyüktür.
Sayı çifttir.
```

## Katkıda Bulunma
Proje geliştirmeleri ve iyileştirmeleri için **Pull Request** göndermekten çekinmeyin.

## Lisans
Bu proje MIT lisansı altında sunulmaktadır.
