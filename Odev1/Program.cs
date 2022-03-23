using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public void Soru1()
        {
           //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. 

            System.Console.WriteLine("Pozitif Bir Sayi Giriniz:");
            int n = int.Parse(Console.ReadLine());
            int a =0;
            int[] sayilar = new int[n];
            for(int i =0; i < n; i++)
            {
                System.Console.WriteLine("Sayi Giriniz:");
                a= int.Parse(Console.ReadLine());
                sayilar[i]= a;
            }
            System.Console.WriteLine("Çift Sayilar:");
            foreach( var item in sayilar)
            {
                if(item %2 == 0)
                System.Console.WriteLine(item);
            }
        }

        public void Soru2()
        {
             //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            
            System.Console.WriteLine("Pozitif Sayi Giriniz:");
            int n = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Pozitif Sayi Giriniz:");
            int m = int.Parse(Console.ReadLine());

            int[] sayilar = new int[n];

            for (int i =0; i<n; i++)
            {
              Console.WriteLine("Lütfen {0}. Sayiyi Giriniz",i+1);
              sayilar[i] = int.Parse(Console.ReadLine());  
            }
            
            for (int i = 0; i < sayilar.Length; i++)
            {
              int kalan = sayilar[i]%2;
              
              if(sayilar[i]%m == 0 || sayilar[i] == m ){
              Console.WriteLine(sayilar[i]);     



            }
        }

        static async void Soru3(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            
            System.Console.WriteLine("Pozitif Sayi Giriniz:");
            int n = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Pozitif Sayi Giriniz:");
            int m = int.Parse(Console.ReadLine());

            int[] sayilar = new int[n];

            for (int i =0; i<n; i++)
            {
              Console.WriteLine("Lütfen {0}. Sayiyi Giriniz",i+1);
              sayilar[i] = int.Parse(Console.ReadLine());  
            }
            
            for (int i = 0; i < sayilar.Length; i++)
            {
              int kalan = sayilar[i]%2;
              
              if(sayilar[i]%m == 0 || sayilar[i] == m ){
              Console.WriteLine(sayilar[i]);     



            }
            
            
          
        }
        static async void Soru4(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("Rastgele Bir Cümle Yaziniz :");
            string cumle = Console.ReadLine();
            string[] kelime = cumle.Split(" ");
            char[] harf = cumle.ToCharArray();

            Console.WriteLine("Cumlede {0} Kelime Vardir.", kelime.Length);
            Console.WriteLine("Cumlede {0} Harf Vardir.", harf.Length);
        }
        




        
    }
  }
 }
}