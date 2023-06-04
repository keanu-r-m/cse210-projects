using System;
using System.Text.RegularExpressions;
using System.Globalization;

class Program {
  public static void Main (string[] args) {
    string loopUserAnsw = "";
    while (loopUserAnsw != "quit") {
      Regex rgx = new Regex(@"\w");
      string txt = "";
      Scripture myScripture = new Scripture();

      TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
      Console.Write("Give the name of your the book: ");
      string bookName = textInfo.ToTitleCase(Console.ReadLine());
      Console.Write("Give the chapter: ");
      int chapt = int.Parse(Console.ReadLine());
      Console.Write("Give the verse: ");
      int verse = int.Parse(Console.ReadLine());
  
      Console.Write("Would you like to continue to another verse? yes/no: ");
      string answ = Console.ReadLine();
      Console.Write("\n");
      if (answ == "no") {
        myScripture.SetReference(new Reference(bookName, chapt, verse));
        txt = myScripture.GetReference().GetVerse();
      }
      else {
        Console.Write("Give the other verse: ");
        int continuingVerse = int.Parse(Console.ReadLine());
        myScripture.SetReference(new Reference(bookName, chapt, verse, continuingVerse));
        txt = myScripture.GetReference().GetVerse();
      }
      
      string userResponse = "";
      while (userResponse != "stop" && rgx.IsMatch(txt)) {
        
        myScripture._word.SetText(txt);
        Console.WriteLine($"{myScripture.GetReference().CreateReference()}: {txt}");
        txt = myScripture.Hide(txt);
        
        Console.Write("\nPress ENTER to continue or type \"stop\" to abandon: ");
        userResponse = Console.ReadLine();
        
        Console.Clear();
      }
      Console.WriteLine($"{myScripture.GetReference().CreateReference()}: {txt}");
      Console.Write("Do you want to go for another round or quit? go/quit: ");
      loopUserAnsw = Console.ReadLine();
    }
  }
}
