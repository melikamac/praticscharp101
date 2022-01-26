using System;

namespace hazir_metotlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(1));
            Console.WriteLine(DateTime.Now.AddYears(2));
            Console.WriteLine(DateTime.Now.AddMilliseconds(26));

            // Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); //Günün sayısal karşılığı '26'
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Günün metinsel kısa karşılığı 'çar'
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Günün metinsel uzun karşılığı 'çarşamba'

            Console.WriteLine(DateTime.Now.ToString("MM"));  //Ayın sayısal karşılığı '01'
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Ayın metinsel kısa karşılığı 'Oca'
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//Ayın metinsel kuzun karşılığı 'Ocak'

            Console.WriteLine(DateTime.Now.ToString("yy"));  //Yılın kısa karşılığı '22'
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//Yılın uzun karşılığı '2022'

            // Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25)); //İçerideki sayıyı daima pozitif çıkartır
            Console.WriteLine(Math.Sin(15));
            Console.WriteLine(Math.Cos(15));
            Console.WriteLine(Math.Tan(15));

            Console.WriteLine(Math.Ceiling(10.3)); //Her zaman yukarıya yuvarlar
            Console.WriteLine(Math.Round(10.3));  //0,5 ten büyük ve küçüklüğüne göre yuvarlar
            Console.WriteLine(Math.Round(10.7)); //0,5 ten büyük ve küçüklüğüne göre yuvarlar
            Console.WriteLine(Math.Floor(10.7)); //Her zaman aşağıya yuvarlar

            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Pow(3,4)); // 3^4
            Console.WriteLine(Math.Sqrt(9));  // karekök
            Console.WriteLine(Math.Log(9));  //9 un e tabanındaki logoritmik karşılığı
            Console.WriteLine(Math.Exp(3)); //e üzeri 3 ün karşılığı
            Console.WriteLine(Math.Log10(10)); //10un logaritma 10 tabanındaki karşılığı
        }
    }
}
