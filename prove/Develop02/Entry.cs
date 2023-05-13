public class Entry {
  public string _hour;
  public string _prompt;
  public string _response;

  public string CreateEntry() {
    //Method to create an entry from the attributes
    return $"- {_hour}: {_prompt}\n > {_response}";
  }
}