using AVH.Factory.Cards;
using AVH.Factory.Enums;

namespace AVH.Factory.BankAccount
{
    public class PlatinumAccount : BankAccountBase, IBankAccount
    {
        public PlatinumAccount() : base()
        {
            _bankAccountType = BankAccountType.Platinum;
            _loanLimit = 6000;
        }

        public CreditCardBase GetCreditCard()
        {
            return new DiamondCard();
        }
    }
}
