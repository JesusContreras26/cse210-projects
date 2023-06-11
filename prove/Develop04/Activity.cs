using System;

//Class activity this will be my main class, the class that will be use for the
//other classes to do their job
public abstract class Activity{

//all variables that all classes have in common
    private string _description;
    private int _time;
    private string [] _animation = {"|","/","-","\\","|","/","-","\\"};
    private string _name;
    private DateTime _startTime;
    private DateTime _endTime;
    protected Random _rand = new Random();

//Consructor for activity class
     public Activity(string name, string description){
        _name = name;
        _description = description;
     }

//getter for time variable
     public int GetTime(){
        return _time;
     }

//method for displaying the starting message of each activity, also this class will ask
//for the time the user wants this activity to long
     public void DisplayStartMessage(){
        Console.WriteLine($"Welcome to {_name} Activity");
        Console.WriteLine($"{_description}");
        Console.Write("How long, in seconds, would you like for your sesion? ");
        _time = int.Parse(Console.ReadLine());
        Console.Clear();
    }

//abastract method that'll be override by the other classes, this will be the main method
//of all the classes to run their functionality
    public abstract void Run();

//Function for animation, this function will be used to display a spinner for an ammount of time
//I stablished a default value if the user call it with out sending an argument to this parameter
//this allows me to control the time the spinner will long
    public void DispAnimation(int time = 5){
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(time);
        int _counter = 0;
        while(DateTime.Now < _endTime){
            Console.Write(_animation[_counter]);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            _counter++;

            if(_counter >= _animation.Count()){
                _counter = 0;
            }

        }
    }

//method for displaying the end message when the activity is over
    public void DisplayEndMessage(){
        Console.WriteLine("Well done!!");
        DispAnimation();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_time} seconds of {_name} Activity");
        DispAnimation();
        Console.Clear();
    }


}