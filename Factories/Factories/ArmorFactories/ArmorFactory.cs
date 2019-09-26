using Equipment.Interfaces;
using Factories.Extensions;
using System;
using System.Collections.Generic;

namespace Factories.Factories.ArmorFactories
{
    internal abstract class ArmorFactory : EquipmentFactory
    {
        public Armor Create(string type)
        {
            if (type.InNullOrEmpty())
                throw new ArgumentException("Введите название предмета");
            if (!types.ContainsKey(type))
                throw new ArgumentException("Не существует такого типа брони");
            return types[type].CreateObjectWithoutParametersByType<Armor>();
        }
    }
}