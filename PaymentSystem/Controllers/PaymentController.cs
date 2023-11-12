using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PaymentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {

        private readonly PaymentService _paymentService;

        [HttpGet]
        public ActionResult GetPaymentOptions()
        {
            var result = _paymentService.GetPaymentOptions();
            return Ok(result);
        }


    }
}
