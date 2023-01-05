using System;

namespace kurucu_metotlar
{

    class Program
    {
        static void Main(string[] args)
        {
            //erişim belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected
            Console.WriteLine("***************Çalışan1***************");
            Calisan calisan1 = new Calisan("Melik","Amaç",147258369,"Bilgi İşlem");
            calisan1.CalisanBilgileri();

            Console.WriteLine("***************Çalışan2***************");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Muhammet";
            calisan2.Soyad = "Amaç";
            calisan2.No = 14725836;
            calisan2.Departman = "Planlama";
            calisan2.CalisanBilgileri();

            Console.WriteLine("***************Çalışan3***************");
            Calisan calisan3 = new Calisan("Melik","Amaç");
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
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
         public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public Calisan(){}

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan adı:{0}", Ad);
            Console.WriteLine("Çalışan soyadı:{0}", Soyad);
            Console.WriteLine("Çalışan numarası:{0}", No);
            Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
        }
    }
}
