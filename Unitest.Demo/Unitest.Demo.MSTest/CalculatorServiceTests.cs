using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unitest.Demo.MSTest
{
    [TestClass]
    public class CalculatorServiceTests
    {
        private readonly CalculatorService _calculatorService;

        public CalculatorServiceTests()
        {
            _calculatorService = new CalculatorService();
        }

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            Debug.WriteLine("CalculatorServiceTests AssemblyInitialize runs.");
        }
        
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Debug.WriteLine("CalculatorServiceTests ClassInitialize runs.");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Debug.WriteLine("CalculatorServiceTests TestInitialize runs.");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Debug.WriteLine("CalculatorServiceTests TestCleanup runs.");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Debug.WriteLine("CalculatorServiceTests TestCleanup runs.");
        }
        
        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Debug.WriteLine("CalculatorServiceTests AssemblyCleanup runs.");
        }

        [TestMethod]
        public void PlusMethod_returns_sum_of_two_digits()
        {
            //Arrange
            var expected = 3;
            
            //Act
            var actual = _calculatorService.Plus(1, 2);

            //Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void PlusMethod_digits_must_be_positive()
        {
            Assert.ThrowsException<DigitMustBePositive>(() => _calculatorService.Plus(-1, 5));
        }


        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(5, 2, 7)]
        [DataRow(2, 4, 6)]
        public void PlusMethod_returns_sum_of_two_digits_multiple(int digit1, int digit2, int expected)
        {
            var actual = _calculatorService.Plus(digit1, digit2);
            Assert.AreEqual(actual, expected);
        }

        [DataTestMethod]
        [DataRow(3, 1, 2)]
        [DataRow(2, 6, -4)]
        [DataRow(4, 4, 0)]
        public void SubstractMethod_returns_digit1_minus_digit2(int digit1, int digit2, int expected)
        {
            var actual = _calculatorService.Substract(digit1, digit2);
            Assert.AreEqual(actual, expected);
        }
    }
}
