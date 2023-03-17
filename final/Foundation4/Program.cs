using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Running running = new Running(DateTime.Parse("16/03/2023 12:15:12"),60,(float)60);
        Bicycling bicycling = new Bicycling(DateTime.Parse("17/03/2023 09:30:59"), 60, 60);
        Swimming swimming = new Swimming(DateTime.Parse("18/03/2023 19:20:00"),60, 60);

        activities.Add(running);
        activities.Add(bicycling);
        activities.Add(swimming);

        foreach(Activity activity in activities){
            System.Console.WriteLine(activity.getSummary());
            System.Console.WriteLine(); 
        }
    }
}