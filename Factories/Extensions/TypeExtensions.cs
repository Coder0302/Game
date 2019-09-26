using System;
using System.Linq;
using Equipment.Interfaces;

namespace Factories.Extensions
{
    public static class TypeExtensions
    {
        public static object CreateObjectWithoutParameters(this Type type)
        {
            var constructor = type?.GetConstructors().FirstOrDefault(x => !x.GetParameters().Any());
            object result = constructor?.Invoke(new object[0]);
            return result;
        }

        public static T CreateObjectWithoutParametersByType<T>(this Type type) where T : Equip
        {
            var obj = type.CreateObjectWithoutParameters();
            if (obj is T equip)
                return equip;
            throw new ArgumentException("Incorrect type");
        }
    }
}