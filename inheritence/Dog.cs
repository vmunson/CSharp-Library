public class Dog : Animal
{
  public string FurColor { get; set; }
  public string FurLength { get; set; }
  public string Breed { get; set; }
  public bool IsHouseTrained { get; set; }

  public override string StateType()
  {
    return "I am a dog.";
  }

  public override string GetMad()
  {
    return "GRRR!!";
  }
}