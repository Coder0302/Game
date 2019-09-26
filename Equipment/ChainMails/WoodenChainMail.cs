namespace Equipment.ChainMails
{
    public class WoodenChainMail : ChainMail
    {
        public WoodenChainMail() : base(3, 30, 15, 15)
        {
            Defence = 10;
            Durability = 0;
            Weight = 1;
        }
        public override string ToString()
        {
            return "Деревянная кольчуга";
        }
    }
}