using System;

class Program
{
    static void Main(string[] args)
    {
        //Declaring variables with the values returns for the functions,
        //likewise calling the functions that don't return anything
        DisplayWelcome();
        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int numberSquared = SquareNumber(favoriteNumber);

        DisplayResult(name, numberSquared);

        //Functions
        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName(){
            Console.Write("Please enter your name: ");
            string input = Console.ReadLine();
            return input;
        }

        static int PromptUserNumber(){
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();
            int favoriteNumber = int.Parse(input);
            return favoriteNumber;
        }

        static int SquareNumber(int number){
            int numberSquared = number * number;
            return numberSquared;
        }

        static void DisplayResult(string name, int numberSquared){
            Console.WriteLine($"{name}, the square of your number is {numberSquared}");
        }
    }
}