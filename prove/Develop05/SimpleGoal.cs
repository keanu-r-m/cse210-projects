public class SimpleGoal : Goal {
    private Boolean _isComplete = false;
    public void SetIsComplete(Boolean isComplete) {
        _isComplete = isComplete;
    }
    public Boolean GetIsComplete() {
        return _isComplete;
    }
    public override string DisplayGoal()
    {
        string checker = "[X]";
        if (_isComplete == false) checker = "[ ]";
        return $"{checker} {GetName()} ({GetDescription()})";
    }
    public override string WritingInFileString()
    {
        return $"{GetName()},{GetDescription()},{GetPoints()},{_isComplete}";
    }
}