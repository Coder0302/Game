using Equipment.Swords;
using System;
using System.Collections.Generic;
namespace Factories.Factories.WeaponFactories
{
    internal sealed class SwordFactory : WeaponFactory
    {
        private SwordFactory()
        {
            FillTypes(typeof(Sword));
        }
        private static SwordFactory _swordFactory;
        public static SwordFactory Create()
        {
            
            return _swordFactory ?? new SwordFactory();
        }
    }
}