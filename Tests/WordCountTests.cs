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
      //Arrange
      RepeatCounter testInstance = new RepeatCounter("This is a TestWord", "TestWord");
      //Act
      bool contains = testInstance.Contains("This is a TestWord.", "TestWord");
      //Assert
      Assert.Equal(true, contains);
    }

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
