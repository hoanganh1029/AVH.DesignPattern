using AVH.Factory.Enums;
using AVH.Factory.Factories.AbstractFactory;
using System.Collections.Immutable;

namespace AVH.Factory.Constants
{
    public static class CommonConstant
    {
        public static readonly ImmutableDictionary<AccountCardType, Type> DictionaryAbstractFactoryType = new Dictionary<AccountCardType, Type> {
            { AccountCardType.Personal, typeof(PersonalBankAccountCardAbstractFactory) },
            { AccountCardType.Business, typeof(BusinessBankAccountCardAbstractFactory) }
        }.ToImmutableDictionary();
    }
}
