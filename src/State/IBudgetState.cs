namespace State;

public interface IBudgetState
{
    public void InProgress();
    public void Approve();
    public void Reject();
    public void Finish();
}