using AVH.Factory.Enums;

namespace AVH.Factory.Cards
{
    public abstract class CreditCardBase
    {
        public decimal AnnualCharge { get; set; }
        public CardType CardType { get; protected set; }
        public decimal CreditLimit { get; set; }
        public string GetCardInformation()
        {
            return $"Your card is {CardType} and annual charge {AnnualCharge} and credit limit {CreditLimit}";
        }
    }
}
