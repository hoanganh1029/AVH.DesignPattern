using AVH.Factory.BankAccount;
using AVH.Factory.Enums;

namespace AVH.Factory.Factories.FactoryMethod
{
    public interface IBankAccountFactory
    {
        IBankAccount Create(BankAccountType bankAccountType);
    }
}
