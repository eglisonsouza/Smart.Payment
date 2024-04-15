namespace Smart.Payment.Infra.Services.Asaas.Models.Request
{
    public class CreditCardRequest
    {
        public string HolderName { get; set; }
        public string Number { get; set; }
        public string expiryMonth { get; set; }
        public string expiryYear { get; set; }
        public string Ccv { get; set; }
    }
}
