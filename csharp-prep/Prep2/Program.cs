using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduce your percentage grade: ");
        string userInput = Console.ReadLine();
        int gradePer = int.Parse(userInput);
        string letter;

        if (gradePer >= 90)
        {
            letter = "A"; 
        }
        else if (gradePer >= 80)
        {
            letter = "B";
        }
        else if (gradePer >= 70)
        {
            letter = "C";
        }
        else if(gradePer >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";  
        }

        //Printing the grade in letter
        Console.WriteLine($"Your grade is {letter}");

        //Now I'll add conditionals to determine
        //If the user passed or not

        if (gradePer >= 70)
        {
            Console.WriteLine("Congratulation you passed the course!!");
        }
        else
        {
            Console.WriteLine("Sorry you haven't approved, although if you try harder you'll do it next time!!");
        }

    }
}