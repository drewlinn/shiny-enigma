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
      RepeatCounter testInstance = new RepeatCounter("TestWord, This is a TestWord", "TestWord");
      //Act
      bool Repeats = testInstance.CountRepeat("TestWord, This is a TestWord.", "TestWord");
      //Assert
      Assert.Equal(true, Repeats);
    }

    [Fact]
    public void Counts_Word_Instances()
    {
      //Arrange

      //Act

      //Assert

    }
  }
}
