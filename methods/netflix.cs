public class Netflix
{
    public string Name { get; set; }
    public int Rating { get; set; }
    public string Genre { get; set; }

    public string getSuggestion(){
      if (this.Rating >= 4) {
        return "You definitely need to watch this show";
      } else {
        return "You probably won't want to watch this show";
      }
    }
}