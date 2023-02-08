using System;

namespace enum_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine(((int)Gunler.Cumartesi));

            int sicaklik = 25;

            if(sicaklik <= ((int)HavaDurumu.Normal)){
                Console.WriteLine("Hava soğuk");
            }else if (sicaklik>=((int)HavaDurumu.Sicak)){
                Console.WriteLine("Hava sıcak");
            }else if (sicaklik>=(int)HavaDurumu.Normal && sicaklik <((int)HavaDurumu.CokSicak)){
                Console.WriteLine("Hadi motor sürelim");
            }
        }
    }
    
    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    
    {
        Soguk =5,
        Normal = 20,
        Sicak = 30,
        CokSicak = 35
    }
}
