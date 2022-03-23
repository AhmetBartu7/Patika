using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 den başlıyarak conssoldan girilen sayıya (sayı dahil) ortalama hesaplayarak console a yazdıran program
            Console.WriteLine("Lütfen Bir Sayı Giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            
            while (sayac<= sayi)
            {
                toplam += sayac;
                sayac++;

            }
            Console.WriteLine(toplam/sayi);

            // 'a' dan 'z' ye kadar tüm harfleri console a yazdır
            Char character = 'a';
            while (character <'z')
            {
                Console.Write(character);
                character++;
            }

            // Foreach
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
