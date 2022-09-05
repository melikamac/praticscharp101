// Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

int [] numbers= new int[20];
int [] enBuyukler = new int[3];
int [] enKucukler = new int[3];

for(int i = 0 ; i < 6; i++){
    Console.Write("{0}. Sayıyı giriniz:",i+1);
    int sayi = Convert.ToInt32(Console.ReadLine());
    numbers[i] = sayi;
}

Array.Sort(numbers);
for (int j = 0; j < 3; j++)
{
    enKucukler[j]=numbers[j];
}

Array.Reverse(numbers);
for (int j = 0; j < 3; j++)
{
    enBuyukler[j]=numbers[j];
}

Console.WriteLine($"En büyüklerin ortalaması:{Math.Round(enBuyukler.Average(),2)}");
Console.WriteLine($"En küçüklerin ortalaması:{Math.Round(enKucukler.Average(),2)}");
Console.WriteLine($"Ortalamaların toplamı {Math.Round((enBuyukler.Average()+enKucukler.Average()),2)}");