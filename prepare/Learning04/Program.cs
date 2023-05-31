using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assigment1 = new Assignment("Jesus Contreras", "Division");

        Console.WriteLine($"{assigment1.GetSummary()}");
        Console.WriteLine();

        MathAssigment assigment2 = new MathAssigment("Jesus Contreras", "Division", "7.3", "8-19");
        Console.WriteLine($"{assigment2.GetSummary()}");
        Console.WriteLine($"{assigment2.GetHomeWorkList()}");
        Console.WriteLine();

        WritingAssigment assigment3 = new WritingAssigment("Daniela Contreras", "European History", "The Causes of World War II");
        Console.WriteLine($"{assigment3.GetSummary()}");
        Console.WriteLine($"{assigment3.GetWrittingInformation()}");
    }
}