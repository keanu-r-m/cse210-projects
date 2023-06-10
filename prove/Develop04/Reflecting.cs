class Reflecting: Activity {
  private List<string> _prompts;
  private List<string> _reflections;
  public Reflecting() {
    _name = "Reflecting activity";
    _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    _prompts = new List<string>() {
      "Think of a time when you stood up for someone else.",
      "Think of a time when you did something really difficult.",
      "Think of a time when you helped someone in need.",
      "Think of a time when you did something truly selfless."
    };
    _reflections = new List<string>() {
      "Why was this experience meaningful to you?",
      "Have you ever done anything like this before?",
      "How did you get started?",
      "How did you feel when it was complete?",
      "What made this time different than other times when you were not as successful?",
      "What is your favorite thing about this experience?",
      "What could you learn from this experience that applies to other situations?",
      "What did you learn about yourself through this experience?",
      "How can you keep this experience in mind in the future?"
    };
  }
  public void DisplayPrompt() {
    // This method displays a random prompt
    Random random = new Random();
    Console.WriteLine("\nConsider the following prompt:\n");
    Console.WriteLine($"--- {_prompts[random.Next(0, _prompts.Count)]} ---\n");
    Console.WriteLine("When you have something in mind press Enter to continue");
    Console.ReadKey();
    Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
  }
  public void DisplayReflections() {
    // This method displays the reflections
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(_duration);

    CountDownAnimation("You may begin in: ", 5);
    Console.Clear();
      
    int i = 0;
    while (DateTime.Now < futureTime) {
      SpinnerAnimation($"> {_reflections[i]} ", 15);
      Console.WriteLine("");
      i++;
    } 
  }
}