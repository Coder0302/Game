using Equipment.Interfaces;
namespace Equipment.Swords
{
    public abstract class Sword : Weapon
    {
        protected Sword(int weight, int durabiliryPerHit, int fixPosibility, int damage) : base(weight, durabiliryPerHit, fixPosibility, damage)
        {

        }
    }
}