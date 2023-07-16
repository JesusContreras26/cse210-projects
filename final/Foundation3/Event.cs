using System;

public abstract class Event{
    private string _title;
    private string _description;
    protected DateTime _date;
    private int _time;
    protected Address _address;

    public Event(string title, string description, int year, int month, int day, int time, string street, string city, string state, string country){
        _title = title;
        _description = description;
        _time = time;
        _date = new DateTime(year, month, day);
        _address = new Address(street, city, state, country);
    }

    public string GetTitle(){
        return _title;
    }

    public string GetDescription(){
        return _description;
    }

    public int GetTime(){
        return _time;
    }

    public string StandardDetails(){
        return $"{_title}, {_description} {_date.ToString("M/d/yyyy")} {_time} {_address.GetAddress()}";
    }

    public abstract string FullDetails();

    public abstract string ShortDescription();

}