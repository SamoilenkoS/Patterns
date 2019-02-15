namespace ChainOfResponsibility
{
    public class ApprovalResponse
    {
        public ResponseStatus ResponseStatus;
        public string ApproverInfo;
    }
    public enum ResponseStatus
    {
        BeyondApprovalLimit,
        Denied,
        Approved
    }
}