using System;
using System.Collections;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            //liste.Add("Ayşe");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('A');

            // içindeki verilere erişim
            //System.Console.WriteLine(liste[1]);
            //foreach (var item in liste)
            //{
            //    System.Console.WriteLine(item);
            //}

            // AddRange
            string[] renkler = {"kirmizi", "sari", "yeşil"};
            List<int>sayilar = new List<int>(){1,8,3,7,9,92,5};
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            
            //Sort
            liste.Sort();

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            // Binary Search
            System.Console.WriteLine(liste.BinarySearch(9));

            
            //Reverse
            liste.Reverse();
            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }
            
            // Clear
            liste.Clear();
            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}