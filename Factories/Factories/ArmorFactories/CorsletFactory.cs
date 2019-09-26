using Equipment.Corslets;
using System;
using System.Collections.Generic;

namespace Factories.Factories.ArmorFactories
{
    internal sealed class CorsletFactory : ArmorFactory
    {
        private CorsletFactory()
        {
            FillTypes(typeof(Corslet));
        }
        private static CorsletFactory _corsletFactory;
        public static CorsletFactory Create()
        {
            return _corsletFactory ?? new CorsletFactory();
        }
    }
}