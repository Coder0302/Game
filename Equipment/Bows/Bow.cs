using Equipment.Interfaces;
namespace Equipment.Bows
{
    public abstract class Bow : Weapon
    {
        protected Bow(int weight, int durabiliryPerHit, int fixPosibility, int damage) : base(weight, durabiliryPerHit, fixPosibility, damage)
        {

        }
    }
}