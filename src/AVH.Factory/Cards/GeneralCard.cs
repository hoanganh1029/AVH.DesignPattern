
using AVH.Factory.Enums;

namespace AVH.Factory.Cards
{
    public class GeneralCard : CreditCardBase
    {
        public GeneralCard()
        {
            CardType = CardType.General;
            AnnualCharge = 30;
            CreditLimit = 1000;
        }
    }
}
