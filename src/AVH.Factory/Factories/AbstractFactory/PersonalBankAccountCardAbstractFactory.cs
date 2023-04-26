using AVH.Factory.BankAccount;
using AVH.Factory.BankAccountCards;
using AVH.Factory.Cards;
using AVH.Factory.Enums;
using AVH.Factory.Factories.FactoryMethod;

namespace AVH.Factory.Factories.AbstractFactory
{
    public class PersonalBankAccountCardAbstractFactory : IBankAccountCardAbstractFactory
    {
        private readonly IBankAccountFactory _bankAccountFactory;
        private readonly ICreditCardFactory _creditCardFactory;

        public PersonalBankAccountCardAbstractFactory(
            IBankAccountFactory bankAccountFactory,
            ICreditCardFactory creditCardFactory)
        {
            _bankAccountFactory = bankAccountFactory;
            _creditCardFactory = creditCardFactory;
        }

        public BankAccountCard Create(BankAccountType bankAccountType, CreditCardType creditCardType)
        {
            return new BankAccountCard(CreateBankAccount(bankAccountType), CreateCard(creditCardType));
        }

        public IBankAccount CreateBankAccount(BankAccountType bankAccountType)
        {
            Console.WriteLine($"Create Personal bank account {bankAccountType}");
            return _bankAccountFactory.Create(bankAccountType);
        }

        public ICreditCard CreateCard(CreditCardType creditCardType)
        {
            Console.WriteLine($"Create Personal credit card {creditCardType}");
            return _creditCardFactory.Create(creditCardType);
        }
    }
}
