using Equipment.Interfaces;
namespace Factories.Factories
{
    public abstract class AbstractFactories
    {
        public abstract Weapon CreateWeapon(string type);
        public abstract Armor CreateArmor(string type);
    }
}