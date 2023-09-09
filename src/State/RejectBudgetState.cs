namespace State;

public class RejectBudgetState : IBudgetState
{
    public void InProgress() => throw new Exception("Cannot move rejected budget to in progress");
    public void Approve() => throw new Exception("Cannot approve rejected this budget");
    public void Reject() => throw new Exception("Current budget already rejected");
    public void Finish()  => throw new Exception("Cannot finish rejected budget");
}