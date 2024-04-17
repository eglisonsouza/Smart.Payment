using Smart.Payment.Core.Models.Entities;
using Smart.Payment.Core.Repositories;

namespace Smart.Payment.Infra.Persistence.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        public void AddEvent(TransactionsEntity payment)
        {
            throw new NotImplementedException();
        }
    }
}
