using System.Collections.Generic;
using System;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string _inString;
    private string _countWord;

    public RepeatCounter(string InString, string CountWord)
    {
      _inString = InString;
      _countWord = CountWord;
    }

    public string GetWord()
    {
      return _countWord;
    }

    // public void SetWord(string newWord)
    // {
    //   _countWord = newWord;
    // }

    public string GetString()
    {
      return _inString;
    }

    // public void SetString(string newString)
    // {
    //   _inString = newString;
    // }

    public int CountRepeat(string InString, string CountWord)
    {
      int Repeats = 0;
      bool contains = InString.Contains(CountWord);
      if (contains == true)
      {
        Repeats +=1;
      }
      Console.WriteLine(Repeats);
      return Repeats;
    }
  }
}
