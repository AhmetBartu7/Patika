using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("*********Çalışan 1*****************");
           Calisan calisan1 = new Calisan("Bartu","Bilgili",123456,"Game Developer");
           calisan1.CalisanBilgileri();

            System.Console.WriteLine("*********Çalışan 2*****************");
            Calisan calisan2 = new Calisan();
            calisan2.Ad="Ahmet";
            calisan2.Soyad="Bitkin";
            calisan2.No=256184;
            calisan2.Departman="Game Designer";

            calisan2.CalisanBilgileri();
            System.Console.WriteLine("*********Çalışan 3*****************");
            Calisan calisan3 = new Calisan("Barış","Kutu");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad= ad;
            this.Soyad= soyad;
            this.No=no;
            this.Departman=departman;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad= ad;
            this.Soyad= soyad;
            
        }

        public Calisan(){}

        public void CalisanBilgileri()
        {
            System.Console.WriteLine("Calisanin Adi:{0}", Ad);
            System.Console.WriteLine("Calisanin Soyadi:{0}", Soyad);
            System.Console.WriteLine("Calisanin Numarası:{0}", No);
            System.Console.WriteLine("Calisanin Departmani:{0}", Departman);
            
            
        }


    }
}