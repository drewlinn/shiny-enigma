using Xunit;
using System;
using System.Collections.Generic;
using WordCounter.Objects;

namespace WordCounter.Objects
{
  public class WordCounterTest
  {
    [Fact]
    public void Counts_Word_Instances()
    {
      //Arrange
      RepeatCounter testInstance = new RepeatCounter("TestWord, This is a TestWord", "TestWord");
      //Act
      int Repeats = testInstance.CountRepeat("TestWord, This is a TestWord.", "TestWord");
      //Assert
      Assert.Equal(1, Repeats);
    }
  }
}
