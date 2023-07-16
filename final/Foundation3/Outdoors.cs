using System;

public class Outdoors: Event{

    private string _weather;

    public Outdoors(string title, string description, int year, int month, int day, int time, string street, string city, string state, string country,
    string weather): base(title, description, year, month, day, time, street, city, state, country)
    {
        _weather = weather;
    }

    public override string FullDetails()
    {
        return $"{GetTitle()}, {GetDescription()}, Date: {_date.ToString("M/d/yyyy")} Duration: {GetTime()} minutes, Address: {_address.GetAddress()}, Outdoors Event, Possible Weather: {_weather}";
    }

    public override string ShortDescription()
    {
        return $"Outdoors Event {GetTitle()} {_date.ToString("M/d/yyyy")}";
    }

}