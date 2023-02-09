using System;

namespace inheritance
{
    public class Canlilar //sealed anahtar kelimesi verilirse kalıtım engellenir.
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir.");
        }
        protected void Solunum()
        {
            Console.WriteLine("Canlılar solunum yapar.");
        }
        protected void Bosaltim()
        {
            Console.WriteLine("Canlılar boşaltım yapar.");
        }
        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }
    }
}