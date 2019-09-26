using Equipment.Interfaces;
using Factories.Factories.ArmorFactories;
using Factories.Factories.WeaponFactories;
namespace Factories.Factories
{
    public class ArcherFactory : AbstractFactories
    {
        private static ArcherFactory _archerFactory;
        private ArcherFactory()
        {

        }
        public static ArcherFactory Create()
        {
            if (_archerFactory == null)
                _archerFactory = new ArcherFactory();
            return _archerFactory;

        }
        BowFactory _bowFactory = BowFactory.Create();
        ChainMailFactory _chainMailFactory = ChainMailFactory.Create();
        public override Armor CreateArmor(string type)
        {
            return _chainMailFactory.Create(type);
        }
        public override Weapon CreateWeapon(string type)
        {
            return _bowFactory.Create(type);
        }
    }
}