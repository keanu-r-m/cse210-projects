using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class Reference {
  private string _bookName;
  private int _chapter;
  private int _verseStart;
  private int _verseEnd;
  private string _text;

  public Reference(string bookname, int chapter, int versestart, int verseend) {
    _bookName = bookname;
    _chapter = chapter;
    _verseStart = versestart;
    _verseEnd = verseend;
    _text = "";
  }
  public Reference(string bookname, int chapter, int versestart) {
    _bookName = bookname;
    _chapter = chapter;
    _verseStart = versestart;
    _verseEnd = 0;
    _text = "";
  }
  public string CreateReference() {
    if (_verseEnd == 0) {
      return $"{_bookName} {_chapter}:{_verseStart}";
    }
    else {
      return $"{_bookName} {_chapter}:{_verseStart}-{_verseEnd}";
    }
  }
  public string GetVerse() {
    string json = "";
    using (StreamReader r = new StreamReader("old-testament.json")) {
      json = r.ReadToEnd();
    }
    using JsonDocument doc = JsonDocument.Parse(json);
    var rootElement = doc.RootElement;
    var bookJsonElement = rootElement.GetProperty("books");
    foreach (var jsonElement in bookJsonElement.EnumerateArray()) {
      string book = jsonElement.GetProperty("book").GetString();
      if (book == _bookName) {
        var chapters = jsonElement.GetProperty("chapters");
        foreach (var chapterElement in chapters.EnumerateArray()) {
          int chapter = chapterElement.GetProperty("chapter").GetInt32();
          if (chapter == _chapter) {
            var verses = chapterElement.GetProperty("verses");
            if (_verseEnd == 0) {
              foreach (var verseElement in verses.EnumerateArray()) {
                int verse = verseElement.GetProperty("verse").GetInt32();
                if (verse == _verseStart) {
                  _text = verseElement.GetProperty("text").GetString();
                }
              }
            }
            else {
              for (int i=_verseStart-1; i<=_verseEnd; i++) {
                _text += verses[i].GetProperty("text");
              }
            }
          }
        }
      }
    }
    return _text;
  }
}
