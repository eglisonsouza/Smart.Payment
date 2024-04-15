namespace Smart.Payment.Infra.Services.Asaas.Models.Result
{
    public class CreatePaymentAsaasResult
    {
        public string Object { get; set; }
        public string Id { get; set; }
        public string Customer { get; set; }
        public decimal Value { get; set; }
        public decimal NetValue { get; set; }
        public string Status { get; set; }
        public DateTime DueDate { get; set; }
        public string InvoiceUrl { get; set; }
        public string InvoiceNumber { get; set; }
    }
}
