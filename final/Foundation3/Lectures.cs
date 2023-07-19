public class Lectures : Event {
    private string _speakerName;
    private int _capacity;

    public Lectures(string speakerName, int capacity, string title, string eventType, string description, string date, string time, Address address) : base(title, eventType, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public string GenerateFullDetails() {
        return $"{_title}\n{_description}\n{_date}\n{_time}\n{_address.MakeAddress()}\n{_eventType}\n{_speakerName}\n{_capacity}";
    }
}