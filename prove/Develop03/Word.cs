using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Word {
  private string _text;

  public Word() {
    _text = "";
  }
  public void SetText(string text) {
    _text = text;
  }
  public List<string> SetRandomWord() {
    Random random = new Random();
    List<String> text = new List<String>(_text.Split(' '));
    Regex rgx = new Regex(@"\-");
    List<string> temp = new List<string>(){"-", "-", "-"};
    for (int i=0; i<temp.Count; i++) {
      while (rgx.IsMatch(temp[i]) == true) {
      temp[i] = text[random.Next(0, text.Count)];
      }
    }
    return temp;
  }
}
