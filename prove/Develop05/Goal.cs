using System;

//Super class goal, this class will have all the behaviours and attributes that all
//its children classes have in common

public abstract class Goal{

    //Declaring common attributes
    private string _name;
    private string _description;
    private int _points;

    //Constructor to assign attributes to values
    public Goal(string name, string description, int points){
        _name = name;
        _description = description;
        _points = points;
    }

    //Setters and getter for the attributes
    public void SetName(string name){
        _name = name;
    }

    public string GetName(){
        return _name;
    }

    public void SetDescription(string description){
        _description = description;
    }

    public string GetDescription(){
        return _description;
    }

    public void SetPoints(int points){
        _points = points;
    }

    public int GetPoints(){
        return _points;
    }

    //common behaviours to be overriden they are abastract because they are like templates
    public abstract bool IsCompleted();
    
    public abstract int RecordEvent();
}