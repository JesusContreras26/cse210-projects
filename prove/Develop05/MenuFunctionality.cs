using System;

//This class will control all the functionality of the menu making use
//of the classes goals
public class MenuFunctionality{
    //list of object goal to save all the different types of goals inside of it
    private List<Goal> _goals = new List<Goal>();
    //option and points variable declaration, points will have the total points earned
    private int _option = 0;
    private int _points = 0;

    public int GetPoints(){
        return _points;
    }

    //This behaviour will create the goals it was a pretty difficult to figure out
    //how to not repeat code in the cases I have to use constructors and save the information
    //asked in variables to send them as argument through the parameters in the constructors
    //one team member recommended this method to me
    public void CreateNewGoal(){
        do{
            Console.WriteLine("The Types of Goals are: ");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. CheckList Goal");
            Console.Write("Which type of goal would you like to create? ");
            _option = int.Parse(Console.ReadLine());

            Goal _goal = null;


            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points =  int.Parse(Console.ReadLine());

            switch(_option){
                case 1:
                    _goal = new SimpleGoal(name, description, points, false);
                    break;
                case 2:
                    _goal = new EternalGoal(name, description, points);
                    break;
                case 3:
                    Console.Write("How many times does this goal need to be acomplished for a bonus? ");
                    int _timesToComplete = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for acomplishing it that many times? ");
                    int _bonusPoints = int.Parse(Console.ReadLine());
                    _goal = new CheckListGoal(_timesToComplete, _bonusPoints, name, description, points);
                   break;
                default:
                    Console.WriteLine("Introduce a valid option! ");
                    _option = 0;
                    break;
            }

            _goals.Add(_goal);
            
        }while(_option == 0);

    }

    //ListGoals method to display the goals to the user and its status if it's completed or not
    //by checking if a goal is CheckListGoal allows me to make use of its methods I used a ternary operator to do it
    public void ListGoals(){
        int counter = 0;
        foreach(Goal goal in _goals){
            counter+=1;
            string checkIfDone = goal.IsCompleted() ? "[x]" : "[ ]";
            string _timesCompleted = goal is CheckListGoal ? $"--- Currently Completed: {((CheckListGoal)goal).GetTimesCompleted()}/{((CheckListGoal)goal).GetTimesToComplete()}" : "";
            Console.WriteLine($"{counter}. {checkIfDone} {goal.GetName()} ({goal.GetDescription()}) {_timesCompleted}");
        }
    }

    //SaveGoals method will be used to save the goals in a external file in a especial way to later load them if its neccesary
    //making use of conditional to see what kind of goal is
    public void SaveGoals(string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            outputFile.WriteLine(_points);
            foreach(Goal goal in _goals){
                if(goal is SimpleGoal){
                    if(goal.IsCompleted() == true){
                        outputFile.WriteLine($"Simple:{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},True");
                    }else{
                        outputFile.WriteLine($"Simple:{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},False");
                    }
                } else if(goal is EternalGoal){
                    outputFile.WriteLine($"Eternal:{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()}");
                } else if(goal is CheckListGoal){
                    outputFile.WriteLine($"CheckList:{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{((CheckListGoal)goal).GetBonusPoints()},{((CheckListGoal)goal).GetTimesToComplete()},{((CheckListGoal)goal).GetTimesCompleted()}");
                }
            }
        }

    }

    //LoadFile will load the file asked and save all the information inside of it into goals and its attributes 
    public void LoadFile(string fileName){
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _goals.Clear();
        int counter = 0;
        foreach(string line in lines){
            if(counter == 0){
                _points = int.Parse(line);
            }else{
                Goal _goal = null;
                string[] getType = line.Split(":");
                string[] getInfo = getType[1].Split(",");
                if(getType[0] == "Simple"){
                    bool _check = getInfo[3] == "True" ? true : false;
                    _goal = new SimpleGoal(getInfo[0], getInfo[1], int.Parse(getInfo[2]), _check);
                }else if(getType[0] == "Eternal"){
                    _goal = new EternalGoal(getInfo[0], getInfo[1], int.Parse(getInfo[2]));
                }else{  
                    _goal = new CheckListGoal(int.Parse(getInfo[4]), int.Parse(getInfo[3]), getInfo[0], getInfo[1], int.Parse(getInfo[2]));
                    ((CheckListGoal)_goal).SetTimesCompleted(int.Parse(getInfo[5]));
                }
                _goals.Add(_goal);
            }
            counter++;

        }   
    }

    //Record an event if the user make a change to the goals, if they finish one of them,
    //how many points they earned, likewise add those points to the total points score
    //and checked if a goal has been completed, if a goal has been completed it won't add
    //points anymore or display a message of congratulations to the user.
    public void RecordAnEvent(){
        int counter = 0;
        Console.WriteLine("The goals are: ");
        foreach(Goal _goal in _goals){
            counter++;
            Console.WriteLine($"{counter}. {_goal.GetName()}");
        }
        Console.Write("Which goal did you accomplish? ");
        int _decision = int.Parse(Console.ReadLine());
        if(_goals[_decision - 1].IsCompleted() == true){
            Console.WriteLine("This goal has been completed already");
            Console.WriteLine();
        }else{
            int _pointsGained =  _goals[_decision - 1].RecordEvent();
            Console.WriteLine($"Congratulations! You have earned {_pointsGained} points!");
            _points += _pointsGained;
            Console.WriteLine();
        }
        }



}