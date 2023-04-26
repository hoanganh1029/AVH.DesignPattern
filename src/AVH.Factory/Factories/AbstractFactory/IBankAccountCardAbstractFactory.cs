using AVH.Factory.BankAccount;
using AVH.Factory.BankAccountCards;
using AVH.Factory.Cards;
using AVH.Factory.Enums;

namespace AVH.Factory.Factories.AbstractFactory
{
    public interface IBankAccountCardAbstractFactory
    {
        BankAccountCard Create(BankAccountType bankAccountType, CreditCardType creditCardType);

        IBankAccount CreateBankAccount(BankAccountType bankAccountType);

        ICreditCard CreateCard(CreditCardType creditCardType);
    }
}
