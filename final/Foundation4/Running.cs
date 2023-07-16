using System;

public class Running: Activity{
    private double _distance;

    public Running(int year, int month, int day, int length, string title, double distance): base(year, month, day, length, title){
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return Math.Round((GetDistance() / GetLength()) * 60, 2);
    }

    public override double GetPace()
    {
        return Math.Round(GetLength() / GetDistance() , 2);
    }
}