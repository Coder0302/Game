using Equipment.ChainMails;
using System;
using System.Collections.Generic;
namespace Factories.Factories.ArmorFactories
{
    internal sealed class ChainMailFactory : ArmorFactory
    {
        private ChainMailFactory()
        {
            FillTypes(typeof(ChainMail));
        }
        private static ChainMailFactory _chainMailFactory;
        public static ChainMailFactory Create()
        {
            return _chainMailFactory ?? new ChainMailFactory();
        }
    }
}