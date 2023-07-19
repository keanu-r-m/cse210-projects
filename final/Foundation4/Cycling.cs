public class Cycling : Activity {
    private float _speed;
    public Cycling(float speed, string name, string date, int time) : base(name, date, time)
    {
        _speed = speed;
    }
    public override float GetSpeed() {
        return _speed;
    }
    public override float GetPace() {
        return 60 / _speed;
    }
    public override string GetSummary() {
        return $"{_date} {_name} ({_time} min): Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}