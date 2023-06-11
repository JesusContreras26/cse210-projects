using System;

//Reflection class
public class ReflectionActivity: Activity{
    //Two lists one for all the prompts that can be choosed for the user and the other one for questions to that prompt that'll be selected

    private List<string> _prompts = new List<string>{"---Think of a time when you stood up for someone else---", "---Think of a time when you did something really difficult---",
                                 "---Think of a time when you did somethig selfless---", "---Think of a time when you helped someone in need---"};
    private List<string>_questions = new List<string>{"> Why was this experience meaningful to you?", "> Have you ever done anything like this before?", "> How did you get started?",
                                  "> How did you feel when it was complete?", "> What made this time different than other times when you were not as successful?",
                                  "> What is your favorite thing about this experience?", "> What could you learn from this experience that applies other situations",
                                  "> What did you learn about yourself through this experience?", "> How can you keep this experience in mind n the future"};

    //Constructor of the reflection activity
    public ReflectionActivity(): base("Reflection", @"This activity will help you reflect on times in your life when you have shown strength and resilience. 
This will help you recognize the power you have and how you can use it in other aspects of your life."){

    }

    //Overriding run method with the functionality of this class
    public override void Run()
    {
        //This function will show a random prompt to the user making use of a random object
        //next it'll show questions to that random prompt likewise using random object
        //the questions showed will be erased from the list so they'll not be displayed twice
        //at the beginning it'll display the prompt and let the user think, when he/she is ready
        //they can press enter to run the activity
        Console.WriteLine("Get ready");
        DispAnimation();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        int _randomNumber = _rand.Next(0, _prompts.Count - 1);

        Console.WriteLine($"{_prompts[_randomNumber]}");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine($"Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        for(int i = 5; i >= 1; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Clear();

        DateTime startTime = DateTime.Now;
        while((DateTime.Now - startTime).TotalSeconds < GetTime()){
            _randomNumber = _rand.Next(0, _questions.Count - 1);
            Console.Write($"{_questions[_randomNumber]} ");
            DispAnimation(15);
            _questions.RemoveAt(_randomNumber);
            Console.WriteLine();

        }
        Console.WriteLine();

    }
}