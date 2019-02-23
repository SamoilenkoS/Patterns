using System;
using System.Collections.Generic;

namespace Command
{
    public class User
    {
        // Initializers
        private Calculator _calculator = new Calculator();
        private List<ICommand> _commands = new List<ICommand>();

        private int _current = 0;

        public void Redo(int levels)
        {
            Console.WriteLine($"\n---- Redo {levels} levels ");

            // Делаем возврат операций
            for (int i = 0; i < levels; i++)
            {
                if (_current < _commands.Count)
                {
                    _commands[_current++].Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine($"\n---- Undo {levels} levels ");

            // Делаем отмену операций
            for (int i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    _commands[--_current].Undo();
                }
            }
        }

        public void Compute(char @operator, int operand)
        {
            // Создаем команду операции и выполняем её
            ICommand command = new CalculatorCommand(
              _calculator, @operator, operand);
            command.Execute();

            if (_current < _commands.Count)
            {
                // если "внутри undo" мы запускаем новую операцию, 
                // надо обрубать список команд, следующих после текущей, 
                // иначе undo/redo будут некорректны
                _commands.RemoveRange(_current, _commands.Count - _current);
            }

            // Добавляем операцию к списку отмены
            _commands.Add(command);
            _current++;
        }
    }
}