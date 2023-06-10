using System;
class Activity {
  //Base class
  protected string _name;
  protected string _description;
  protected int _duration;
  public string GetName() {
    return _name;
  }
  public int GetDuration() {
    return _duration;
  }
  public void DisplayMessage() {
    // This method displays the welcoming message for each activity
    Console.WriteLine($"Welcome to the {_name}.\n\n{_description}\n");
    Console.Write("How long, in seconds would you like for your session? ");
    // Here we ask the user how long does he/she want the session duration
    _duration = int.Parse(Console.ReadLine());
    int min = 0;
    if (_name == "Breathing Activity" || _name == "Listing Activity") min = 10;
    else min = 15;
    while (_duration < min) {
      Console.Write($"The duration must be at least {min} seconds.\nPlease give another: ");
      _duration = int.Parse(Console.ReadLine());
    }
    Console.Clear();
  }
  public void SpinnerAnimation(string message, int sec) {
    // This method will pause every session to prepare the user and shows a spinner animation.
    // The message parameter will be a message displayed before the animation like "Get ready..." for example.
    Console.Write(message);
    DateTime currentTime = DateTime.Now;
    DateTime futureTime = currentTime.AddSeconds(sec);
    List<string> animElement = new List<string>(){"|", "/", "-","\\","|", "/", "-","\\"};
    int i = 0;
    // Loop responsible for the spinner during 5 seconds
    while (DateTime.Now < futureTime) {
      Console.Write(animElement[i]);
      Thread.Sleep(200);
      Console.Write("\b \b");
      i++;
      if (animElement.Count == i) i = 0;
    }
  }
  public void CountDownAnimation(string message, int startNumber) {
    // This method displays the value of the message parameter followed by a countdown animation starting with the startNumber parameter.
    Console.Write(message);
      for (int i=startNumber; i>=1; i--) {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
      }
  }
}