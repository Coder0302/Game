using Equipment.Interfaces;
namespace Equipment.Corslets
{
    public abstract class Corslet : Armor
    {
        protected Corslet(int weight, int durabiliryPerHit, int fixPosibility, int defence) : base(weight, durabiliryPerHit, fixPosibility, defence)
        {

        }
    }
}