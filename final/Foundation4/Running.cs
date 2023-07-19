public class Running : Activity {
    private float _distance;
    public Running(float distance, string name, string date, int time) : base(name, date, time)
    {
        _distance = distance;
    }
    public override float GetDistance() {
        return _distance;
    }
    public override float GetSpeed() {
        return (_distance / _time) * 60;
    }
    public override float GetPace() {
        return _time * _distance;
    }
    public override string GetSummary() {
        return $"{_date} {_name} ({_time} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}