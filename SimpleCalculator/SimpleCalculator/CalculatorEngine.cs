using System;
using System.Security.Cryptography.X509Certificates;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumer, double argSecondNumber)
        {
            double result;

            switch(argOperation.ToLower())
            {
                case "add":
                case "+":
                    result = argFirstNumer + argSecondNumber;
                    break;
                case "subtract":
                case "-":
                        result = argFirstNumer - argSecondNumber;
                        break;
                case "multiply":
                case "x":
                case "*":
                        result = argFirstNumer * argSecondNumber;
                        break;
                case "division":
                case "/":
                case "divide":
                        result = argFirstNumer / argSecondNumber;
                        break;
                default: 
                    throw new InvalidOperationException("Specified op not recognized");
            }

            return result;            
        }
    }
}