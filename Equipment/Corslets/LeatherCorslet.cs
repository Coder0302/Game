namespace Equipment.Corslets
{
    public class LeatherCorslet : Corslet
    {
        public LeatherCorslet() : base(1, 25, 10, 10)
        {
            Defence = 15;
            Durability = 0;
            Weight = 1;
        }
        public override string ToString()
        {
            return "Кожанные латы";
        }
    }
}