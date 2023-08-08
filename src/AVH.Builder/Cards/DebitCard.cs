namespace AVH.Builder.Cards
{
    public class DebitCard
    {
        public Guid Id { get; set; }
        public string? CardNumber { get; set; }
        public string? Name { get; set; }
        public DateTime ExpiredDate { get; set; }
        public decimal DebitLimitation { get; set; }
        public decimal AnnualCharge { get; set; }
        public bool EnableContactLess { get; set; }

        public DebitCard()
        {
            Id = Guid.NewGuid();
        }

        public string DisplayInformation()
        {
            return $"Id: {Id}, CardNumber: {CardNumber}, Name: {Name}, " +
                $"Debit limitation: {DebitLimitation}, Annual charge: {AnnualCharge}, " +
                $"Enable contactless: {EnableContactLess}";
        }
    }
}
