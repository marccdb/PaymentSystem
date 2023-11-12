using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public ActionResult CreateTransaction(IPaymentOption paymentOption)
        {
            _paymentService.MakePayment(paymentOption);
            return Created();
        }


    }
}
