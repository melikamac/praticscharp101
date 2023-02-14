using System;

namespace interface_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Lancer lancer = new Lancer();
            Console.WriteLine(lancer.HangiMarkaninAraci().ToString());
            Console.WriteLine(lancer.KacTekerlektenOlusur());
            Console.WriteLine(lancer.StandartRengiNe().ToString());
        }
    }
}
