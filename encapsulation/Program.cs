using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Melik";
            ogrenci.Soyisim = "Amaç";
            ogrenci.OgrenciNo = 647;
            ogrenci.Sinif = 11;

            ogrenci.SinifDusur();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci2 = new Ogrenci("Tolga","Bitkin",1,250);
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();
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
            set { isim = value; }
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf 1'den küçük olamaz");
                    sinif = 1;
                }
                else
                    sinif = value;
            }
        }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }

        public Ogrenci(string isim, string soyisim, int sinif, int ogrenciNo)
        {
            Isim = isim;
            Soyisim = soyisim;
            Sinif = sinif;
            OgrenciNo = ogrenciNo;
        }
        public Ogrenci() { }
        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("************ Öğrenci Bilgileri **********");
            Console.WriteLine("Öğrenci Adı      : {0}", this.Isim);
            Console.WriteLine("Öğrenci Soyismi  : {0}", this.Soyisim);
            Console.WriteLine("Öğrenci Nosu     : {0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı   : {0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}