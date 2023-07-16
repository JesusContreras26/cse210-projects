using System;

public class Activity{
    private DateTime _date;
    private int _length;

    private string _title;


    public Activity(int year, int month, int day, int length, string title){
        _date = new DateTime(year, month, day);
        _length = length;
        _title = title;
    }

    public int GetLength(){
        return _length;
    }

    public virtual double GetDistance(){
        return -1;
    }

    public virtual double GetSpeed(){
        return -1;
    }

    public virtual double GetPace(){
        return -1;
    }

    public string GetSummary(){
        if (GetDistance() == -1){
            return $"{_date.ToString("M/d/yyyy")} {_title} ({_length}): Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
        }else{
            return $"{_date.ToString("M/d/yyyy")} {_title} ({_length}): Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
        }

    }
}