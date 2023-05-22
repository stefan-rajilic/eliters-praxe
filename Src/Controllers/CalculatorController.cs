using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculator;

        public CalculatorController(ICalculatorService calculator)
        {
            _calculator = calculator;
        }


        [HttpGet]
        [Route("Addition")]
        public IActionResult Addition(int a, int b)
        {
            return Ok(_calculator.Addition(a, b));
        }

        [HttpGet]
        [Route("Subtraction")]
        public IActionResult Subtraction(int a, int b)
        {
            return Ok(_calculator.Subtraction(a, b));
        }

        [HttpGet]
        [Route("Multiplication")]
        public IActionResult Multiplication(int a, int b)
        {
            return Ok(_calculator.Multiplication(a, b));
        }

        [HttpGet]
        [Route("Division")]
        public IActionResult Division(int a, int b)
        {
            return Ok(_calculator.Division(a, b));
        }
    }
}