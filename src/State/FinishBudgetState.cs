namespace State;

public class FinishBudgetState : IBudgetState
{
    private readonly Budget _budget;

    public FinishBudgetState(Budget budget)
    {
        _budget = budget;
        _budget.CurrentStateBudget = CurrentState.Finish;
    }

    public void InProgress() => throw new Exception("Finished budget cannot be changed to in progress");
    public void Approve() => throw new Exception("Finished budget cannot be approved");
    public void Reject() => _budget.BudgetBudgetState = new RejectBudgetState();
    public void Finish()  => throw new Exception("Budget already finished");
}