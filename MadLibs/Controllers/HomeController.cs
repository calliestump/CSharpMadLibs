using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    /*[Route("/test")]
    public string Hello() { return "This is working"; }*/

    [Route("/")]
    public ActionResult Form() { return View(); }
    
    /*[Route("/form")]
    public ActionResult Form() { return View(); }*/
    
    [Route("/story")]
    public ActionResult StoryOptions (string noun, string adjective, string verb, string adverb, string exclamation)
    {
      MadLibsVariable myMadLibsVariable = new MadLibsVariable();
      myMadLibsVariable.Noun = noun;
      myMadLibsVariable.Adjective = adjective;
      myMadLibsVariable.Verb = verb;
      myMadLibsVariable.Adverb = adverb;
      myMadLibsVariable.Exclamation = exclamation;

      return View(myMadLibsVariable);
    }
    

  }
}