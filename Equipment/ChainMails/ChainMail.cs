using Equipment.Interfaces;
namespace Equipment.ChainMails
{
    public abstract class ChainMail : Armor
    {
        protected ChainMail(int weight, int durabiliryPerHit, int fixPosibility, int defence) : base(weight, durabiliryPerHit, fixPosibility, defence)
        {

        }
    }
}