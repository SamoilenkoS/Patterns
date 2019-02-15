using System;

namespace ChainOfResponsibility
{
    public class ExpenseHandler : IExpenseHandler
    {
        private readonly IExpenseApprover _approver;
        private IExpenseHandler _next;

        public ExpenseHandler(IExpenseApprover expenseApprover)
        {
            _approver = expenseApprover;
            _next = EndOfChainExpenseHandler.Instance;
        }

        public ApprovalResponse Approve(IExpenseReport expenseReport)
        {
            ApprovalResponse response = _approver.ApproveExpense(expenseReport);

            if(response.ResponseStatus == ResponseStatus.BeyondApprovalLimit)
            {
                return _next.Approve(expenseReport);
            }
            else if(response.ResponseStatus == ResponseStatus.Approved)
            {
                response.ApproverInfo = _approver.GetApproverInfo();
            }

            return response;
        }

        public void RegisterNext(IExpenseHandler next)
        {
            _next = next;
        }
    }
}