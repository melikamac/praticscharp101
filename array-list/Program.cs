using System;
using System.Collections;
using System.Collections.Generic;

namespace array_list
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            // liste.Add("Melik");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('M');

            //array list verilerine erişim
            // Console.WriteLine(liste[1]);

            // foreach (var item in liste)
            // {
            //     Console.WriteLine(item);
            // }

            //AddRange
            Console.WriteLine("*******Add Range*******");
            // string[] renkler = {"mavi","siyah","kırmızı","sarı"};
            List<int> sayilar = new List<int>() { 1, 8, 9, 3, 7, 90, 2 };
            // liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //sort
            Console.WriteLine("**********ArrayList Sort***********");
            liste.Sort();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //binary search
            Console.WriteLine("**********Binary Search***********");
            Console.WriteLine(liste.BinarySearch(9));

            //reverse
            Console.WriteLine("**********Reverse***********");
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            liste.Clear();
        }
    }
}
