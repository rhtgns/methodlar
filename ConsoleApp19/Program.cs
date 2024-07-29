using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;


namespace GeriyeDeğerDöndürmeyenBirvoidmetot
{
     class Program
    {
        static void SarkıSozu(string mesaj)
        {
            Console.WriteLine(mesaj);
        }

        static void Main(string[] args)
        {
            // Metot çağrısı
            SarkıSozu("I'm just so tired to share my nights i wanna cry and i wanna love");
        }




    }



}




namespace GtGeriyeTamsayıDöndürenBirmetot {


    class Program
    {
        static int RastgeleSayiMod2()
        {
            // Rastgele sayı üretmek için Random sınıfını kullan
            Random random = new Random();
            int rastgeleSayi = random.Next(); // Rastgele bir tamsayı üret

            // Sayının 2'ye bölümünden kalanı hesapla ve geri döndür
            return rastgeleSayi % 2;
        }

        static void Main(string[] args)
        {
            // Metot çağrısı ve sonucu ekrana yazdırma
            int sonuc = RastgeleSayiMod2();
            Console.WriteLine("Rastgele sayının 2'ye bölümünden kalan: " + sonuc);
        }

    }


    //Parametre Alan ve Geriye Değer Döndüren Bir Metot
    class Program
    {
        // Parametre alan ve geriye tamsayı döndüren metot
        static int Topla(int sayi1, int sayi2)
        {
            // İki sayının toplamını hesapla ve geri döndür
            return sayi1 * sayi2;
        }

        static void Main(string[] args)
        {
            // Metot çağrısı ve sonucu ekrana yazdırma
            int sonuc = Topla(5, 7);
            Console.WriteLine("Toplam: " + sonuc);
        }
    }

    //Parametre Alan ve Geriye Değer Döndürmeyen bir Metot

    using System;

class Program
    {
        // Parametre alan ve geriye değer döndürmeyen metot
        static void HosgeldinizYazdir(string isim, string soyisim)
        {
            // Mesajı oluştur ve ekrana yazdır
            Console.WriteLine("Hoş Geldiniz " + isim + " " + soyisim);
        }

        static void Main(string[] args)
        {
            // Metot çağrısı
            HosgeldinizYazdir("Ahmet", "Yılmaz");
        }
    }

   
