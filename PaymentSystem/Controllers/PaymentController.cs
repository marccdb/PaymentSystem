using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentSystem.Models;
using PaymentSystem.Models.Interfaces;
using PaymentSystem.Services;

namespace PaymentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController(PaymentService paymentService) : ControllerBase
    {

        private readonly PaymentService _paymentService = paymentService;

        [HttpPost]
        public async Task<ActionResult> CreateTransaction(PaymentTransaction newTransaction)
        {
            await _paymentService.CreateNewPayment(newTransaction);
            return Created();
        }


    }
}
