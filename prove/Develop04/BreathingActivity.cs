using System;

//Breathing class, this class will not have variables outside of the run method
public class BreathingActivity: Activity{

    //Constructor for breathing activity
    public BreathingActivity(): base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."){

    }

    //overriding the run method with the functionality of this function
    public override void Run()
    {
        //Message to tell the user to get prepared also here I'll call my animation too
        Console.WriteLine("Get ready...");
        DispAnimation();
        Console.WriteLine();
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        //Start the breathing exercice making use of datetime to control how longer it will be
        while((DateTime.Now - startTime).TotalSeconds < GetTime()){

            Console.Write("Breathe in...");
            for(int i = 5; i >= 1; i--){
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();

            Console.Write("Breathe out...");
            for(int i = 5; i >= 1; i--){
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}