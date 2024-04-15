using Smart.Essentials.HttpRequest.Implementations;
using Smart.Essentials.HttpRequest.Models;
using Smart.Payment.Core.Models.Config;
using Smart.Payment.Infra.Services.Asaas.Models.Request;
using Smart.Payment.Infra.Services.Asaas.Models.Result;

namespace Smart.Payment.Infra.Services.Asaas.HttpRequest
{
    public class PaymentService : IPaymentService
    {
        private const string HeaderAccessToken = "access_token";
        private const string UrlPayment = "/api/v3/payments";
        private readonly HttpPost _httpPost;

        public PaymentService(ApiSettings apiSettings)
        {
            var options = new RequestOptions
            {
                BaseUrl = apiSettings.AsaasSettings.Url,
                Headers = new Dictionary<string, string> { { HeaderAccessToken, apiSettings.AsaasSettings.Token } }
            };
            _httpPost = new HttpPost(options);
        }

        public Task<CreatePaymentAsaasResult> Create(CreatePaymentAsaasRequest request)
        {
            return _httpPost.PostAsync<CreatePaymentAsaasRequest, CreatePaymentAsaasResult>(UrlPayment, request);
        }

        public Task<PaymentAsaasResult> Pay(string idPayment, PaymentAsaasRequest payment)
        {
            return _httpPost.PostAsync<PaymentAsaasRequest, PaymentAsaasResult>($"{UrlPayment}/{idPayment}/payWithCreditCard", payment);
        }
    }

    public interface IPaymentService
    {
        Task<CreatePaymentAsaasResult> Create(CreatePaymentAsaasRequest request);
        Task<PaymentAsaasResult> Pay(string idPayment, PaymentAsaasRequest payment);
    }
}
