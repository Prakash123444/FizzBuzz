namespace TestApplication_ForAccenture.BusinessComponents
{
    public class TestFizz : ITest
    {
        public string CheckFizzBuzz(int Number)
        {
            return "Fizz";
        }
    }
    public class TestFizzBuzz : ITest
    {
        public string CheckFizzBuzz(int Number)
        {
            return "FizzBuzz"; 
        }
    }
    public class TestBuzz : ITest
    {
        public string CheckFizzBuzz(int Number)
        {
            return "Buzz";

        }
    } 
}
