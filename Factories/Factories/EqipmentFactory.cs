using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Factories.Extensions;

namespace Factories.Factories
{
    internal class EquipmentFactory
    {
        public void ValidateTypeName(string typeName)
        {
            if (typeName.InNullOrEmpty())
                throw new ArgumentException("Введите название предмета");
            if (!types.ContainsKey(typeName))
                throw new ArgumentException("Не существует такого типа оружия");
        }
        protected  Dictionary<string, Type> types = new Dictionary<string, Type>();
        public void FillTypes(Type baseType)
        {
            string assemblyPath = baseType.Assembly.ManifestModule.ToString();
            var assembly = Assembly.Load(new AssemblyName(assemblyPath.Remove(assemblyPath.IndexOf("."))));
            var res = assembly?.GetTypes().Where(x => x.GetTypeInfo().BaseType == baseType);
            if (res != null)
                foreach (var el in res)
                    types?.Add(el.Name, el);
        }
    }
}