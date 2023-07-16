using System;

public class Receptions: Event{

    private string _email;

    public Receptions(string title, string description, int year, int month, int day, int time, string street, string city, string state, string country,
    string email): base(title, description, year, month, day, time, street, city, state, country)
    {
        _email = email;
    }

    public override string FullDetails()
    {
        return $"{GetTitle()}, {GetDescription()}, Date: {_date.ToString("M/d/yyyy")} Duration: {GetTime()} minutes, Address: {_address.GetAddress()}, Receptions Event, Reservations at: {_email}";
    }

    public override string ShortDescription()
    {
        return $"Receptions Event {GetTitle()} {_date.ToString("M/d/yyyy")}";
    }

}