using System;
using FizzBuzzApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {

        [TestMethod]
        public void CheckforFizzInput_withMultipleThree_Success()
        {
            string ExpectedResult = "Fizz";
            string ActualResult = DoFizzBuzz.GetFizzBuzzValue(3);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [TestMethod]
        public void CheckforFizzInput_WithMultipleFive_Success()
        {
            string ExpectedResult = "Buzz";
            string ActualResult = DoFizzBuzz.GetFizzBuzzValue(5);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [TestMethod]
        public void CheckforFizzInput_withMultipleThreeandFive_Success()
        {
            string ExpectedResult = "FizzBuzz";
            string ActualResult = DoFizzBuzz.GetFizzBuzzValue(15);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }

        [TestMethod]
        public void CheckforFizzInput_WithNotMultple_Success()
        {
            string ExpectedResult = "1";
            string ActualResult = DoFizzBuzz.GetFizzBuzzValue(1);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}
