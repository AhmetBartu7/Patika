using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Çalişan Sayisi: {0}", Calisan.CalisanSayisi);
            
            Calisan calisan = new Calisan("Ayşe","Yilmaz", "IK");
            System.Console.WriteLine("Çalişan Sayisi: {0}", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Deniz","Arda", "IT");
            Calisan calisan2 = new Calisan("Bartu","Bilgili", "GD");

            System.Console.WriteLine("Çalişan Sayisi: {0}", Calisan.CalisanSayisi);

            System.Console.WriteLine("Toplama İşlemi Sonucu: {0}", Islemler.Topla(100,200)
            );
            System.Console.WriteLine("Çikarma İşlemi Sonucu: {0}", Islemler.Cikar(400,50)
            );

        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim ;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
                calisanSayisi =0;

        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim=soyisim;
            this.Departman=departman;
            calisanSayisi ++;
        }
        

    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}