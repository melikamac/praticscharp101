namespace abstract_ornek
{
    public class Lancer : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Mitsubishi;
        }
        public override Renk StandartRengiNe()
        {
            return Renk.Siyah;
        }
    }
}