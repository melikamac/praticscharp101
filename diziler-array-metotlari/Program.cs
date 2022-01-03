using System;

namespace diziler_array_metotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort - Diziyi Sıralama
            int[] sayiDizisi = { 21, 7, 45, 26, 3, 9, 11, 89 };

            Console.WriteLine("*** Sırasız Dizi ***");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("*** Sıralı Dizi ***");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            // Clear - Dizideki, istenilen indexten,istenilen değerleri sıfırlama
            Console.WriteLine("*** Array Clear ***");
            Array.Clear(sayiDizisi, 2, 2);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            // Reverse - Tersine Çevirme işlemi 
            Console.WriteLine("*** Array Reverse ***");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            // IndexOf - Dizi elemanının kaçıncı indexte olduğunu görme
            Console.WriteLine("*** Array IndexOf ***");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 45));

            // Resize - Yeniden boyutlandırma
            Console.WriteLine("*** Array Resize ***");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 111;

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

        }
    }
}
