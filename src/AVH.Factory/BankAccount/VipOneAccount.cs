using AVH.Factory.Enums;

namespace AVH.Factory.BankAccount
{
    internal class VipOneAccount : BankAccountBase
    {
        public VipOneAccount() : base()
        {
            _bankAccountType = BankAccountType.VipOne;
            _loanLimit = 3000;
        }
    }
}
