namespace Sales.PaymentMethods.Abstraction
{
    public class Payment
    {
        public int CustomerId { get; set; }

        public double AmountCharged { get; set; }

        public Guid ReferenceNumber { get; set; }
    }
}