using Smart.Payment.Core.Models.Enum;

namespace Smart.Payment.Infra.Services.Asaas.Models.Request
{
    public class CreatePaymentAsaasRequest
    {
        public BillingType BillingType { get; set; }
        public decimal Value { get; set; }
        public string Customer { get; set; }
        public DateTime DueDate { get; set; }
    }
}
