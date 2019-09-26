using Factories.Factories;
namespace Heroes.Heros
{
    public class Warrior : Hero
    {
        public Warrior()
        {
            Name = "Воин №1";
            Hp = 100;
            AbstractFactory = WarriorFactory.Create();
            Weapon = AbstractFactory.CreateWeapon("DrangonSword");
            Armor = AbstractFactory.CreateArmor("LeatherCorslet");
        }
    }
}