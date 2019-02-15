namespace ChainOfResponsibility
{
    public interface IExpenseApprover
    {
        ApprovalResponse ApproveExpense(IExpenseReport expenseReport);

        string GetApproverInfo();
    }
}