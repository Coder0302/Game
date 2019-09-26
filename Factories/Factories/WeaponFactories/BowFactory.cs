using Equipment.Bows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Equipment.Swords;
namespace Factories.Factories.WeaponFactories
{
    internal sealed class BowFactory : WeaponFactory
    {
        private BowFactory()
        {
            FillTypes(typeof(Bow));
        }
        private static BowFactory _bowFactory;
        public static BowFactory Create()
        {
            return _bowFactory ?? new BowFactory();
        }
    }
}