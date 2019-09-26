using Equipment.Interfaces;
using Factories.Factories.ArmorFactories;
using Factories.Factories.WeaponFactories;
namespace Factories.Factories
{
    public class WarriorFactory : AbstractFactories
    {
        private static WarriorFactory _warriorFactory;
        private WarriorFactory()
        {

        }
        public static WarriorFactory Create()
        {
            if (_warriorFactory == null)
                _warriorFactory = new WarriorFactory();
            return _warriorFactory;

        }
        SwordFactory _swordFactory = SwordFactory.Create();
        CorsletFactory _corsletFactory = CorsletFactory.Create();
        public override Armor CreateArmor(string type)
        {
            return _corsletFactory.Create(type);
        }
        public override Weapon CreateWeapon(string type)
        {
            return _swordFactory.Create(type);
        }
    }
}