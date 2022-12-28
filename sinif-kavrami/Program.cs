using System;

namespace sinif_kavrami
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
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Melik";
            calisan1.Soyad = "Amaç";
            calisan1.No = 14725836;
            calisan1.Departman = "Bilgi İşlem";

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Muhammet";
            calisan2.Soyad = "Amaç";
            calisan2.No = 14725836;
            calisan2.Departman = "Planlama";

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
            Console.WriteLine("Çalışan adı:{0}", Ad);
            Console.WriteLine("Çalışan soyadı:{0}", Soyad);
            Console.WriteLine("Çalışan numarası:{0}", No);
            Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
        }
    }
}
