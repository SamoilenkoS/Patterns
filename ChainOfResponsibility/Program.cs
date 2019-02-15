using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            ExpenseHandler william = new ExpenseHandler(new Employee("William Worker", Decimal.Zero));
            ExpenseHandler mary = new ExpenseHandler(new Employee("Mary Manager", new Decimal(1_000)));
            ExpenseHandler victor = new ExpenseHandler(new Employee("Victor Vicepresident", new Decimal(5_000)));
            ExpenseHandler paula = new ExpenseHandler(new Employee("Paula President", new Decimal(20_000)));

            william.RegisterNext(mary);
            mary.RegisterNext(victor);
            victor.RegisterNext(paula);

            Decimal expenseReportAmount;
            if(ConsoleInput.TryReadDecimal("Expense report amount:", out expenseReportAmount))
            {
                IExpenseReport expense = new ExpenseReport(expenseReportAmount);

                ApprovalResponse response = william.Approve(expense);

                Console.WriteLine("The request was {0} by {1}", response.ResponseStatus, response.ApproverInfo);
            }
            Console.ReadKey();
        }
    }
}
