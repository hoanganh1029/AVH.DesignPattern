using AVH.Factory.BankAccount;
using AVH.Factory.Cards;
using AVH.Factory.Enums;

namespace AVH.Factory.Factories.AbstractFactory
{
    public interface IBankAccountCardAbstractFactory
    {
        IBankAccount CreateBankAccount(BankAccountType bankAccountType);
        ICreditCard CreateCard(CreditCardType creditCardType);
    }
}
