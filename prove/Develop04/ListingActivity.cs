using System;

//Listing activity class
public class ListingActivity: Activity{

    //A list of prompts to select one and show it to the user
    private List<string> _prompts = new List<string>{"--- Who are people that you appreciate? ---", "--- What are personal strengths of yours? ---",
                                                     "--- Who are people that you have helped this week? ---", "--- When have you felt the Holy Ghost this month ---",
                                                     "--- Who are some of your personal heroes? ---"};

    //Constructor for the listing activity
    public ListingActivity(): base("Listing", @"This activity will help you reflect on the good things in your life by having you list as many
things as you can in a certain area."){

    }

    //Overrinding run method with this function functionality
    public override void Run()
    {
        //Listing activity will select a random prompt making use of a random prompt
        //then the user will type as many things as they can until the program stop
        //at the time that they stablished
        Console.WriteLine("Get ready...");
        DispAnimation();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        int _randomNumber = _rand.Next(0, _prompts.Count - 1);
        Console.WriteLine($"{_prompts[_randomNumber]}");
        Console.WriteLine($"You may begin in: ");
        for(int i = 5; i >= 1; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write($"\b \b");
        }
        
        DateTime _startTime = DateTime.Now;
        while((DateTime.Now - _startTime).TotalSeconds < GetTime()){
            Console.Write("> ");
            Console.ReadLine();
        }
        Console.WriteLine();
    }
}