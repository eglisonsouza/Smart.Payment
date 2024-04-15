using Smart.Payment.Core.Models.Enum;

namespace Smart.Payment.Infra.Services.Asaas.Models.Result
{
    public class PaymentAsaasResult
    {
        public string Object { get; set; }
        public string Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Customer { get; set; }
        public decimal Value { get; set; }
        public decimal NetValue { get; set; }
        public BillingType BillingType { get; set; }
        public DateTime ConfirmedDate { get; set; }
        public CreditCardResult CreditCard { get; set; }
        public string PixTransaction { get; set; }
        public string Status { get; set; }
        public DateTime DueDate { get; set; }
        public string InvoiceUrl { get; set; }
        public string InvoiceNumber { get; set; }
    }

}
