namespace Smart.Payment.Infra.Services.Asaas.Models.Result
{
    public class AsaasListResult<T>
    {
        public string Object { get; set; }
        public int TotalCount { get; set; }
        public List<T> Data { get; set; }
    }
}
