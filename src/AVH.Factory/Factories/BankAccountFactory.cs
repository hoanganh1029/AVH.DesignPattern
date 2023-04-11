using AVH.Factory.BankAccount;
using AVH.Factory.Enums;

namespace AVH.Factory.Factories
{
    internal class BankAccountFactory
    {
        private readonly Dictionary<BankAccountType, Func<IBankAccount>> dicBankAccount
            = new()
            {
                {BankAccountType.General, () =>  Generate<GeneralAccount>() },
                {BankAccountType.VipOne, () =>  Generate<VipOneAccount>() },
                {BankAccountType.VipTwo, () =>  Generate<VipTwoAccount>()},
                {BankAccountType.Platinum, () =>  Generate<PlatinumAccount>() },
            };

        public IBankAccount Create(BankAccountType bankAccountType)
        {
            if (!dicBankAccount.TryGetValue(bankAccountType, out var func)){
                throw new NotImplementedException("Bank Account Type is not implemented");
            }

            return func.Invoke();
        }
        private static IBankAccount Generate<T>() where T : IBankAccount, new()
        {
            var instance = Activator.CreateInstance(typeof(T));
            if (instance == null)
            {
                throw new InvalidCastException($"Can not create instance of {nameof(T)}");
            }
            return (T)instance;
        }
    }
}
