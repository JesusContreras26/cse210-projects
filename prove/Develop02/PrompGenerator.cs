using System;
using System.Collections.Generic;

//PrompGenerator class will use to generate a random prompt from a list of prompts
public class PrompGenerator{

    //Declaring variables I'll use in this class
    public List<string> _prompts = new List<string>(){
        "What was I more enjoy today?",
        "Who is a person to which I should talk?",
        "For what should I be grateful today?",
        "Did something special happened today? what?",
        "What act of kindness did I do today?",
        "How did I see my Heavenly Father act on my life today?",
        "How was my work today? is there something to improve?"
    };

    //Create a random object variable that will take the random prompt from the list
    public Random _randomGenerator = new Random();

    //_randomPrompt will catch the random prompt
    public string _randomPrompt;

    //PromptDis method will save the random prompt, display it to the user and then return it
    //whenever it has been called
    public string PromptDis()
    {
        _randomPrompt = _prompts[_randomGenerator.Next(0, _prompts.Count)];
        Console.WriteLine($"{_randomPrompt}");
        return _randomPrompt;
    }
}