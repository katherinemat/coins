using System.Collections.Generic;
using System;

namespace Coins
{
  public class Coins
  {
    private int _amount;
    private List<string> _coinNames = new List<string>();

    public Coins(int amount)
    {
      _amount = amount;
    }

    public List<string> Change()
    {
      int total = _amount;
      if(total >= 25)
      {
        int maxQuarters = total/25;
        Random amountQuarters = new Random();
        int quarters = amountQuarters.Next(1, maxQuarters);
        string stringQuarters = quarters.ToString() + " quarters";
        _coinNames.Add(stringQuarters);
        total = total - (quarters * 25);
      }
      if(total >= 10)
      {
        int maxDimes = total/10;
        Random amountDimes = new Random();
        int dimes = amountDimes.Next(1, maxDimes);
        string stringDimes = dimes.ToString() + " dimes";
        _coinNames.Add(stringDimes);
        total = total - (dimes * 10);
      }
      if(total >= 5)
      {
        int maxNickels = total/5;
        Random amountNickels = new Random();
        int nickels = amountNickels.Next(1, maxNickels);
        string stringNickels = nickels.ToString() + " nickels";
        _coinNames.Add(stringNickels);
        total = total - (nickels * 5);
      }
      if(total >= 1)
      {
        int pennies = total/1;
        string stringPennies = pennies.ToString() + " pennies";
        _coinNames.Add(stringPennies);
        total = total - (pennies * 1);
      }
      return _coinNames;
    }
  }
}
