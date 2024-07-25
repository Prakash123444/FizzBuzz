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
        public string CheckFizzBuzz(string? Number)
        {
            try
            {
                if (int.TryParse(Number, out _))
                {
                    int Value = int.Parse(Number);
                    ITest testobj = _fizzBuzzFactory.CheckLogic(Value);
                    if (testobj != null)
                        return testobj.CheckFizzBuzz(Value);
                    else
                        return "Divided " + Number.ToString() + " by 3 \n" + "Divided " + Number.ToString() + " by 5";
                }
                else
                    return "Invalid Item";
            }
            catch (Exception ex)
            {
                return "Invalid Item";
            }
        }
    }
}
