using Smart.Payment.Core.Models.Enum;

namespace Smart.Payment.Core.Models.Entities
{
    public class TransactionsEntity
    {
        public string TransactionId { get; set; }
        public string Event { get; set; }
        public BillingType BillingType { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
        public string CardNumber { get; set; }
        public string CardBrand { get; set; }
        public string PixCode { get; set; }
        public string ErrorDescription { get; set; }
        public string Customer { get; set; }
        public decimal Value { get; set; }
        public decimal NetValue { get; set; }
        public DateTime DueDate { get; set; }
        public string InvoiceUrl { get; set; }
        public string InvoiceNumber { get; set; }
    }
}
