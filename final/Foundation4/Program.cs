using System;

class Program
{
    static void Main(string[] args)
    {
        List <Activity> _activities = new List<Activity>();

        Running _running = new Running(2023, 08, 25, 30, "Running", 4.8);
        _activities.Add(_running);

        Cycling _cycling = new Cycling(2023, 10, 14, 40, "Cycling", 9.7);
        _activities.Add(_cycling);

        Swimming _swimm = new Swimming(2023, 12, 05, 50, "Swim", 20);
        _activities.Add(_swimm);

        foreach (Activity _activity in _activities)
        {
            Console.WriteLine(_activity.GetSummary());
        } 
    }
}