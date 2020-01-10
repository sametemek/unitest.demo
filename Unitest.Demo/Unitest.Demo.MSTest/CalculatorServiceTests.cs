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

        [TestMethod]
        public void PlusMethod_returns_sum_of_two_digits()
        {
            var actual = _calculatorService.Plus(1, 2);
            var expected = 3;
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
        [TestMethod]
        public void PlusMethod_returns_sum_of_two_digits_multiple(int digit1, int digit2, int expected)
        {
            var actual = _calculatorService.Plus(digit1, digit2);
            Assert.AreEqual(actual, expected);
        }

        [DataTestMethod]
        [DataRow(3, 1, 2)]
        [DataRow(2, 6, -4)]
        [DataRow(4, 4, 0)]
        [TestMethod]
        public void SubstractMethod_returns_digit1_minus_digit2(int digit1, int digit2, int expected)
        {
            var actual = _calculatorService.Substract(digit1, digit2);
            Assert.AreEqual(actual, expected);
        }
    }
}
