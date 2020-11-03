using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConveterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();
       
        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.ConvertInputToNumberic(inputNumber);
            Assert.AreEqual(5, convertedNumber);
            
        }
         [TestMethod]
         [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string inputNumber = "*";
            double convertedNumber = _inputConverter.ConvertInputToNumberic(inputNumber);
           
            
        }
       
        
    }
}
