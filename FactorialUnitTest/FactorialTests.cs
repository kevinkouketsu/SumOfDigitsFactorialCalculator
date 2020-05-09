using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactorCalculator;

namespace FactorialUnitTest
{
    [TestClass]
    public class FactorialTests
    {
        [DataTestMethod]
        [DataRow(-5)]
        [DataRow(2001)]
        public void Factorial_Range_IsInvalid(int factorial)
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Factorial.SumOfDigits(factorial));
        }

        [DataTestMethod]
        [DataRow(0, 1)]
        [DataRow(2000, 23382)]
        [DataRow(1000, 10539)]
        [DataRow(6, 9)]
        public void Factorial_Range_IsValid(int factorial, int result)
        {
            Assert.AreEqual(result, Factorial.SumOfDigits(factorial));
        }
    }
}
