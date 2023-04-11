using AVH.Factory.Enums;

namespace AVH.Factory.Cards
{
    public class GoldCard : CreditCardBase
    {
        public GoldCard()
        {
            AnnualCharge = 70;
            CardType = CardType.Gold;
            CreditLimit = 5000;
        }
    }
}
