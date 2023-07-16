using System;

public class Lecture: Event{

    private string _speaker;
    private int _capacity; 

    public Lecture(string title, string description, int year, int month, int day, int time, string street, string city, string state, string country, string speaker,
    int capacity): base(title, description, year, month, day, time, street, city, state, country)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        return $"{GetTitle()}, {GetDescription()}, Date: {_date.ToString("M/d/yyyy")} Duration: {GetTime()} minutes, Address: {_address.GetAddress()}, Lecture Event, Speaker {_speaker}, Capacity {_capacity}";
    }

    public override string ShortDescription()
    {
        return $"Lecture Event {GetTitle()} {_date.ToString("M/d/yyyy")}";
    }

}