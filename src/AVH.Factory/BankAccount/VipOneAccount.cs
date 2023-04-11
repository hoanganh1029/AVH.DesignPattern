using AVH.Factory.Cards;
using AVH.Factory.Enums;

namespace AVH.Factory.BankAccount
{
    internal class VipOneAccount : BankAccountBase, IBankAccount
    {
        public VipOneAccount() : base()
        {
            _bankAccountType = BankAccountType.VipOne;
            _loanLimit = 3000;
        }

        public CreditCardBase GetCreditCard()
        {
            return new SilverCard();
        }
    }
}
