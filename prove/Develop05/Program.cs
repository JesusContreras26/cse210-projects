using System;

class Program
{
    static void Main(string[] args)
    {
        //Starting the main class program, this class will display the menu to the user
        //It's inside of a loop to control how many times it'll run;
        string fileName;
        //I decided to make a class for the functionality of the menu, this object is to make
        //is to make use of that class
        MenuFunctionality menu = new MenuFunctionality();
        int option = 0;
        do{
            Console.WriteLine($"You have {menu.GetPoints()} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            //switch to control what option the user choose
            //each case will call its functionality in the menufunctionality class
            switch(option){
            case 1:
                menu.CreateNewGoal();
                break;
            case 2:
                menu.ListGoals();
                break;
            case 3:
                Console.Write("What is the filename for the goal file? ");
                fileName = Console.ReadLine();
                menu.SaveGoals(fileName);
                break;
            case 4:
                Console.Write("What is the filename for the goal file? ");
                fileName = Console.ReadLine();
                menu.LoadFile(fileName);
                break;
            case 5:
                menu.RecordAnEvent();
                break;
            case 6:
                Console.WriteLine("Thank you for use our program");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Introduce a valid option! ");
                break;
            }

        }while(option != 6);
    }
}