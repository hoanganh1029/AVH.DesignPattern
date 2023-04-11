using AVH.Factory.Cards;
using AVH.Factory.Enums;

namespace AVH.Factory.BankAccount
{
    internal class GeneralAccount : BankAccountBase, IBankAccount
    {
        public GeneralAccount() : base()
        {
            _bankAccountType = BankAccountType.General;
            _loanLimit = 2000;
        }

        public CreditCardBase GetCreditCard()
        {
            return new GeneralCard();
        }
    }
}
