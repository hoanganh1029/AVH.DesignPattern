using AVH.Factory.Cards;

namespace AVH.Factory.BankAccount
{
    public interface IBankAccount
    {
        CreditCardBase GetCreditCard();
        string GetBankAccountInformation();
    }
}
