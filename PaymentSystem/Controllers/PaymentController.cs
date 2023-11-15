using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentSystem.Models;
using PaymentSystem.Models.Interfaces;
using PaymentSystem.Services;

namespace PaymentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController(PaymentService paymentService, ILogger<PaymentController> logger) : ControllerBase
    {
        private readonly ILogger<PaymentController> _logger = logger;
        private readonly PaymentService _paymentService = paymentService;

        [HttpPost]
        public async Task<ActionResult> CreateTransaction(PaymentTransaction newTransaction)
        {
            try
            {
                _logger.LogInformation(newTransaction.ToString());
                await _paymentService.CreateNewPayment(newTransaction);
                return Created();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


    }
}
