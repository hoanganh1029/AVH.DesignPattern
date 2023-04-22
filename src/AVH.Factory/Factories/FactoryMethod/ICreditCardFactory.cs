using AVH.Factory.Cards;
using AVH.Factory.Enums;

namespace AVH.Factory.Factories.FactoryMethod
{
    public interface ICreditCardFactory
    {
        public ICreditCard Create(CreditCardType creditCardType);
    }
}
