using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine(Gunler.Pazar); 
           System.Console.WriteLine((int)Gunler.Cumartesi);

           int sicaklik =32;
           if (sicaklik <= (int)HavaDurumu.Normal)
           {
               System.Console.WriteLine("Dişariya Çikmak için Havanin İsinmasini Bekle.");
           }
           else if (sicaklik>= (int)HavaDurumu.Sicak)
           System.Console.WriteLine("Dişariya Çikmak için Çok Sicak Bir gün");
           else if (sicaklik>= (int)HavaDurumu.Normal && sicaklik<(int)HavaDurumu.CokSicak)
           System.Console.WriteLine("Hadi Dişariya Çikalim");
        }
    }

    enum Gunler 
    {
        Pazartesi=1,
        Sali,
        Çarşamba,
        Perşembe,
        Cuma =23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk=5,
        Normal =20,
        Sicak=25,
        CokSicak=30
    }
}