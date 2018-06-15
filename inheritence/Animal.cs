public class Animal
{
  public string latinName { get; set; }
  public string Habitat { get; set; }
  public int NumberOfLegs { get; set; }
  public int Weight { get; set; }
  public int AverageNumOffspring { get; set; }
  public bool HasFur { get; set; }
  public bool HasWings { get; set; }
  public bool CanFly { get; set; }

  public virtual string StateType()
  {
    return "I am an animal.";
  }

  public virtual string GetMad()
  {
    return "ROAR!!";
  } 
}