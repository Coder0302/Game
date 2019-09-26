namespace Equipment.ChainMails
{
    public class DrangonChainMail : ChainMail
    {
        public DrangonChainMail() : base(2, 6, 60, 30)
        {
            Defence = 100;
            Durability = 0;
            Weight = 1;
        }
        public override string ToString()
        {
            return "Дрангон кольчуга";
        }
    }
}