using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    
//Soru - 1: 
//Klavyeden girilen 20 adet pozitif sayının 
//asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)


    internal class Program
    {
       public static bool asalmi(int sayi)
        {
            bool durum = false;
 
            int kontrol = 0;
 
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0) 
                {
                    kontrol = 1;
                    break;
                }
            }
            if (kontrol == 1)
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            return durum;
        }
        

        
 
        static void Main(string[] args)
        {
           
            int toplam = 0, ortalama = 0;
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanSayilar = new ArrayList();
            for (int i = 0; i < 20; i++)
            { 
                Console.Write("Sayiyi Girin : ");
                int s = Convert.ToInt32(Console.ReadLine());
                toplam += s;

                if (asalmi(s))
                {
                    asalSayilar.Add(s);
                }
                else
                {
                    asalOlmayanSayilar.Add(s);
                }
            }
            
            
            ortalama = toplam / 10;
            Console.WriteLine();
            
            Console.WriteLine("ASAL SAYILAR");
            foreach (int sayi in asalSayilar)
            {
                Console.Write(sayi + "    ");
            }
            Console.WriteLine();
            Console.WriteLine("ASAL OLMAYAN SAYILAR");
            
            foreach (int sayi in asalOlmayanSayilar)
            {
                Console.Write(sayi + "    ");
            }
 
            Console.WriteLine();
            
            Console.WriteLine("SAYILARIN ORTALAMASI : {0}",ortalama);
            
 
 
            Console.ReadKey();
        }
    }
}