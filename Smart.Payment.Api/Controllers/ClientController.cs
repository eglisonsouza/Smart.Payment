using Microsoft.AspNetCore.Mvc;
using Smart.Payment.Infra.Services.Asaas.HttpRequest;
using Smart.Payment.Infra.Services.Asaas.Models.Request;

namespace Smart.Payment.Api.Controllers
{
    [ApiController]
    [Route("api/v1/client")]
    public class ClientController(IClientService service) : ControllerBase
    {
        private readonly IClientService _service = service;

        [HttpPost]
        public async Task<IActionResult> PostAsync(ClientAsaasRequest request)
        {
            return Ok(await _service.AddAsync(request));
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(string cpfCnpj)
        {
            return Ok(await _service.GetAsync(cpfCnpj));
        }
    }
}
