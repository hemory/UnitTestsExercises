namespace CalculatorApp
{
    public class Calculator
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public int Divide(int firstNumber, int secondNumber)
        {
            if (secondNumber != 0)
            {
                return firstNumber / secondNumber;
            }

            return 0;

        }
    }
}
