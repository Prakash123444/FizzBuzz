namespace TestApplication_ForAccenture.BusinessComponents
{
    public class TestFizz : ITest
    {
        public string CheckFizzBuzz(int Number)
        {
            if (Number > 0)
                return Number % 3 == 0 ? "Fizz" : string.Empty;
            else
                return "Invalid item ";
        }
    }
    public class TestFizzBuzz : ITest
    {
        public string CheckFizzBuzz(int Number)
        {
            if (Number > 0)
                return (Number % 3 == 0 && Number % 5 == 0) ? "FizzBuzz": string.Empty;
            else
                return "Invalid item ";
        }
    }
    public class TestBuzz : ITest
    {
        public string CheckFizzBuzz(int Number)
        {
            if (Number > 0)
                return Number % 5 == 0 ? "Buzz" : string.Empty;
            else
                return "Invalid item ";
        }
    } 
}
