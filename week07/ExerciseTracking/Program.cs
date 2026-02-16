using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new  DateTime(2026, 02, 13), 30, 3.0));
        activities.Add(new Cycling(new  DateTime(2026, 02, 13), 45, 12.0));
        activities.Add(new Swimming(new DateTime(2026, 02, 13), 60, 40));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}