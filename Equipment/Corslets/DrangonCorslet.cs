namespace Equipment.Corslets
{
    public class DrangonCorslet : Corslet
    {
        public DrangonCorslet() : base(3, 5, 50, 40)
        {
            Defence = 100;
            Durability = 0;
            Weight = 1;
        }
        public override string ToString()
        {
            return "Дрангон латы";
        }
    }
}