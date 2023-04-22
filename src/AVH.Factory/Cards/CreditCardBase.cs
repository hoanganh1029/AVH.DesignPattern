using AVH.Factory.Enums;

namespace AVH.Factory.Cards
{
    public abstract class CreditCardBase : ICreditCard
    {
        public decimal AnnualCharge { get; set; }
        public CreditCardType CardType { get; protected set; }
        public decimal CreditLimit { get; set; }
        public string GetCardInformation()
        {
            return $"Your card is {CardType}, annual charge is {AnnualCharge}, credit limit is {CreditLimit}";
        }
    }
}
