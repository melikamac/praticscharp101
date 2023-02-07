using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 5;
            Console.WriteLine("Class alan hesabı : {0}", dikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_Struct;
            dikdortgen_Struct.KisaKenar = 5;
            dikdortgen_Struct.UzunKenar = 4;
            Console.WriteLine("Struct alan hesabı : {0}", dikdortgen_Struct.AlanHesapla());
        }
    }
    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        public Dikdortgen()
        {
            KisaKenar = 7;
            UzunKenar = 8;
        }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
        {
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}
