using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = { "köpek", "kuş", "aslan", "kaplan" };
            int[] dizi;
            dizi = new int[5];

            // Dizilere değer atama ve erişim
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            // Döngülerle dizi kullanımı
            // n tane sayının ortalamasını alan program

            Console.Write("Dizinin eleman sayısını giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz:", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            double toplam = 0;
            foreach (var sayi in sayiDizisi)
                toplam += sayi;

            Console.WriteLine("Ortalama :" + toplam / diziUzunlugu);

            int[] numberArray = new int[20];
            int sum = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.Write("{0}. Sayıyı girin:",i+1);
                numberArray[i] = Convert.ToInt32(Console.ReadLine());
                sum += numberArray[i];
            }
            double average = sum / 20;
            Console.WriteLine("Sayıların ortalaması:" + average);
        }
    }
}
