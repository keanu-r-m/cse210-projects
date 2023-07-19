public class Receptions : Event {
    private string _rsvpEmail;

    public Receptions(string rsvpEmail, string title, string eventType, string description, string date, string time, Address address) : base(title, eventType, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GenerateFullDetails() {
        return $"{_title}\n{_description}\n{_date}\n{_time}\n{_address.MakeAddress()}\n{_eventType}\n{_rsvpEmail}";
    }
}