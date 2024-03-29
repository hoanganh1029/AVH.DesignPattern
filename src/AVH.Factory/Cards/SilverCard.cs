﻿using AVH.Factory.Enums;

namespace AVH.Factory.Cards
{
    public class SilverCard : CreditCardBase
    {
        public SilverCard()
        {
            CardType = CreditCardType.Silver;
            AnnualCharge = 50;
            CreditLimit = 3000;
        }
    }
}
