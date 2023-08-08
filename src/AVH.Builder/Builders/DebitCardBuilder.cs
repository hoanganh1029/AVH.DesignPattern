using AVH.Builder.Cards;
using AVH.Builder.Enums;

namespace AVH.Builder.Builders
{
    public class DebitCardBuilder : IDebitCardBuilder
    {
        private DebitCard _debitCard = new();

        public IDebitCardBuilder From(DebitCard debitCard)
        {
            _debitCard = debitCard;
            return this;
        }

        public IDebitCardBuilder FromDefault()
        {
            _debitCard = new DebitCard();
            return this;
        }

        public IDebitCardBuilder WithCardNumber(string cardNumber)
        {
            _debitCard.CardNumber = cardNumber;
            return this;
        }

        public IDebitCardBuilder WithName(string name)
        {
            _debitCard.Name = name;
            return this;
        }

        public IDebitCardBuilder WithType(DebitCardType debitCardType)
        {
            switch (debitCardType)
            {
                case DebitCardType.Normal:
                    _debitCard.DebitLimitation = 1000;
                    _debitCard.AnnualCharge = 5;
                    break;
                case DebitCardType.Platinum:
                    _debitCard.DebitLimitation = 10000;
                    _debitCard.AnnualCharge = 7;
                    break;
                case DebitCardType.Diamond:
                    _debitCard.DebitLimitation = 15000;
                    _debitCard.AnnualCharge = 8;
                    break;
                default:
                    break;
            }
            return this;
        }

        public IDebitCardBuilder WithExpiredDate(DateTime expiredDate)
        {
            _debitCard.ExpiredDate = expiredDate;
            return this;
        }

        public IDebitCardBuilder WithCreditLimit(decimal creditLimit)
        {
            _debitCard.DebitLimitation = creditLimit;
            return this;
        }

        public IDebitCardBuilder WithEnableContactless(bool enableContactless)
        {
            //Do some complex logic
            _debitCard.EnableContactLess = enableContactless;
            return this;
        }

        public DebitCard Build()
        {
            return _debitCard;
        }
    }
}
