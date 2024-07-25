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

        [HttpGet("CheckFizzBuzz")]
        public List<string> CheckFizzBuzz([FromQuery] List<string> lstNumber)
        {
            try
            {
                List<string> response=new List<string>();
                foreach (var number in lstNumber)
                {
                    if (int.TryParse(number, out _))
                    {
                        int Value = int.Parse(number);
                        ITest testobj = _fizzBuzzFactory.CheckLogic(Value);
                        if (testobj != null)
                            response.Add( testobj.CheckFizzBuzz(Value));
                        else
                            response.Add("Divided " + number.ToString() + " by 3 \n" + "Divided " + number.ToString() + " by 5");
                    }
                    else
                        response.Add("Invalid Item");
                }
                return response;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
