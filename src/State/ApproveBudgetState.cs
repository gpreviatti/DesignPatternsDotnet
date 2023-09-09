namespace State;

public class ApproveBudgetState : IBudgetState
{
    private readonly Budget _budget;

    public ApproveBudgetState(Budget budget)
    {
        _budget = budget;
        _budget.CurrentStateBudget = CurrentState.Approve;
    }

    public void InProgress() => throw new Exception("Cannot change budget to in progress");
    public void Approve() => throw new Exception("The current budget is already approved");
    public void Reject() => _budget.BudgetBudgetState = new RejectBudgetState();
    public void Finish() => _budget.BudgetBudgetState = new FinishBudgetState(_budget);
}