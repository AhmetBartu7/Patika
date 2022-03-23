using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i < sayac; i++)
            {
                if (i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            // 1 ile 1000 arasındakş tek ve çift sayıların toplamını yazdır
            int TekToplam = 0;
            int CiftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i%2 ==1)
                {
                    TekToplam += i; // Tek Toplam + i
                }
                else
                {
                    CiftToplam += i; // Çift Toplam + i
                }
            }
            Console.WriteLine("Tek Toplam: " + TekToplam);
            Console.WriteLine("Çift Toplam: " + CiftToplam);




            // Break, continue

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
                
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }




        }
    }
}
