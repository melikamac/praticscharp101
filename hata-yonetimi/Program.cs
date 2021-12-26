using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                Console.WriteLine("Bir Sayı Giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen sayı:" + sayi);
            }
            catch(Exception ex){
                Console.WriteLine("Hata:"+ex.Message.ToString());
            }
            // finally{
            //     Console.WriteLine("İşlem tamamlandı.");
            // }

            try{
                // int a = int.Parse(null);
                // int a = int.Parse("test");
                byte a = byte.Parse("999");
            }
            catch (ArgumentNullException ex){
                Console.WriteLine("Boş değer girdiniz!");
                Console.WriteLine(ex);
            }
            catch(FormatException ex){
                Console.WriteLine("Veri tipi uygun değil!");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex){
                Console.WriteLine("Değişkenin veri aralığı dışında bir değer girdiniz!");
                Console.WriteLine(ex);
            }
            finally{
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }
        }
    }
}
