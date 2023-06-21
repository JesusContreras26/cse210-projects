using System;

//Eternal goal class
public class EternalGoal: Goal{
    //This class doesn't have own attributes

    //Constructor to assign values to the super class attributes
    public EternalGoal(string name, string description, int points): base(name, description, points){

    }

    //IsCompleted to check if the goal has been completed in this case it'll always return false because
    //this is a eternal goal that will never end
    public override bool IsCompleted()
    {
        return false;
    }

    //RecordEvent to change the status of this goal, although here it'll return the points earned and nothig else
    public override int RecordEvent()
    {
        return GetPoints();
    }
}