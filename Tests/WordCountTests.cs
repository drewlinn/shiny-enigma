using Xunit;
using System;
using System.Collections.Generic;
using WordCounter.Objects;

namespace WordCounter.Objects;
{
  public class WordCounterTest
  {
    [Fact]
    public void Counts_Word_Instances()
    {
      //Arrange
      RepeatCounter testInstance = new RepeatCounter("TestWord");
      //Act
      string word = testInstance.CountRepeat();
      //Assert
      Assert.Equal(1, word)
    }
  }
}
