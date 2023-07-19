public class Swimming : Activity {
    private float _laps;
    public Swimming(float laps, string name, string date, int time) : base(name, date, time)
    {
        _laps = laps;
    }

    public override float GetDistance() {
        return _laps * 50 / 1000;
    }
    public override float GetSpeed() {
        return (GetDistance() / _time) * 60;
    }
    public override float GetPace() {
        return _time * GetDistance();
    }
    public override string GetSummary() {
        return $"{_date} {_name} ({_time} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}