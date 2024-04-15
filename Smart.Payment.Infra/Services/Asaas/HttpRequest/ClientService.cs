using Smart.Essentials.HttpRequest.Implementations;
using Smart.Essentials.HttpRequest.Models;
using Smart.Payment.Core.Models.Config;
using Smart.Payment.Infra.Services.Asaas.Models.Request;
using Smart.Payment.Infra.Services.Asaas.Models.Result;

namespace Smart.Payment.Infra.Services.Asaas.HttpRequest
{
    public class ClientService : IClientService
    {
        private const string HeaderAccessToken = "access_token";
        private const string UrlClient = "/api/v3/customers";
        private readonly HttpPost _httpPost;
        private readonly HttpGet _httpGet;

        public ClientService(ApiSettings apiSettings)
        {
            var options = new RequestOptions
            {
                BaseUrl = apiSettings.AsaasSettings.Url,
                Headers = new Dictionary<string, string> { { HeaderAccessToken, apiSettings.AsaasSettings.Token } }
            };
            _httpPost = new HttpPost(options);
            _httpGet = new HttpGet(options);
        }

        public Task<ClientAsaasResult> AddAsync(ClientAsaasRequest clientAsaas)
        {
            return _httpPost.PostAsync<ClientAsaasRequest, ClientAsaasResult>(UrlClient, clientAsaas);
        }

        public Task<AsaasListResult<ClientAsaasResult>> GetAsync(string cpfCnpj)
        {
            return _httpGet.GetAsync<AsaasListResult<ClientAsaasResult>>($"{UrlClient}?cpfCnpj={cpfCnpj}");
        }
    }

    public interface IClientService
    {
        Task<ClientAsaasResult> AddAsync(ClientAsaasRequest clientAsaas);
        Task<AsaasListResult<ClientAsaasResult>> GetAsync(string cpfCnpj);
    }
}
