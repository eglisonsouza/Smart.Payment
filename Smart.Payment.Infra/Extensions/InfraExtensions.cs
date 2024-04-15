using Microsoft.Extensions.DependencyInjection;
using RestSharp;
using Smart.Payment.Infra.Services.Asaas.HttpRequest;

namespace Smart.Payment.Infra.Extensions
{
    public static class InfraExtensions
    {
        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            services.AddTransient<IRestClient, RestClient>();
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IPaymentService, PaymentService>();
            return services;
        }
    }
}
