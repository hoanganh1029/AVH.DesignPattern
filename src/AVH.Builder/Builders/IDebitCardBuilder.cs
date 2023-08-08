using AVH.Builder.Cards;
using AVH.Builder.Enums;

namespace AVH.Builder.Builders
{
    public interface IDebitCardBuilder
    {
        IDebitCardBuilder FromDefault();

        IDebitCardBuilder From(DebitCard debitCard);

        IDebitCardBuilder WithCardNumber(string cardNumber);

        IDebitCardBuilder WithName(string name);

        IDebitCardBuilder WithExpiredDate(DateTime expiredDate);

        IDebitCardBuilder WithCreditLimit(decimal creditLimit);

        IDebitCardBuilder WithType(DebitCardType debitCardType);

        IDebitCardBuilder WithEnableContactless(bool enableContactless);

        DebitCard Build();
    }
}
