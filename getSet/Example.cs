public class Example
{
    int _number;
    public int Number
    {
        get
        {
            return this._number;
        }
        set
        {
          if (Number > 0)
          {
            this._number = value;
          }else
          {
              this._number = 0;
          }
        }
    }
}