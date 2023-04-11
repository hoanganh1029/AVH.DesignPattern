using AVH.Factory.Enums;

namespace AVH.Factory.BankAccount
{
    public class BankAccountBase
    {
        protected BankAccountType _bankAccountType;
        protected decimal _loanLimit;

        public BankAccountBase()
        {

        }

        public virtual string GetBankAccountInformation()
        {
            return $"This bank account is {_bankAccountType.ToString()} with loan limit {_loanLimit}";
        }
    }
}
