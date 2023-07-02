public class ChecklistGoal : Goal {
    private int _bonus;
    private int _completionCount;
    private int _completed = 0;
    public void SetBonus(int bonus) {
        _bonus = bonus;
    }
    public int GetBonus() {
        return _bonus;
    }
    public void SetCompletionCount(int completionCount) {
        _completionCount = completionCount;
    }
    public int GetCompletionCount() {
        return _completionCount;
    }
    public void SetCompleted(int completed) {
        _completed = completed;
    }
    public int GetCompleted() {
        return _completed;
    }
    public override string DisplayGoal()
    {
        string checker = "[ ]";
        if (_completionCount == _completed) checker = "[X]";
        return $"{checker} {GetName()} ({GetDescription()}) -- Currently completed: {_completed}/{_completionCount}";
    }
    public override string WritingInFileString()
    {
        return $"{GetName()},{GetDescription()},{GetPoints()},{_bonus},{_completionCount},{_completed}";
    }
}