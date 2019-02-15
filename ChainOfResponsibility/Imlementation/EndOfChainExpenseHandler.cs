using System;

namespace ChainOfResponsibility
{
    public class EndOfChainExpenseHandler : IExpenseHandler
    {
        private EndOfChainExpenseHandler() { }

        public static EndOfChainExpenseHandler Instance
        {
            get
            {
                return _instance;
            }
        }
        public ApprovalResponse Approve(IExpenseReport expenseReport)
        {
            return new ApprovalResponse() { ResponseStatus = ResponseStatus.Denied };
        }

        public void RegisterNext(IExpenseHandler next)
        {
            throw new InvalidOperationException("End of chain handler must be the end of the chain!");
        }

        private static readonly EndOfChainExpenseHandler _instance = new EndOfChainExpenseHandler();
    }
}