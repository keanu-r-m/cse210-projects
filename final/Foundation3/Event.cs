public class Event {
    protected string _title;
    protected string _eventType;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    public Event(string title, string eventType, string description, string date, string time, Address address) {
        _title = title;
        _eventType = eventType;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GenerateStandardDetails() {
        return $"{_title}\n{_description}\n{_date}\n{_time}\n{_address.MakeAddress()}";
    }
    public string GenerateShortDescription() {
        return $"{_eventType}\n{_title}\n{_date}";
    }
}