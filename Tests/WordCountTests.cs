using Xunit;
using System;
using System.Collections.Generic;
using WordCounter.Objects;

namespace WordCounter.Objects
{
  public class WordCounterTest
  {
    [Fact]
    public void Checks_for_Word()
    {
      //Arrange, Act
      string testString = "This is a TestWord";
      bool contains = testString.Contains("TestWord");
      //Assert
      Assert.Equal(true, contains);
    }

    // [Fact]
    // public void Splits_String_Into_Words()
    // {
    //   //Arrange, Act
    //   string testString = "This is a TestWord";
    //   string[] words = testString.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
    //   string[] testArray = {"This", "is", "a", "TestWord"};
    //   //Assert
    //   Assert.Equal(testArray, words);
    // }

    // [Fact]
    // public void Counts_Word_Instances()
    // {
    //   //Arrange
    //   RepeatCounter testInstance = new RepeatCounter("TestWord TestWord TestWord", "TestWord");
    //   //Act
    //   int Repeats = testInstance.CountRepeat("TestWord TestWord TestWord", "TestWord");
    //   //Assert
    //   Assert.Equal(3, Repeats);
    // }
  }
}
