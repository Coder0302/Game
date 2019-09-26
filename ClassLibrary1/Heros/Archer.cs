using Factories.Factories;
namespace Heroes.Heros
{
    public class Archer : Hero
    {
        public Archer()
        {
            Name = "Лучник №1";
            Hp = 80;
            AbstractFactory = ArcherFactory.Create();
            Weapon = AbstractFactory.CreateWeapon("PlasticBow");
            Armor = AbstractFactory.CreateArmor("WoodenChainMail");
        }
    }
}