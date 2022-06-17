using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //<T> object türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(24);
            sayiListesi.Add(34);
            sayiListesi.Add(92);
            sayiListesi.Add(4);
            sayiListesi.Add(10);
            sayiListesi.Add(5);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("turuncu");
            renkListesi.Add("mor");
            renkListesi.Add("siyah");
            renkListesi.Add("sarı");

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //foreach ve list.foreach ile elamanlara erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //listeden eleman çıkarma,
            // sayiListesi.Remove(4);
            // renkListesi.Remove("Yeşil");

            // sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            // renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //liste içerisinde arama
            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içerisinde bulundu");
            }

            //eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("mavi"));

            //diziyi listeye çevirme
            string[] hayvanlar = { "Kedi", "köpek", "kuş" };
            List<String> hayvanListesi = new List<string>(hayvanlar);

            //listeyi temizleme
            hayvanListesi.Clear();

            //list içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "melik";
            kullanici1.Soyisim = "amaç";
            kullanici1.Yas = 23;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "mami";
            kullanici2.Soyisim = "amaç";
            kullanici2.Yas = 25;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();

            yeniListe.Add(new Kullanicilar(){
                Isim ="tolga",
                Soyisim="bitkin",
                Yas=23
            });

            foreach (Kullanicilar kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanici adı:"+ kullanici.Isim);
                Console.WriteLine("Kullanici adı:"+ kullanici.Soyisim);
                Console.WriteLine("Kullanici adı:"+ kullanici.Yas);
            }

            yeniListe.Clear();
        }
    }
    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}