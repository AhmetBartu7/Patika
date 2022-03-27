using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim ="Ayşe ";
            ogrenci.Soyisim="Yilmaz";
            ogrenci.OgrenciNo=293;
            ogrenci.Sinif=3;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz","Arda",256,1);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();



            
        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim 
        { 
             get { return isim; }
             set { isim = value;} 
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif; 
            set 
            {
                if(value <1)
                {
                    System.Console.WriteLine("Sinif En Az 1 Olabilir");
                    sinif=1;
                }
                else
                sinif = value;
            }  
         }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            System.Console.WriteLine("**********Öğrenci Bilgileri***********");
            System.Console.WriteLine("Öğrenci Adi        :{0}",this.isim);
            System.Console.WriteLine("Öğrenci Soyadi        :{0}",this.soyisim);
            System.Console.WriteLine("Öğrenci No        :{0}",this.ogrenciNo);
            System.Console.WriteLine("Öğrenci Sinifi        :{0}",this.sinif);
            
            
        }


        public void SinifAtlat()
        { 
            this.sinif= this.sinif +1;
        }

         public void SinifDusur()
        { 
            this.sinif= this.sinif -1;
        }
    }
}