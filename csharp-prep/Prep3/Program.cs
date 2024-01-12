using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
        //Console.WriteLine("What is your magic number?");
        //int magicNumber = int.Parse(Console.ReadLine());
        //Console.WriteLine("Do you want to play?");
        //string userResponse = Console.ReadLine();
        string userResponse = "yes";
        while (userResponse == "yes"){
            Random randomGenerator = new Random();
            int magicNumber =  randomGenerator.Next(1, 100);
            Console.WriteLine("What is your guess?");
            string response = Console.ReadLine();
            int responseInt = int.Parse(response);
            int guessNumber = 0;
        
            while (responseInt != magicNumber){
                
                if(responseInt > magicNumber){
                    Console.WriteLine("Lower");
                    Console.WriteLine("What is your guess?");
                    responseInt = int.Parse(Console.ReadLine());
                    guessNumber ++;
                }
                else if(responseInt < magicNumber) { 
                    Console.WriteLine("Higher");
                    Console.WriteLine("What is your guess?");
                    responseInt = int.Parse(Console.ReadLine());
                    guessNumber ++;
                }

            

            }

        
            Console.WriteLine($"You guessed it with {guessNumber} attempts!");
            Console.WriteLine("Do you want to play?");
            userResponse = Console.ReadLine();
    

        }

         Console.WriteLine("It was good to play with you!");
    }
}