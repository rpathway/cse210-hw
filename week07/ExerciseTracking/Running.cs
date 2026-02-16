public class Running : Activity
{
  private double _distance;

  public Running(DateTime date, int minutes, double distance) : base(date, minutes)
  {
    _distance = distance;
  }

  public override double GetDistance()
  {
    return _distance;
  }

  public override double GetSpeed()
  {
    return (_distance / GetMinutes()) * 60;
  }

  public override double GetPace()
  {
    return GetMinutes() / _distance;
  }

  public override string GetSummary()
  {
    return $"{GetDate():dd MMM yyyy} Running ({GetMinutes()} min)- Distance {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
  }
}