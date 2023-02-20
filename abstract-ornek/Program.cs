using System;

namespace abstract_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Gtr gtr = new Gtr();
            Console.WriteLine(gtr.HangiMarkaninAraci().ToString());
            Console.WriteLine(gtr.StandartRengiNe().ToString());
            Console.WriteLine(gtr.KacTekerlektenOlusur().ToString());

            Impreza Impreza = new Impreza();
            Console.WriteLine(Impreza.HangiMarkaninAraci().ToString());
            Console.WriteLine(Impreza.StandartRengiNe().ToString());
            Console.WriteLine(Impreza.KacTekerlektenOlusur().ToString());
        }
    }
}
