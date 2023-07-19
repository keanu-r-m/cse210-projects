public class Outdoor : Event {
    private string _weatherStatement;

    public Outdoor(string weatherStatement, string title, string eventType, string description, string date, string time, Address address) : base(title, eventType, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
    }

    public string GenerateFullDetails() {
        return $"{_title}\n{_description}\n{_date}\n{_time}\n{_address.MakeAddress()}\n{_eventType}\n{_weatherStatement}";
    }
}