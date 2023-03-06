using Microsoft.AspNetCore.Mvc;

namespace PayRollSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PayRollController : ControllerBase
    {
        private readonly IPayRollCalculator _payRollCalculator;

        public PayRollController(IPayRollCalculator payRollCalculator)
        {
            _payRollCalculator = payRollCalculator;
        }

        [HttpPost]
        public async Task<ActionResult<decimal>> Calculate(Employee employee)
        {
            decimal result = _payRollCalculator.CalculatePayRoll(employee);

            return Ok(result);
        }
    }
}