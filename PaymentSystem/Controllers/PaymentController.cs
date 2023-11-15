using Microsoft.AspNetCore.Mvc;
using PaymentSystem.Models;
using PaymentSystem.Services;
using PaymentSystem.Services.Interfaces;

namespace PaymentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController(ILogger<PaymentController> logger, IPaymentService paymentService) : ControllerBase
    {
        private readonly ILogger<PaymentController> _logger = logger;
        private readonly IPaymentService _paymentService = paymentService;

        [HttpPost]
        public async Task<ActionResult<PaymentTransaction>> CreateTransaction(PaymentTransaction newTransaction)
        {
            try
            {
                if(newTransaction == null) { return Problem("Please check your data."); }

                _logger.LogInformation(newTransaction.ToString());
                await _paymentService.CreateNewPayment(newTransaction);
                return Created("New payment registered", newTransaction);

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


    }
}
