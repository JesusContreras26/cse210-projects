using System;

public class Circle: Shape{

    private double _radius = 0;
    private double pi = Math.PI;

    public Circle(string color, double radius): base(color){
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.Round(pi*(_radius*_radius), 2);
    }
}