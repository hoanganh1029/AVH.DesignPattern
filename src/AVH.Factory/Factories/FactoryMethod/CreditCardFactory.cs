using AVH.Factory.Cards;
using AVH.Factory.Enums;

namespace AVH.Factory.Factories.FactoryMethod
{
    internal class CreditCardFactory : ICreditCardFactory
    {
        private readonly Dictionary<CreditCardType, Func<ICreditCard>> dicCreditCard
            = new()
            {
                {CreditCardType.General, () =>  Generate<GeneralCard>() },
                {CreditCardType.Silver, () =>  Generate<SilverCard>() },
                {CreditCardType.Gold, () =>  Generate<GoldCard>()},
                {CreditCardType.Diamond, () =>  Generate<DiamondCard>() },
            };

        public ICreditCard Create(CreditCardType creditCardType)
        {
            if (!dicCreditCard.TryGetValue(creditCardType, out var func))
            {
                throw new NotImplementedException("Credit Card Type is not implemented");
            }

            return func.Invoke();
        }
        private static ICreditCard Generate<T>() where T : ICreditCard, new()
        {
            var instance = Activator.CreateInstance(typeof(T));
            if (instance == null)
            {
                throw new InvalidCastException($"Can not create instance of {nameof(T)}");
            }
            return (T)instance;
        }
    }
}
