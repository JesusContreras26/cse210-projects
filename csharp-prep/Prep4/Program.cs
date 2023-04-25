using System;

class Program
{
    static void Main(string[] args)
    {
        //Declaring variables and a message
        List<int> numbers = new List<int>();
        int numberInp = -1;
        double average = 0;
        int highestNumber = 0;
        double total = 0;
        int lowerNumber = 999999999;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //do while loop to ask the user for numbers that will be add to the list 
        //until the user types in 0
        do{

            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            numberInp = int.Parse(input);

            //conditional to add the numbers to the list without including 0 
            if (numberInp != 0) {
                numbers.Add(numberInp);
            }

        }while(numberInp != 0);

        //foreach loop to get total sum of list's numbers
        //also I used this loop to get the higher and lower number of the list 
        foreach (int number in numbers){
            total += number;
            if (number > highestNumber){
                highestNumber = number;
            }
            if (number < lowerNumber && number > 0){
                lowerNumber = number;

            }
        }

        //calculating the average
        average = total/numbers.Count;

        //Sorting the list in ascending way
        numbers.Sort();

        //Displaying the messages to the console
        Console.WriteLine($"The sum is {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest is: {highestNumber}");
        Console.WriteLine($"The smallest positive number is: {lowerNumber}");
        
        //Displaying all the list in ascending way 
        foreach (int number in numbers){
            Console.WriteLine(number);
        }
    }
}