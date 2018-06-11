public class Player
{
  public int Points { get; set; }
  public string Weapon { get; set; }

  public string Attack(){
    return "The player attacked for 5 points";
  }

  public string Attack(int attackPoints){
    return $"The player attacked for {attackPoints} points and has the sword";
  }

  public string Attack(int attackPoints, string weaponName){
    attackPoints += 5;
    return $"The player attacked for {attackPoints} points and has a {weaponName}";
  }
}