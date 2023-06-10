class Listing: Activity {
    private List<string> _prompts;
    public Listing() {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>() {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }
    public void DisplayPrompt() {
        Random random = new Random();
        Console.WriteLine("\nList as many responses you can to the following prompt:\n");
        Console.WriteLine($"--- {_prompts[random.Next(0, _prompts.Count)]} ---\n");
        Console.WriteLine("When you have something in mind press Enter to continue");
    }
    public void ListItems() {
        // This function ask the user to write their prompts
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        CountDownAnimation("You may begin in: ", 5);
        Console.WriteLine("");
        
        string response = "";
        while (DateTime.Now < futureTime) {
            Console.Write("> ");
            response = Console.ReadLine();
        }
    }
}