using AVH.Factory.Enums;

namespace AVH.Factory.BankAccount
{
    internal class GeneralAccount : BankAccountBase
    {
        public GeneralAccount() : base()
        {
            _bankAccountType = BankAccountType.General;
            _loanLimit = 2000;
        }
    }
}
