using System;
using System.Collections.Generic;

class Scripture {
  private Reference _reference;
  private string _text;
  public Word _word = new Word();

  public void SetReference(Reference reference) {
    _reference = reference;
  }
  public Reference GetReference() {
    return _reference;
  }
  public string Hide(string txt) {
    List<string> newText = new List<string>(txt.Split(' '));
    List<string> wrd = _word.SetRandomWord();
    foreach(string element in wrd) {
      for (int i=0; i<newText.Count; i++) {
        if (newText[i] == element) {
          newText[i] = new string('-', element.Length);
        }
      }
    }
    return string.Join( " ", newText);
  }
}
