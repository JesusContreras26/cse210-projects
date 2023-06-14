using System;

public class Square: Shape{

    private double _side = 0;

    public Square(string color, double side): base(color){
        _side = side;
    }

    public override double GetArea()
    {
        return Math.Round(_side*_side, 2);
    }
}