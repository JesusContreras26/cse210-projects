using System;

public class Swimming: Activity{

    private int _laps;

    public Swimming(int year, int month, int day, int length, string title, int laps): base(year, month, day, length, title){
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000;
    }

    public override double GetSpeed()
    {
        return Math.Round((GetDistance() / GetLength()) * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(GetLength() / GetDistance(), 2);
    }
}