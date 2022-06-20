using System;
using System.Collections;

namespace array_list
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Melik");
            liste.Add(2);
            liste.Add(true);
            liste.Add('M');

            //array list verilerine erişim
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(liste);
            }

        }
    }
}
