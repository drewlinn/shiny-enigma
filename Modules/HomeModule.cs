using Nancy;
using System.Collections.Generic;
using WordCounter.Objects;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        RepeatCounter instance = new RepeatCounter(Request.Form["string"], Request.Form["word"]);
        int WordCount = instance.CountRepeat(Request.Form["string"], Request.Form["word"]);
        return View["result.cshtml", WordCount];
      };
    }
  }
}
