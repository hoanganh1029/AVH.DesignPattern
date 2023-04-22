using AVH.Factory.Enums;

namespace AVH.Factory.BankAccount
{
    public class PlatinumAccount : BankAccountBase
    {
        public PlatinumAccount() : base()
        {
            _bankAccountType = BankAccountType.Platinum;
            _loanLimit = 6000;
        }
    }
}
