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

            List<int> sayiListesi = new List <int>();

            sayiListesi.Add(24);
            sayiListesi.Add(34);
            sayiListesi.Add(92);
            sayiListesi.Add(4);
            sayiListesi.Add(10);
            sayiListesi.Add(5);

            List<string> renkListesi = new List <string>();

            renkListesi.Add("kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("turuncu");
            renkListesi.Add("mor");
            renkListesi.Add("siyah");
            renkListesi.Add("sarı");

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

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
        }    
    }
}

