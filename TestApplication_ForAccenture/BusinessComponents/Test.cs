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
    public interface IFizzBuzzFactory
    {
        ITest CheckLogic(int Number);
    }
    public class FizzBuzzFactory: IFizzBuzzFactory
    {
        public ITest CheckLogic(int Number)
        {
            if (Number % 3 == 0 && Number % 5 == 0)
                return new TestFizzBuzz();
            else if (Number % 3 == 0)
                return new TestFizz();
            else if (Number % 5 == 0)
                return new TestBuzz();
            else
                return  null; 
        }
    }
    public class FizzBuzzProcessor
    {
        private readonly List<ITest> _test;
        public FizzBuzzProcessor(List<ITest> test)
        {
            _test = test;
        }
        public string DoProcess(int Number)
        {
            var res=string.Empty;
            //foreach (var test in _test)
            //{
            //    if (test != null)
            //        res += test.CheckFizzBuzz(Number);
            //}
            //if (res == "")
            //    res = "Divided " + Number.ToString() + " by 3 \n" + "Divided " + Number.ToString() + " by 5";

            return res;
        }
    }

}
