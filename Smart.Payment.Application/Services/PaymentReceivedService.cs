using AutoMapper;
using Smart.Payment.Application.Models;
using Smart.Payment.Core.Models.Entities;
using Smart.Payment.Core.Models.Enum;
using Smart.Payment.Core.Repositories;

namespace Smart.Payment.Application.Services
{
    public interface IPaymentReceivedService
    {
        void AddEvent(PaymentReceivedAsaasModel paymentReceived);
    }

    public class PaymentReceivedService(IPaymentRepository repository, IMapper mapper) : IPaymentReceivedService
    {
        private readonly IPaymentRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public void AddEvent(PaymentReceivedAsaasModel paymentReceived)
        {
            _repository.AddEvent(_mapper.Map<TransactionsEntity>(paymentReceived));
        }
    }
}
