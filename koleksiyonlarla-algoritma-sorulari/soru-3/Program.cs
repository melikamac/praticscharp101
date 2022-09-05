//Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

using System.Collections;

Console.WriteLine("Bir cümle giriniz:");
string cumle = Console.ReadLine();
string sesliHarfler = "aeıioöuü";
ArrayList sesliDizi = new ArrayList();
if (!string.IsNullOrEmpty(cumle))
{
    string cumleK = cumle.ToLower();
    for (int i = 0; i < cumle.Length; i++)
    {
        if (sesliHarfler.Contains(cumleK[i]))
        {
            sesliDizi.Add(cumleK[i]);
        }
    }
}

sesliDizi.Sort();

foreach (var harf in sesliDizi)
{
    Console.WriteLine(harf);
}
