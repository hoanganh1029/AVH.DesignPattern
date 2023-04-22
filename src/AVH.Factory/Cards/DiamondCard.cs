using AVH.Factory.Enums;

namespace AVH.Factory.Cards
{
    internal class DiamondCard : CreditCardBase
    {
        public DiamondCard()
        {
            CardType = CreditCardType.Diamond;
            AnnualCharge = 90;
            CreditLimit = 7000;
        }
    }
}
