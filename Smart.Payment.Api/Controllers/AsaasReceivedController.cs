using Microsoft.AspNetCore.Mvc;
using Smart.Payment.Application.Models;
using Smart.Payment.Application.Services;

namespace Smart.Payment.Api.Controllers
{
    [ApiController]
    [Route("api/v1/asaas-received")]
    public class AsaasReceivedController(IPaymentReceivedService service) : ControllerBase
    {
        private readonly IPaymentReceivedService _service = service;

        [HttpPost]
        public IActionResult Post([FromBody] PaymentReceivedAsaasModel paymentReceived)
        {
            _service.AddEvent(paymentReceived);

            return Ok();
        }
    }
}
