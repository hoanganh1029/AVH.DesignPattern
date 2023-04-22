using AVH.Factory.Enums;

namespace AVH.Factory.BankAccount
{
    public class BankAccountBase: IBankAccount
    {
        protected BankAccountType _bankAccountType;
        protected decimal _loanLimit;

        public BankAccountBase()
        {

        }

        public virtual string GetBankAccountInformation()
        {
            return $"The bank account is {_bankAccountType}, the loan limitation is {_loanLimit}";
        }
    }
}
