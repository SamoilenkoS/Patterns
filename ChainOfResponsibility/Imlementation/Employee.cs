using System;

namespace ChainOfResponsibility
{
    public class Employee : IExpenseApprover
    {
        public string Name;
        private readonly Decimal _approvalLimit;

        public Employee(string name, Decimal approvalLimit)
        {
            Name = name;
            _approvalLimit = approvalLimit;
        }

        public ApprovalResponse ApproveExpense(IExpenseReport expenseReport)
        {
            return expenseReport.Total > _approvalLimit
            ? new ApprovalResponse() { ResponseStatus = ResponseStatus.BeyondApprovalLimit }
            : new ApprovalResponse() { ResponseStatus = ResponseStatus.Approved };
        }

        public string GetApproverInfo()
        {
            return Name;
        }
    }
}