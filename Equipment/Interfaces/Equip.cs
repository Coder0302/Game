using Equipment.EventArgs;
using Equipment.EventHandler;
namespace Equipment.Interfaces
{
    public abstract class Equip
    {
        public int Durability { get; protected set; }
        public int Weight { get; protected set; }
        protected int DurabiliryPerHit;
        protected int FixPosibility;
        public event UsedEventHandler Used;
        public event FixedEventHadler Fixed;
        protected Equip(int weight, int durabiliryPerHit, int fixPosibility)
        {
            Durability = 0;
            this.Weight = weight;
            this.DurabiliryPerHit = durabiliryPerHit;
            this.FixPosibility = fixPosibility;
        }
        public void Fix()
        {
            Durability = Durability - FixPosibility > 0 ? Durability - FixPosibility : 0;
            Fixed?.Invoke(this, new FixedEventArgs() { Fixed = Durability });
        }

        public void Using()
        {
            Durability = (Durability + DurabiliryPerHit <= 100 ? DurabiliryPerHit + Durability : 100);
            Used?.Invoke(this, new UsedEventArgs() { Used = Durability });
        }
    }
}