using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soru - 3: 
            

            char[] harfler = { 'a', 'e', 'i', 'o', 'u', 'ü' };
            string cumle;
            int sayac = 0;
            Console.WriteLine("Metin giriniz : ");
            cumle = Console.ReadLine();
            for (int i = 0; i < harfler.Length; i++)
            {
                for (int j = 0; j < cumle.Length; j++)
                {
                    if (cumle[j] == harfler[i])
                    {
                        sayac++;
                    }
                }
            }
            Console.WriteLine(sayac);
            Console.ReadLine();
        }
    }
}