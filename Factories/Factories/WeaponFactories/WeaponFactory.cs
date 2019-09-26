using Equipment.Interfaces;
using Factories.Extensions;
using System;
using System.Collections.Generic;
using Factories.Factories;
namespace Factories.Factories.WeaponFactories
{
    internal abstract class WeaponFactory : EquipmentFactory
    {

        public Weapon Create(string type)
        {
            ValidateTypeName(type);
            return types[type].CreateObjectWithoutParametersByType<Weapon>();
        }
    }
}