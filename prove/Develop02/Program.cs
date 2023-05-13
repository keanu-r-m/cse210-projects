using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    
    //Menu
    Console.WriteLine("Please select one of the following choices:");
    Console.WriteLine("1. Write"); 
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Save");
    Console.WriteLine("4. Load");
    Console.WriteLine("5. Quit\n");

    //Journal class instanciation
    Journal myJournal = new Journal();
    
    //Random for the menu index
    Random randIndex = new Random();

    //Getting prompts file
    string[] lines = System.IO.File.ReadAllLines("prompts.txt");
    List<string> prompts = new List<string>();
    foreach(string line in lines) {
      prompts.Add(line);
    }
        
    //Conditions
    int choice = 0;

    while (choice != 5) {
      Console.Write("What would you like to do? ");
      choice = int.Parse(Console.ReadLine());
      
      if (choice == 1) {
        //Editing the Entry and add it to the Journal
        DateTime currentDateTime = DateTime.Now;

        //Entry class instanciation
        Entry myEntry = new Entry();
        
        myEntry._hour = currentDateTime.ToString("h:mm tt");
        
        Console.WriteLine("Would you like to add your own prompt or generate from our list?");
        Console.WriteLine("To add your own, type \"add\"\nto generate from our list, press ENTER key");
        string usrChoice = Console.ReadLine();

        if (usrChoice=="add") {
          Console.Write("Write your prompt: ");
          myEntry._prompt = Console.ReadLine();
          Console.Write("Now, write your answer:\n> ");
        }
        else {
          myEntry._prompt = prompts[randIndex.Next(0, 15)];
          Console.Write(myEntry._prompt+"\n> ");
        }
        
        myEntry._response = Console.ReadLine();
        myJournal._entryList.Add(myEntry);
      }
      else if (choice == 2) {
        myJournal.DisplayEntries();
      }
      else if (choice == 3) {
        DateTime currentDateTime = DateTime.Now;
        myJournal._date = currentDateTime.ToString("dddd, dd MMMM yyyy");
        myJournal.SaveToFile();
      }
      else if (choice == 4) {
        myJournal.LoadFromFile();
      }
      else if (choice == 5) {
        break;
      }
      else {
        Console.WriteLine("Choose a number from the menu\n");
      }
    }
  }
}