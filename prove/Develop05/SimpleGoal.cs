using System;

//SimpleGoal class, it's a child of goal class
public class SimpleGoal: Goal{
    //bool to check if the goal has been completed or not
    private bool _check;

    //Constructor for assigning values to this class and the super class
    public SimpleGoal(string name, string description, int points, bool check): base(name, description, points){
        _check = check;
    }

    //overrinding abstract methods from the super class

    //IsCompleted method is to check if the goal has been completed or not in this case will be like
    //a getter for the _check variable
    public override bool IsCompleted()
    {
        return _check;

    }

    //RecordEvent will change the status of the goal and return the points earned
    public override int RecordEvent()
    {   
        _check = true;
        return GetPoints();
    }


}