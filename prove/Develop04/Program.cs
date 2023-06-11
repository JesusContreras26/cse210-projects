using System;

//class program 
class Program
{
    static void Main(string[] args)
    {   
        //Here is where the menu will displayed and all the calls to the activities
        //depending in which activity the user choose I put everything inside of a loop
        //to be able to control the repetion of the program
        int _option;
        do{

            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity"); 
            Console.WriteLine("3. Start listing activity"); 
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");

            //This conditional will check if the user enter a letter instead of a number
            //If that the case it'll displayed a message and the program will start again
            if (!int.TryParse(Console.ReadLine(), out _option)){
                Console.Clear();
                Console.WriteLine("Introduce a valid option!!");
                continue;
            }
            Activity _newActivity = null;

            //Switch to create the acitivity depending of the option
            //making this in this way, allows me to create only one variable
            //that can contain any kind of activity and I'll be able to call
            //all the functionality of those classes outside of the switch just
            //once
            switch(_option){
                case 1:
                    _newActivity = new BreathingActivity();
                    break;
                case 2:
                    _newActivity = new ReflectionActivity();
                    break;
                case 3:
                    _newActivity = new ListingActivity();
                    break;
                case 4:
                    Console.WriteLine("See you");
                    Environment.Exit(0);
                    break;
            }

            //checking if the user introduce a value between 1 to 3
            //This will allow the program to continue if the user types 4
            //and if the the user introduce a number higher than the options
            //I'll display a message and run the program again
            if(_option <= 3 && _option > 0){
                Console.Clear();
                _newActivity.DisplayStartMessage();
                _newActivity.Run();
                _newActivity.DisplayEndMessage();
            }
            else if(_option > 4){
                Console.Clear();
                Console.WriteLine("Introduce a valid option!!");
            }


        }while(_option != 4);


    }
}