namespace State;

public class InProgressBudgetState : IBudgetState
{
    private readonly Budget _budget;

    public InProgressBudgetState(Budget budget)
    {
        _budget = budget;
        _budget.CurrentStateBudget = CurrentState.InProgress;
    }
    public void InProgress()  => throw new Exception("The current budget already in progress");
    public void Approve() => _budget.BudgetBudgetState = new ApproveBudgetState(_budget);
    public void Reject() => throw new Exception("Cannot reject in progress budget");
    public void Finish() => throw new Exception("Cannot finish in progress budget");
}