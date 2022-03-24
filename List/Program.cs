using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collection.Generic
            // T-> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renklistesi = new List<string>();
            renklistesi.Add("Kirmizi");
            renklistesi.Add("Mavi");
            renklistesi.Add("Turuncu");
            renklistesi.Add("Sari");
            renklistesi.Add("Yeşil");

            //Count
            System.Console.WriteLine(renklistesi.Count);
            System.Console.WriteLine(sayiListesi.Count);

            
            //Foreach ve List ile elemanlara erişim
            foreach (var sayi in sayiListesi)
                System.Console.WriteLine(sayi);
            foreach (var renk in renklistesi)
                System.Console.WriteLine(renk);
            
            sayiListesi.ForEach(sayi=>System.Console.WriteLine(sayi));
            renklistesi.ForEach(renk=>System.Console.WriteLine(renk));

           
            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renklistesi.Remove("Yeşil");
            
            sayiListesi.RemoveAt(0);
            renklistesi.RemoveAt(1);
         
            sayiListesi.ForEach(sayi=>System.Console.WriteLine(sayi));
            renklistesi.ForEach(renk=>System.Console.WriteLine(renk));


            // Liste içerisinde Arama
            if (sayiListesi.Contains(10))
            System.Console.WriteLine("10 Liste içinde bulundu");

            // Eleman ile Index'e erişim
            System.Console.WriteLine(renklistesi.BinarySearch("Kirmizi"));

            // Diziyi List'e Çevirme
            string[] hayvanlar ={"Kedi","Köpek","Kuş"};
            List<string>hayvanListesi = new List<string>(hayvanlar);

            // Listeyi Nasıl Temizleriz
            hayvanListesi.Clear();

            
            
            // List içinde nesne Tutmak için
            List<Kullanicilar>kullaniciListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim="Bartu";
            kullanici1.Soyisim="Bilgili";
            kullanici1.Yas=29;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim="Mert";
            kullanici2.Soyisim="Bülbül";
            kullanici2.Yas=25;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar()
            {
                Isim="Deniz",
                Soyisim="Arda",
                Yas=24
            });

            foreach (var kullanici in kullaniciListesi)
            {
                System.Console.WriteLine("Kullanici Adi:"+ kullanici.Isim);
                System.Console.WriteLine("Kullanici Soyadi:"+ kullanici.Soyisim);
                System.Console.WriteLine("Kullanici Yaş:"+ kullanici.Yas);

            }

            yeniListe.Clear();

            

        }
    }


    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim {get => isim; set => isim = value;}
        public string Soyisim {get => soyisim; set => soyisim = value;}
        public int Yas {get => yas; set => yas = value;}



        
    }
}