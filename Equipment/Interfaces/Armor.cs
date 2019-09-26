namespace Equipment.Interfaces
{
    public abstract class Armor : Equip
    {
        protected Armor(int weight, int durabiliryPerHit, int fixPosibility, int defence) : base(weight, durabiliryPerHit, fixPosibility)
        {
            this.Defence = defence;
        }
        public int Defence { get; protected set; }
    }
}