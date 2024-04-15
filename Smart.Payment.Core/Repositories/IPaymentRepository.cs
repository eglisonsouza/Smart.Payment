using Smart.Payment.Core.Models.Entities;

namespace Smart.Payment.Core.Repositories
{
    public interface IPaymentRepository
    {
        void AddEvent(TransactionsEntity payment);
    }
}
