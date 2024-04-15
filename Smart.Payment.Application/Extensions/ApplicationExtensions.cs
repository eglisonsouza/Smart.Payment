using Microsoft.Extensions.DependencyInjection;
using Smart.Payment.Application.Models;
using Smart.Payment.Application.Services;
using Smart.Payment.Core.Models.Entities;

namespace Smart.Payment.Application.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddServices();
            services.AddMapper();
            return services;
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPaymentReceivedService, PaymentReceivedService>();

        }

        public static void AddMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.CreateMap<PaymentReceivedAsaasModel, TransactionsEntity>();
            });
        }
    }
}
