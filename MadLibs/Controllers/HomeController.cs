using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form() { return View(); }
    
    [Route("/story")]
    public ActionResult StoryOptions (string noun, string verb, string adverb, string adjective, string noun2, string noun3, string adjective2, string verb2, string adverb2, string verb3, string adjective3, string exclamation)
    {
      MadLibsVariable myMadLibsVariable = new MadLibsVariable();
      myMadLibsVariable.Noun = noun;
      myMadLibsVariable.Verb = verb;
      myMadLibsVariable.Adverb = adverb;
      myMadLibsVariable.Adjective = adjective;
      myMadLibsVariable.Noun2 = noun2;
      myMadLibsVariable.Noun3 = noun3;
      myMadLibsVariable.Adjective2 = adjective2;
      myMadLibsVariable.Verb2 = verb2;
      myMadLibsVariable.Adverb2 = adverb2;
      myMadLibsVariable.Verb3 = verb3;
      myMadLibsVariable.Adjective3 = adjective3;
      myMadLibsVariable.Exclamation = exclamation;

      return View(myMadLibsVariable);
    }
    
  }
}