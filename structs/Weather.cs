public struct Weather
{
    public int Temperature;
    public bool IsCloudy;

    public string Forcast(int temp, bool isCloudy)
    {
      string cloudy;
      if(isCloudy)
      {
        cloudy = "it will be cloudy";
      } else
      {
         cloudy = "it will be sunny";
      }
      string forcast = ($"Today the temperature will be {temp} degrees and {cloudy}");

      return forcast;
    }
}