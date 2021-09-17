//using System;
using NUnit.Framework;
using BankingLibrary;


namespace BankLibrary.Test
{
    [TestFixture]
    public class CalacInterestTest
    {
        [Test]
        public void Calculate_Accept_PNR_ReturnsSI()
        {
            int ExpectedResult = 1000;   //Arrange
            ICalcInterest calc = new CalcInterest();  //Act
            int ActualResult = calc.Calculate(10000, 10, 1);
            Assert.AreEqual(ExpectedResult, ActualResult);
                                                     
        }

        
    }
}