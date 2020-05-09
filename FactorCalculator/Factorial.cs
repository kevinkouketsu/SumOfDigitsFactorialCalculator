using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FactorCalculator
{
    /// <summary>
    /// Provides static functions to get some factorial information
    /// </summary>
    public class Factorial
    {
        /// <summary>
        /// Sum all digits of particular factorial
        /// </summary>
        /// <param name="factorial">A number that is smaller then 2000 but greater then zero.</param>
        /// <returns>A 32-bit signed integer which is sum of all digits</returns>
        public static int SumOfDigits(int factorial)
        {
            if (factorial < 0 || factorial >= 2001)
                throw new ArgumentOutOfRangeException();

            List<int> digits = new List<int> 
            { 
                1
            };

            for (int iCurrentFactorial = 1; iCurrentFactorial <= factorial; ++iCurrentFactorial)
            {
                int currentDigitSize = digits.Count;
                
                int rest = 0;
                for(int i = 0; i < currentDigitSize; ++i)
                {
                    int result = rest + digits[i] * iCurrentFactorial;

                    digits[i] = result % 10;
                    rest = result / 10;
                }

                while (rest != 0)
                {
                    digits.Add(rest % 10);
                    rest /= 10;
                }
            }

            return digits.Sum();
        }

    }
}
