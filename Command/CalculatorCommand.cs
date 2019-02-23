namespace Command
{
    public class CalculatorCommand : ICommand
    {
        private readonly char _operator;
        private readonly int _operand;
        private readonly Calculator _calculator;

        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            _calculator = calculator;
            _operand = operand;
            _operator = @operator;
        }

        public void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        public void Undo()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        private char Undo(char @operator)
        {
            char result;
            switch(@operator)
            {
                case '+':
                    result = '-';
                    break;
                case '-':
                    result = '+';
                    break;
                case '*':
                    result = '/';
                    break;
                case '/':
                    result = '*';
                    break;
                default:
                    result = ' ';
                    break;
            }
            return result;
        }
    }
}
