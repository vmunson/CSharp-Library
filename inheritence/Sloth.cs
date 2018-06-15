public class Sloth : Animal
{
  public int NumberOfToes { get; set; }

  public override string StateType()
  {
    return "I am a sloth.";
  }

  public override string GetMad()
  {
    return "MEEP!";
  }
}