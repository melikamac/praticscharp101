// Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
// Negatif ve numeric olmayan girişleri engelleyin.
// Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
// Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

using System.Collections;
using System.Text.RegularExpressions;

ArrayList asalSayi = new ArrayList();
ArrayList normalSayi = new ArrayList();
int kontrol = 0;

for (int i = 1; i <= 20; i++)
{   
    Console.Write("{0}.Sayıyı giriniz:",i);    
    bas:
    string say = Console.ReadLine();
    if (Sayimi(say)){
        int sayi = Convert.ToInt32(say);
    for (int j = 2; j < sayi; j++)
    {
        if (sayi % j == 0)
        {
            kontrol++;
        }
    }
    if (kontrol == 0)
    {
        asalSayi.Add(sayi);
    }
    else
    {
        normalSayi.Add(sayi);
    }
    kontrol = 0;
    }
    else{
        Console.Write("Yanlış değer girdiniz. Lütfen {0}.sayıyı giriniz:",i);
        goto bas;
    }
    
}

Boolean Sayimi(string say){
    if(String.IsNullOrEmpty(say)== true){
        return false;
    }
    else{
        Regex sayiKontrolu = new Regex("^[0-9]*$");
        return sayiKontrolu.IsMatch(say);
    }
}

asalSayi.Sort();
asalSayi.Reverse();
float asalAv =0;
normalSayi.Sort();
normalSayi.Reverse();
float normalAv = 0;


Console.WriteLine("***Asal Olmayan Sayılar***");
foreach (var nSayi in normalSayi)
{
    Console.WriteLine(nSayi);
    normalAv = normalAv + Convert.ToInt32(nSayi);
}
Console.WriteLine($"Toplam {normalSayi.Count} normal sayı girişi yapılmıştır ve ortalaması {normalAv / normalSayi.Count}");
Console.WriteLine("***Asal Olan Sayılar***");
foreach (var aSayi in asalSayi)
{
    Console.WriteLine(aSayi);
    asalAv = asalAv + Convert.ToInt32(aSayi);
}
Console.WriteLine($"Toplam {asalSayi.Count} asal sayı girişi yapılmıştır ve ortalaması {asalAv / asalSayi.Count}");




