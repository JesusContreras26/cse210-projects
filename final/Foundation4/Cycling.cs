using System;

public class Cycling: Activity{

    private double _speed;

    public Cycling(int year, int month, int day, int length, string title, double speed): base(year, month, day, length, title){
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return Math.Round(60 / _speed, 2);
    }
}