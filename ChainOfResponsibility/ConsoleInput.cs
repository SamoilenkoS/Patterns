using System;

namespace ChainOfResponsibility
{
    public class ConsoleInput
    {
        public static bool TryReadDecimal(string description, out decimal expenseReportAmount)
        {
            Console.WriteLine(description);
            var input = Console.ReadLine();
            try
            {
                expenseReportAmount = Convert.ToDecimal(input);
                return true;
            }
            catch(Exception)
            {
                expenseReportAmount = 0;
                return false;
            }
            
        }
    }
}