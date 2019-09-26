namespace Equipment.Bows
{
    public class PlasticBow : Bow
    {
        public PlasticBow() : base(1, 20, 15, 5)
        {

        }
        public override string ToString()
        {
            return "Пластиковый лук";
        }
    }
}