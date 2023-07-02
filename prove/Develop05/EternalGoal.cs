public class EternalGoal : Goal {
    public override string DisplayGoal()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }
    public override string WritingInFileString()
    {
        return $"{GetName()},{GetDescription()},{GetPoints()}";
    }
}