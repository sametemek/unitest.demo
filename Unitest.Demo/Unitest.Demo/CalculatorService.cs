using System;
using System.Collections.Generic;
using System.Text;

namespace Unitest.Demo
{
    public class CalculatorService
    {
        public int Plus(int digit1, int digit2)
        {
            if (digit1 < 0 || digit2 < 0)
            {
                throw new DigitMustBePositive();
            }

            return digit1 + digit2;
        }

        public int Substract(int digit1, int digit2)
        {
            return digit1 - digit2;
        }
    }
}
