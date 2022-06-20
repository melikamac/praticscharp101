using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //system.collection.generic
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(10, "Melik Amaç");
            kullanicilar.Add(12, "Tolgahan Bitkin");
            kullanicilar.Add(20, "Ayşe Yılmaz");

            //dizinin elemanlarına erişim
            Console.WriteLine("***Elemanlara erişim***");
            Console.WriteLine(kullanicilar[10]);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //count
            Console.WriteLine("***Count***");

            Console.WriteLine(kullanicilar.Count);

            //contains
            Console.WriteLine("***Contains***");
            Console.WriteLine(kullanicilar.ContainsValue("Melik"));

            //remove
            Console.WriteLine("***Eleman Çıkarma***");
            kullanicilar.Remove(20);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //keys
            Console.WriteLine("***Keys***");
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }
            //values
            Console.WriteLine("***Values***");
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }

        }
    }
}
