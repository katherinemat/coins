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
        int quarters = total/25;
        string stringQuarters = quarters.ToString();
        _coinNames.Add(stringQuarters);
      }

      return _coinNames;
    }

  }
}
