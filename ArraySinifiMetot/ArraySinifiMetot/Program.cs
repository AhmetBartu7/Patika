using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySinifiMetot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

            // Sırasız Dizi
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine();

            }

            //Sıralı Dizi
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Clear

            Array.Clear(sayiDizisi,2,2);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Reverse
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


            // IndexOf
            
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));


            //Resize

            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


        }
    }
}
