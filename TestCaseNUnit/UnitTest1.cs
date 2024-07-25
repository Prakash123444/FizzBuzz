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
            var expectedResult = "Fizz";
            var res = new TestFizz()
            {

            };
            mockRepo.Setup(repo => repo.CheckLogic(It.IsAny<int>())).Returns(res);
            var result = testController.CheckFizzBuzz("3");
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void Test_FizzBuzz()
        {
            var expectedResult = "FizzBuzz";
            var res = new TestFizzBuzz();
            mockRepo.Setup(repo => repo.CheckLogic(It.IsAny<int>())).Returns(res);
            var result = testController.CheckFizzBuzz("15");
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void Test_Buzz()
        {
            var expectedResult = "Buzz";
            var res = new TestBuzz(); 
            mockRepo.Setup(repo => repo.CheckLogic(It.IsAny<int>())).Returns(res);
            var result= testController.CheckFizzBuzz("5");
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void Test_String_InvalidItem()
        {
            var expectedResult = "Invalid Item";
            var res = new TestBuzz();
            mockRepo.Setup(repo => repo.CheckLogic(It.IsAny<int>())).Returns(res);
            var result = testController.CheckFizzBuzz("A");
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void Test_EmptyString_InvalidItem()
        {
            var expectedResult = "Invalid Item";
            var res = new TestBuzz();
            mockRepo.Setup(repo => repo.CheckLogic(It.IsAny<int>())).Returns(res);
            var result = testController.CheckFizzBuzz("");
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void Test_Null_InvalidItem()
        {
            var expectedResult = "Invalid Item";
            var res = new TestBuzz();
            mockRepo.Setup(repo => repo.CheckLogic(It.IsAny<int>())).Returns(res);
            var result = testController.CheckFizzBuzz(null);
            Assert.AreEqual(expectedResult, result);
        }
        [Test]
        public void Test_DividedByOtherScenerio()
        {
            string input = "23";
            var expectedResul = "Divided "+input+" by 3 \n"+ "Divided " + input + " by 5";

            ITest? res = null;
            mockRepo.Setup(repo => repo.CheckLogic(It.IsAny<int>())).Returns(res);
            var result = testController.CheckFizzBuzz(input);
            Assert.AreEqual(expectedResul, result);
        }
    }
}