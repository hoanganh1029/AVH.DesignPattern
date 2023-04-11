using AVH.Factory.Cards;
using AVH.Factory.Enums;

namespace AVH.Factory.BankAccount
{
    internal class VipTwoAccount : BankAccountBase, IBankAccount
    {
        public VipTwoAccount() : base()
        {
            _bankAccountType = BankAccountType.VipTwo;
            _loanLimit = 4000;
        }

        public CreditCardBase GetCreditCard()
        {
            return new GoldCard();
        }
    }
}
