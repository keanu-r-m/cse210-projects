using System;
using System.Collections.Generic;
using System.IO;
public class Journal {
  public string _date;
  public List<Entry> _entryList = new List<Entry>();
  public string _filename;
  
  public void DisplayEntries() {
    //Method to display all entries
    Console.WriteLine(_date);
    foreach (Entry i in _entryList) {
      Console.WriteLine(i.CreateEntry());
    }
  }
  public void SaveToFile() {
    //Method to Save the journal to a file
    Console.Write("what is your filename? ");
    _filename = Console.ReadLine();
    using (StreamWriter outputFile = new StreamWriter(_filename)) {
      outputFile.WriteLine(_date);
      foreach (Entry i in _entryList) {
        outputFile.WriteLine($" {i._hour};{i._prompt};{i._response}");
      }
    }
  }
  public void LoadFromFile() {
    //Method to load the journal from a file
    Console.Write("what is your filename? ");
    _filename = Console.ReadLine();
    string[] lines = System.IO.File.ReadAllLines(_filename);
    
    for (int i=0; i<lines.Length; i++) {
      if (i==0) _date = lines[0];
      else {
        string[] parts = lines[i].Split(";");
        Entry fileLine = new Entry();
        fileLine._hour = parts[0];
        fileLine._prompt = parts[1];
        fileLine._response = parts[2];
        _entryList.Add(fileLine);
      }
      
    }
  }
}