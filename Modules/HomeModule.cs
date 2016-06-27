using Nancy;
using MadLibs.Objects;

namespace MadLibs
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"]= _ => {
        return View["form.cshtml"];
      };
      Get["/excellent_story"]=_=>{
        StoryVariables myStoryVariables = new StoryVariables
        {
          Person1 = Request.Query["person1"],
          Person2 = Request.Query["person2"],
          Adjective = Request.Query["adjective"],
          PluralFood = Request.Query["pluralFood"],
          HistoricalFigure = Request.Query["historicalFigure"],
          Animal = Request.Query["animal"],
          Exclamation = Request.Query["exclamation"],
          Verb = Request.Query["verb"],
          TimePeriod = Request.Query["timePeriod"]
        };
        return View["story.cshtml", myStoryVariables];
      };
    }
  }
}
