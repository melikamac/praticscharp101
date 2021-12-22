using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Atama ve İşlemli Atama ***");
            // atama ve işlemli atama
            // =, +=, -=, *=, /=
            int x = 3;
            int y = 3;
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            Console.WriteLine("*** Mantıksal Operatörler ***");
            // mantıksal öperatörler
            // ||, &&, !

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                Console.WriteLine("Perfect");

            if (isSuccess || isCompleted)
                Console.WriteLine("Great");

            if (isSuccess && !isCompleted)
                Console.WriteLine("Fine");

            Console.WriteLine("*** İlişkisel Operatörler ***");
            // ilişkisel operatörler
            // <, >, <=, >=, ==, !=

            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            Console.WriteLine("*** Aritmetik Operatörler ***");
            // aritmetik operatörler
            // +, -, *, /, %, ++, --

            int sayi = 10;
            int sayi2 = 5;
            int sonuc1 = sayi + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi - sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi % sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi++;
            Console.WriteLine(sayi);
            sonuc1 = sayi2--;
            Console.WriteLine(sayi2);

        }
    }
}
