using System;

namespace Command
{
    public class Calculator
    {
        private int _currentValue = 0;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+':
                    _currentValue += operand;
                    break;
                case '-':
                    _currentValue -= operand;
                    break;
                case '*':
                    _currentValue *= operand;
                    break;
                case '/':
                    if(operand!=0)
                    {
                        _currentValue /= operand;
                    }
                    else
                    {
                        throw new ArgumentNullException("operand", "Cannot divide by zero!");
                    }

                    break;
            }
            Console.WriteLine(
              $"Current value = {_currentValue,3} (following {@operator} {operand})");
        }
    }
}