using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 1;         //1 byte 0,255   
            sbyte b = 1;        //1 byte -128,127  

            short c = 2;        //2 byte -32768,32768  
            ushort d = 2;       //2 byte 0,65365  

            Int16 i16 = 2;      //2 byte
            int i = 4;          //4 byte
            Int32 i32 = 4;      //4 byte
            Int64 i64 = 8;      //8 byte

            uint ui = 4;        //4 byte
            long l = 8;         //8 byte
            ulong ul = 8;       //8 byte

            //reel sayılar;
            float f = 4;        //4 byte
            double db = 8;      //8 byte
            decimal de = 16;    //16 byte 

            char ch = '2';       //2 byte tek karakter
            string str = "mma"; //sınırsız

            bool bl = true;
            bool bl2 = false;

            DateTime dt = DateTime.Now; //tarih ataması
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            //string ifadeler

            string str1 = string.Empty;
            str1 = "Melik Amaç";
            string ad = "melik";
            string soyad = "amaç";
            string tamIsim = ad + " " + soyad;

            //integer tanımlama şekilleri

            int int1 = 5;
            int int2 = 3;
            int int3 = int1 * int2;

            // Boolean

            bool bo1 = 10<2;

            // değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;            
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); //çıktı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);    //çıktı 40

            int int22 = int20 + int.Parse(str20);  //40
            Console.WriteLine(int22);

            //datetime

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);

            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime2);

            string hour = DateTime.Now.ToString("hh:mm");
            Console.WriteLine(hour);  

        }
    }
}
