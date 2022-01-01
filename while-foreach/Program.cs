using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1den başlayarak konsoldan girilen sayıya kadar ortalama hesaplayıp konsola yazdırma
            Console.Write("Sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine()); //10
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)   
            {
              toplam += sayac;    
              sayac ++;
            }
            Console.WriteLine(toplam/sayi);

            // 'a' dan 'z' ye kadar tüm harfleri konsola yazdırma
            char character = 'a';            
            while (character<'z')
            {
                Console.Write(character);
                character ++;
            }

            Console.WriteLine("*** Foreach ***");

            string[] arabalar = {"mustang","dodge","astonmartin","tofaşslx1.6"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
