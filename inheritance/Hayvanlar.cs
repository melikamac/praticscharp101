using System;

namespace inheritance
{
    public class Hayvanlar : Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }
    }
    public class Surungenler : Hayvanlar
    {
        public Surungenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SurenerekHareket()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }
    public class Kuslar : Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void UcarakHareket()
        {
            Console.WriteLine("Kuşlar kanatlarıyla uçabilir.");
        }
    }
}