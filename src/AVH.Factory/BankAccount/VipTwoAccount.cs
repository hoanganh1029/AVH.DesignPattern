using AVH.Factory.Enums;

namespace AVH.Factory.BankAccount
{
    internal class VipTwoAccount : BankAccountBase
    {
        public VipTwoAccount() : base()
        {
            _bankAccountType = BankAccountType.VipTwo;
            _loanLimit = 4000;
        }
    }
}
