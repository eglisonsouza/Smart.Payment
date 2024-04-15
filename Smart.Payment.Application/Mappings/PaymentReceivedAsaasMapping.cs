using AutoMapper;
using Smart.Payment.Application.Models;
using Smart.Payment.Core.Models.Entities;

namespace Smart.Payment.Application.Mappings
{
    public class PaymentReceivedAsaasMapping : Profile
    {
        protected PaymentReceivedAsaasMapping()
        {
            CreateMap<PaymentReceivedAsaasModel, TransactionsEntity>()
                .ForMember(dst => dst.TransactionId, map => map.MapFrom(src => src.Id))
                .ForMember(dst => dst.Event, map => map.MapFrom(src => src.Event))
                .ForMember(dst => dst.BillingType, map => map.MapFrom(src => src.BillingType))
                .ForMember(dst => dst.DateCreated, map => map.MapFrom(src => src.DateCreated))
                .ForMember(dst => dst.CardNumber, map => map.MapFrom(src => src.CreditCard.CreditCardNumber))
                .ForMember(dst => dst.CardBrand, map => map.MapFrom(src => src.CreditCard.CreditCardBrand))
                .ForMember(dst => dst.PixCode, map => map.MapFrom(src => src.PixTransaction))
                .ForMember(dst => dst.ErrorDescription, map => map.MapFrom(src => $"{src.Chargeback.Status} - {src.Chargeback.Reason}"))
                .ForMember(dst => dst.Customer, map => map.MapFrom(src => src.Customer))
                .ForMember(dst => dst.Value, map => map.MapFrom(src => src.Value))
                .ForMember(dst => dst.NetValue, map => map.MapFrom(src => src.NetValue))
                .ForMember(dst => dst.DueDate, map => map.MapFrom(src => src.DueDate))
                .ForMember(dst => dst.InvoiceUrl, map => map.MapFrom(src => src.InvoiceUrl))
                .ForMember(dst => dst.InvoiceNumber, map => map.MapFrom(src => src.InvoiceNumber))
                .ForMember(dst => dst.Description, map => map.MapFrom(src => src.Description))
                .ReverseMap();
        }
    }
}
