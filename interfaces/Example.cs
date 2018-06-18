public class Example : IExample
{
    public int Num1 { get; set; }
    public int Num2 { get; set; }

    int num3;

    public int addition(){
      num3 = Num1 + Num2;

      return num3;
    }
}