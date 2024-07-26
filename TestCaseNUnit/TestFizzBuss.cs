using Moq;
using TestApplication_ForAccenture.BusinessComponents;
using TestApplication_ForAccenture.Controllers;

namespace TestCaseNUnit
{
    [TestFixture]
    public class Tests
    {
        private TestController testController;
        private Mock<IFizzBuzzFactory> mockRepo;

        [SetUp]
        public void Setup()
        {
            mockRepo = new Mock<IFizzBuzzFactory>();
            testController = new TestController(mockRepo.Object);
        }
        [Test]
        public void Test_Fizz()
        {
            var expectedResult = new List<string> { "Fizz" };
            var res = new TestFizz();
            var input = new List<string> { "3" };
            mockRepo.Setup(repo => repo.CheckLogic(It.IsAny<int>())).Returns(res);
            var result = testController.CheckFizzBuzz(input);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Test_FizzBuzz()
        {
            var expectedResult = new List<string> { "FizzBuzz" };
            var res = new TestFizzBuzz();
            var input = new List<string> { "15" };
            mockRepo.Setup(repo => repo.CheckLogic(It.IsAny<int>())).Returns(res);
            var result = new List<string>();
            result= testController.CheckFizzBuzz(input);
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void Test_Buzz()
        { 
            var expectedResult = new List<string> { "Invalid Item", "Buzz" };
            var res = new TestBuzz(); 
            var input = new List<string> { "A", "5" };
            mockRepo.Setup(repo => repo.CheckLogic(It.IsAny<int>())).Returns(res);
            var result = new List<string>();
            result = testController.CheckFizzBuzz(input);
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void Test_String_InvalidItem()
        { 
            var expectedResult = new List<string> { "Invalid Item", "Invalid Item" };
            var res = new TestBuzz(); 
            var input = new List<string> { "A", "" };
            mockRepo.Setup(repo => repo.CheckLogic(It.IsAny<int>())).Returns(res);
            var result = new List<string>();
            result = testController.CheckFizzBuzz(input);
            Assert.AreEqual(expectedResult, result);
             
        } 
        [Test]
        public void Test_DividedByOtherScenerio()
        { 
            var expectedResult = new List<string> { "Divided 1 by 3 \nDivided 1 by 5", "Divided 23 by 3 \nDivided 23 by 5" }; 
            var input = new List<string> { "1", "23" };
            ITest? res = null;
            mockRepo.Setup(repo => repo.CheckLogic(It.IsAny<int>())).Returns(res);
            var result = new List<string>();
            result = testController.CheckFizzBuzz(input);
            Assert.AreEqual(expectedResult, result);
        }
    }
}