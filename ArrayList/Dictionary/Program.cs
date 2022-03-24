using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // System.Collections.Generic
           Dictionary<int,string>kullanicilar = new Dictionary<int, string>();

           kullanicilar.Add(10, "Ayşe Yilmaz");
           kullanicilar.Add(12, "Ahmet Yilmaz");
           kullanicilar.Add(18, "Deniz Arda");
           kullanicilar.Add(20, "Pelin Su");

           // Dizinin elemanlarına erişim
           System.Console.WriteLine(kullanicilar[12]);
           foreach (var item in kullanicilar)
           {
               System.Console.WriteLine(item);
           }

          
           //Count
           System.Console.WriteLine(kullanicilar.Count);

           
           //Contains
           System.Console.WriteLine(kullanicilar.ContainsKey(12));
           System.Console.WriteLine(kullanicilar.ContainsValue("Bartu Bilgili"));

           
           //Remove
           kullanicilar.Remove(12);
           foreach (var item in kullanicilar)
           {
               System.Console.WriteLine(item);
           }

          
           //Keys
           foreach (var item in kullanicilar.Keys)
           {
               System.Console.WriteLine(item);
           }
           
           
           //Values
            foreach (var item in kullanicilar.Values)
           {
               System.Console.WriteLine(item);
           }


        }
    }
}