using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumberic(string argInput)
        {
            double convertedNumber;
            if(!double.TryParse(argInput, out convertedNumber)) throw new ArgumentException("numeric value expected");
            return convertedNumber;
           
        }
    }
}