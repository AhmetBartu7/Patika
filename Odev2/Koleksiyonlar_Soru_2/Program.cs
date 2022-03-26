using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        //Soru - 2: 
        //Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
        //her iki grubun kendi içerisinde ortalamalarını alan 
        //ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
        //(Array sınıfını kullanarak yazınız.)
        static void Main(string[] args)
        {
           int[] sayilar=new int[20];     
           int enkucuklertoplam = 0;
           int enbuyuklertoplam = 0;

        for (int i=0;i<20;i++)
        {
        Console.Write("{0}. sayıyı girin:",i+1);
        sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }

    

         Array.Sort(sayilar);
         int enKucuk = sayilar[0];
         int enKucuk1 = sayilar[1];
         int enKucuk2 = sayilar[2];
   
         int enBuyuk = sayilar[19];
         int enBuyuk1 = sayilar[18];
         int enBuyuk2 = sayilar[17];

    
         Console.WriteLine("Girilen en küçük sayılar={0}", enKucuk);
         Console.WriteLine("Girilen en küçük sayılar={0}", enKucuk1);
         Console.WriteLine("Girilen en küçük sayılar={0}", enKucuk2);
         Console.WriteLine("Girilen en büyük sayılar={0}", enBuyuk);
         Console.WriteLine("Girilen en büyük sayılar={0}", enBuyuk1);
         Console.WriteLine("Girilen en büyük sayılar={0}", enBuyuk2);
         Console.WriteLine("Girilen en büyük sayılar={0}", enBuyuk2);
    

    
         enbuyuklertoplam=(enBuyuk+enBuyuk1+enBuyuk2);
         enkucuklertoplam=(enKucuk+enKucuk1+enKucuk2);
         Console.WriteLine(enbuyuklertoplam/3);
         Console.WriteLine(enkucuklertoplam/3);
         Console.WriteLine((enbuyuklertoplam/3)+(enkucuklertoplam/3));

         Console.ReadKey();
            }
        }
     }