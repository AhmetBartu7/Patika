using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OUT Parametreler
            string sayi ="999";
            int outSayi;

            bool sonuc= int.TryParse(sayi, out  outSayi);
            if(sonuc)
            {
                System.Console.WriteLine("Basarili");
                System.Console.WriteLine( outSayi);
            }
            else
            {
                System.Console.WriteLine("Basarisiz");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4,5, out int toplamSonucu);
            System.Console.WriteLine(toplamSonucu);

            //Metot Aşırı Yükleme = Overloading

            int ifade = 777;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("BB","7");

            // Metot İmzası
            // MetotAdı + parametre sayisi + parametre
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a+b;

        }

        public void EkranaYazdir(string veri)
        {
            System.Console.WriteLine( veri);
        }

          public void EkranaYazdir(int veri)
        {
            System.Console.WriteLine( veri);
        }

          public void EkranaYazdir(string veri1, string veri2)
        {
            System.Console.WriteLine( veri1 + veri2);
        }
    }
}