namespace Equipment.Interfaces
{
    public abstract class Weapon : Equip
    {
        protected Weapon(int weight, int durabiliryPerHit, int fixPosibility, int damage) : base(weight, durabiliryPerHit, fixPosibility)
        {
            this.Damage = damage;
        }
        public int Damage { get; protected set; }
        public int Durability { get; protected set; }
        public int Weight { get; protected set; }
    }
}