using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApplication_ForAccenture.BusinessComponents;

namespace TestApplication_ForAccenture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IFizzBuzzFactory _fizzBuzzFactory;
        public TestController(IFizzBuzzFactory fizzBuzzFactory)
        {
            _fizzBuzzFactory = fizzBuzzFactory;
        }

        [HttpGet]
        public string CheckFizzBuzz(string Number)
        {

            //var fizzRule = FizzBuzzFactory.CheckLogic("Fizz");
            //var buzzRule = FizzBuzzFactory.CheckLogic("Buzz");
            //var fizzbuzzRule = FizzBuzzFactory.CheckLogic("FizzBuzz");
            //var processor = new FizzBuzzProcessor(new List<ITest> { fizzbuzzRule,fizzRule, buzzRule });
            //return processor.DoProcess(Number);
            if (int.TryParse(Number, out _))
            {
                int Value = int.Parse(Number);
                ITest obj = _fizzBuzzFactory.CheckLogic(Value);
                if (obj != null)
                    return obj.CheckFizzBuzz(Value);
                else
                    return "Divided " + Number.ToString() + " by 3 \n" + "Divided " + Number.ToString() + " by 5";
            }
            else
                return "Invalid Item";
        }
    }
}
