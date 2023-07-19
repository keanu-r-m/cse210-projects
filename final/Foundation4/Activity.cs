public abstract class Activity {
    protected string _name;
    protected string _date;
    protected int _time;
    public Activity(string name, string date, int time) {
        _name = name;
        _date = date;
        _time = time;
    }
    public virtual float GetDistance() {
        return 0;
    }
    public virtual float GetSpeed() {
        return 0;
    }
    public virtual float GetPace() {
        return 0;
    }
    public abstract string GetSummary();
}