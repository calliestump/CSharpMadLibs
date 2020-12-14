namespace MadLibs.Models
{
  public class MadLibsVariable
  {
    public string Noun { get; set; }
    public string Verb { get; set; }
    public string Adverb { get; set; }
    public string Adjective { get; set; }
    public string Noun2 { get; set; }
    public string Noun3 { get; set; }
    public string Adjective2 { get; set; }
    public string Verb2 { get; set; }
    public string Adverb2 { get; set; }
    public string Verb3 { get; set; }
    public string Adjective3 { get; set; }
    public string Exclamation { get; set; }
  }

  //refactor to new file: e.g. PuppyStoryVariable.cs
  // public class PuppyStory 
  // {
  //   public string PuppyNoun { get; set; }
  // }
}