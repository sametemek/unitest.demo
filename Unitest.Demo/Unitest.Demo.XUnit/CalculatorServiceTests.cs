using System;
using Xunit;

namespace Unitest.Demo.XUnit
{
    public class CalculatorServiceTests
    {
        private readonly CalculatorService _calculatorService;

        public CalculatorServiceTests()
        {
            _calculatorService = new CalculatorService();
        }
        [Fact]
        public void PlusMethod_returns_sum_of_two_digits()
        {
            var actual = _calculatorService.Plus(1, 2);
            var expected = 3;
            Assert.True(actual == expected, String.Format("Ýki deðerin toplamý eþit olmalý! beklenen : {0} gerçekleþen {1}", expected, actual));
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 4, 7)]
        public void PlusMethod_returns_sum_of_two_digits_with_dynamic_input(int digit1, int digit2, int expected)
        {
            var actual = _calculatorService.Plus(digit1, digit2);
            Assert.True(actual == expected, String.Format("Ýki deðerin toplamý eþit olmalý! beklenen : {0} gerçekleþen {1}", expected, actual));
        }

        [Fact]
        public void PlusMethod_digits_must_be_positive()
        {
            Assert.Throws<DigitMustBePositive>(() => _calculatorService.Plus(-1, 5));
        }
    }
}
