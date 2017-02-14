using System.Collections.Generic;
using System;
using Xunit;

namespace Coins
{
  public class CoinsTest
  {

    [Fact]
    public void Test2_ReturnQuarters_Quarters()
    {
      int userInput02 = 81;
      Coins newCoins = new Coins(userInput02);
      List<string> change = newCoins.Change();
      List<string> check = new List<string> { "3" };

      Assert.Equal(check, change);
    }
  }
}
