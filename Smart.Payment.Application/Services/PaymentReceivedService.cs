using AutoMapper;
using Smart.Payment.Application.Models;
using Smart.Payment.Core.Models.Entities;
using Smart.Payment.Core.Repositories;

namespace Smart.Payment.Application.Services
{
    public interface IPaymentReceivedService
    {
        void AddEvent(PaymentReceivedAsaasModel paymentReceived);
    }

    public sealed class PaymentReceivedService(
        IPaymentRepository repository,
        IMapperBase mapper
        ) : IPaymentReceivedService
    {

        public void AddEvent(PaymentReceivedAsaasModel paymentReceived)
        {
            repository.AddEvent(mapper.Map<TransactionsEntity>(paymentReceived));
        }
    }
}
