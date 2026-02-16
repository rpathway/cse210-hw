public class Swimming : Activity
{
  private int _laps;

  public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
  {
    _laps = laps;
  }

  public override double GetDistance()
  {
    // miles conversion
    return _laps * 50 / 1000 * 0.62;
  }

  public override double GetSpeed()
  {
    return (GetDistance() / GetMinutes()) * 60;
  }

  public override double GetPace()
  {
    return GetMinutes() / GetDistance();
  }

  public override string GetSummary()
  {
    return $"{GetDate():dd MMM yyyy} Swimming ({GetMinutes()} min)- Distance {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
  }
}