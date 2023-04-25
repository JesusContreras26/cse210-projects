using System;

class Program
{ 
    static void Main(string[] args)
    {   
        //I declared first my variable that will control
        //the do while loop
        String contPlaying = "";
        do{
            //I have to create the variables that I'll use
            //inside of the do while and while loops
            //also this will restart the variables if
            //the user wants to play again
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,11);
            int inpNumber = 0;
            string inputTwo;
            int tries = 0;

            //loop that will be the one that control
            //the game itself
            while (magicNumber!= inpNumber)
            {   
                tries++;
                Console.Write("What is your guess? ");
                inputTwo = Console.ReadLine();
                inpNumber = int.Parse(inputTwo);

                if (inpNumber > magicNumber){
                    Console.WriteLine("Lower");
                }else if(inpNumber < magicNumber){
                    Console.WriteLine("Higher");
                }else{
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It tooked you {tries} tries");
                    Console.Write("Do you want to continue? ");
                    contPlaying =  Console.ReadLine();
                }


            }
        } while(contPlaying == "yes");
    }
}