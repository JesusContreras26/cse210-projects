using System;

class Program
{
    static void Main(string[] args)
    {   
        //First I declare the variables that'll use in my main class
        //I'll create too one object of class journal, that will be 
        //the object which one I'll use and it's connected to the other
        //classes 
        int userOption = 0;
        string input;
        string fileName;
        Journal journal = new Journal();

        //While loop to control my menu and keep it running until
        //the user types 5
        while(userOption != 5){

            //Displaying the whole menu to the user
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            //Catch user option in a variable and then parse it to an int
            //parsing could be ommited but I feel more comfortable working
            //with numbers
            input = Console.ReadLine();

            userOption = int.Parse(input);

            //if conditionals to do the different things that the menu
            //offers to the user.
            if (userOption == 1){
                journal.AddEntries();
                
            }
            else if (userOption == 2){
                journal.EntriesDisp();
            }

            else if (userOption == 3){
                Console.Write("Introduce a file name: ");
                fileName = Console.ReadLine();
                journal.Save(fileName);
                }

            else if(userOption == 4){
                Journal journal2 = new Journal();
                Console.Write("Introduce a file name: ");
                fileName = Console.ReadLine();
                journal.Load(fileName);
            }

            


        }

    }
}