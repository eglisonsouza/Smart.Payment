using Microsoft.AspNetCore.Mvc;
using Smart.Payment.Infra.Services.Asaas.HttpRequest;
using Smart.Payment.Infra.Services.Asaas.Models.Request;

namespace Smart.Payment.Application.Controllers
{
    [ApiController]
    [Route("api/v1/payment")]
    public class PaymentController(IPaymentService service) : ControllerBase
    {
        private readonly IPaymentService _service = service;

        [HttpPost]
        public async Task<IActionResult> Post(CreatePaymentAsaasRequest request)
        {
            return Ok(await _service.Create(request));
        }

        [HttpPost("credit-card/{idPayment}")]
        public async Task<IActionResult> Pay(string idPayment, PaymentAsaasRequest request)
        {
            return Ok(await _service.Pay(idPayment, request));
        }
    }
}
