using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> _events = new List<Event>();

        Lecture _lecture = new Lecture("Enrich Literacy", "Come and join us in our fabulous lecture event for all the ages", 2023, 07, 16, 240, "18 Street", "San Cristobal",
        "Tachira", "Venezuela", "Albeiro Vivas", 40);

        _events.Add(_lecture);

        Receptions _reception = new Receptions("Cheese Tasting Madrid L'Amélie", "We will make a cheese tasting of our best cheeses, you'll have an unforgettable experience, reserve now!",
        2023, 10, 28, 120, "5 Avenue", "Madrid", "Madrid", "Spain", "lamelie@gmail.com");

        _events.Add(_reception);

        Outdoors _outdoor = new Outdoors("Traki Anniversary 20th", "Traki will celebrate its anniversary 20th in the Federation Park, we will have great food and entertainment for everyone",
        2023, 11, 15, 240, "5 Street", "Caracas", "Federal District", "Venezuela", "78F");

        _events.Add(_outdoor);

        foreach (Event _event in _events)
        {
           Console.WriteLine($"- {_event.StandardDetails()}");
           Console.WriteLine($"- {_event.FullDetails()}");
           Console.WriteLine($"- {_event.ShortDescription()}");

           Console.WriteLine();
        }
    }
}