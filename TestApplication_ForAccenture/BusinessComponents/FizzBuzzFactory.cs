namespace TestApplication_ForAccenture.BusinessComponents
{
    public class FizzBuzzFactory : IFizzBuzzFactory
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
                return null;
        } 
    }
}
