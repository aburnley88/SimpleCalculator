using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumer = inputConverter.ConvertInputToNumberic(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumberic(Console.ReadLine());

                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumer, secondNumber);
                Console.WriteLine(result);

            }
            catch (Exception ex)
            {
                //in production I'd want to log any message
                Console.WriteLine(ex.Message);
            }

        }
    }
}
