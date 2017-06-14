using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    private string _inString;
    private string _countWord;

    public RepeatCounter(string inString, string countWord)
    {
      _inString = inString;
      _countWord = countWord;
    }

    public int CountRepeat(string inString, string countWord)
    {
      int repeats = 0;
      string[] stringWords = inString.Split(' ');
      foreach (string word in stringWords)
      {
        if (inString.Contains(countWord))
        {
          repeats += 1;
        }
      }
      return repeats;
    }
  }
}
