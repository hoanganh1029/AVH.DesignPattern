using AVH.Factory.BankAccount;
using AVH.Factory.Cards;

namespace AVH.Factory.BankAccountCards
{
    public class BankAccountCard
    {

        public BankAccountCard(IBankAccount bankAccount, ICreditCard creditCard)
        {
            BankAccount = bankAccount;
            CreditCard = creditCard;
        }

        public IBankAccount BankAccount { get; set; }

        public ICreditCard CreditCard { get; set; }
    }
}
