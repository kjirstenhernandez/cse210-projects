using System;

class Program
{
    static void Main(string[] args)
    {
        Running RunningActivity1 = new Running(30, 3.0);
        Swimming SwimmingActivity1 = new Swimming(30, 20);
        Cycling CyclingActivity1 = new Cycling(30, 40);

        List<Activity> activities = new List<Activity>();
        activities.Add(RunningActivity1);
        activities.Add(SwimmingActivity1);
        activities.Add(CyclingActivity1);

        foreach (Activity activity in activities){
            Console.WriteLine(activity.GetSummary(activity.GetDistance(), activity.GetSpeed(), Math.Round(activity.GetPace(), 2)));
        }
        
    }
}