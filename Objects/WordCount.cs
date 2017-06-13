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

    public static bool Contains(string inString, string countWord)
    {
      bool Contains = inString.Contains(countWord);
      if (Contains == true)
      {
        return true;
      }
      return false;
    }

    public int CountRepeat(string inString, string countWord)
    {
      int repeats = 0;
      string[] stringWords = inString.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);

      for (int i = 0; i <= stringWords.Length; i++)
      {
        bool contains = stringWords.Contains(countWord);
        if (contains == true)
        {
          repeats += 1;
        }
      }
      return repeats;
    }

  }
}
