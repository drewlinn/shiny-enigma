using System.Collections.Generic;
using System;

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

    public bool Contains(string inString, string countWord)
    {
      bool Contains = inString.Contains(countWord);
      if (Contains == true)
      {
        return true;
      }
      return false;
    }
  }
}
