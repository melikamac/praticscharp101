using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //Expression-kontrol edilmek istenen koşul
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayındayız");
                    break;
                case 12:
                    Console.WriteLine("Aralık ayındayız");
                    break;
                case 2:
                    Console.WriteLine("Şubat ayındayız");
                    break;
                case 3:
                    Console.WriteLine("Mart ayındayız");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayındayız");
                    break;
                default:
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış ayındayız");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar ayındayız");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz ayındayız");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar ayındayız");
                    break;

                default:
                    break;
            }
        }
    }
}
