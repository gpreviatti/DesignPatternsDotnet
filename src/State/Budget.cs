namespace State;

public enum CurrentState
{
    InProgress = 1,
    Approve,
    Reject,
    Finish
}

public class Budget
{
    public IBudgetState BudgetBudgetState { get; set; }
    public CurrentState CurrentStateBudget { get; set; } = CurrentState.InProgress;

    public Budget() => BudgetBudgetState = new InProgressBudgetState(this);

    public void Approve() => BudgetBudgetState.Approve();
    public void Reject() => BudgetBudgetState.Reject();
    public void Finish() => BudgetBudgetState.Finish();
}