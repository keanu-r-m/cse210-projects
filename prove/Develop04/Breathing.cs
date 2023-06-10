class Breathing: Activity {
  public Breathing () {
    _name = "Breathing Activity";
    _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
  }
  public void DisplayAlterningMessage() {
    // This function displays alternatively the message "breathe in" and "Breathe out", during the user specified duration.
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(_duration);
    while (DateTime.Now < futureTime) {
      CountDownAnimation("\n\nBreathe in...", 4);
      CountDownAnimation("\nBreathe out...", 6);
    }
    Console.WriteLine("\n");
  }
}