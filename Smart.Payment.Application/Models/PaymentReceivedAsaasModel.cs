using Smart.Payment.Core.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart.Payment.Application.Models
{
    public class PaymentReceivedAsaasModel
    {
        public string Id { get; set; }
        public string Event { get; set; }
        public DateTime DateCreated { get; set; }
        public string Customer { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Value { get; set; }
        public decimal NetValue { get; set; }
        public string Description { get; set; }
        public BillingType BillingType { get; set; }
        public string InvoiceUrl { get; set; }
        public string InvoiceNumber { get; set; }
        public CreditCardAsaasModel CreditCard { get; set; }
        public string PixTransaction { get; set; }
        public ChargebackModel Chargeback { get; set; }
    }
}
