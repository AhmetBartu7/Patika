using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Erişim Belirleyiciler
            //*Public
            //*Private
            //*Internal
            //*Protected


            Calisan calisan1 = new Calisan();
            calisan1.Ad="Bartu";
            calisan1.Soyad="Bilgili";
            calisan1.No=123456;
            calisan1.Departman="Game Developer";

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad="Ahmet";
            calisan2.Soyad="Bitkin";
            calisan2.No=256184;
            calisan2.Departman="Game Designer";

            calisan2.CalisanBilgileri();




        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            System.Console.WriteLine("Calisanin Adi:{0}", Ad);
            System.Console.WriteLine("Calisanin Soyadi:{0}", Soyad);
            System.Console.WriteLine("Calisanin Numarası:{0}", No);
            System.Console.WriteLine("Calisanin Departmani:{0}", Departman);
            
            
        }


    }
}