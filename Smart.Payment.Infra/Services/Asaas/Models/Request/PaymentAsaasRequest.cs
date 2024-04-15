namespace Smart.Payment.Infra.Services.Asaas.Models.Request
{
    public class PaymentAsaasRequest
    {
        public CreditCardRequest CreditCard { get; set; }
        public CreditCardHolderInfoRequest CreditCardHolderInfo { get; set; }
    }
}
