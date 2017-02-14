using Nancy;
using System.Collections.Generic;
using System;

namespace Coins
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        int userInput = Request.Form["number"];
        Coins newCoins = new Coins(userInput);
        List<string> change = newCoins.Change();
        return View["index.cshtml", change];
      };
    }
  }
}
