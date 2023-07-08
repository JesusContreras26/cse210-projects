using System;

public class Comment{

    private string _name;
    private string _comment;

    public void SetName(string name){
        _name = name;
    } 

    public string GetName(){
        return _name;
    }

    public void SetComment(string comment){
        _comment = comment;
    }

    public string GetComment(){
        return _comment;
    }
}