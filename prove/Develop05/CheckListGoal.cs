using System;

//CheckList class, this class will be a goal that need to be completed several times to finish it
public class CheckListGoal: Goal{
    //Creating its attributes
    private int _timesToComplete;
    private int _timesCompleted;
    private int _bonusPoints;

    //Constructor to define values to the attributes of this class and for its super class goal
    public CheckListGoal(int timesToComplete, int bonusPoints, string name, string description, int points): base(name, description, points){
        _timesToComplete = timesToComplete;
        _bonusPoints = bonusPoints;
    }

    //Getters and Setters for this class attributes
    public void SetTimesToComplete(int timesToComplete){
        _timesToComplete = timesToComplete;
    }

    public int GetTimesToComplete(){
        return _timesToComplete;
    }

    public void SetTimesCompleted(int timesCompleted){
        _timesCompleted = timesCompleted;
    }

    public int GetTimesCompleted(){
        return _timesCompleted;
    }

    public void SetBonusPoints(int bonusPoints){
        _bonusPoints = bonusPoints;
    }

    public int GetBonusPoints(){
        return _bonusPoints;
    }


    //Overriding IsCompleted, here we will return true if times to complete and times completed are equal
    //if it's not it'll return false
    public override bool IsCompleted()
    {
        if(_timesToComplete == _timesCompleted){
            return true;
        }else{
            return false;
        }
    }

    //Overriding RecordEvent, it'll change the status of the goal, here it'll modificate times completed 
    //every time it's called and it has a conditional to check if it's not the last time this goal is completed
    //to return the bonuspoints too or only the default points
    public override int RecordEvent()
    {
        _timesCompleted += 1;
        if (_timesCompleted == 3){
            return _bonusPoints + GetPoints();
        }else{
            return GetPoints();
        }

    }

}