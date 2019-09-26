namespace Equipment.Swords
{
    public class WoodenSword : Sword
    {
        public WoodenSword() : base(1, 15, 10, 8)
        {

        }
        public override string ToString()
        {
            return "Деревянный меч";
        }
    }
}