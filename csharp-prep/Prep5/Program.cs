using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello Prep5 World!");
     DisplayWelcome();
     string name = PromptUserName();
     int number = PromptUserNumber(); 
     double sqrtNumber = SquareNumber(number);
     DisplayResult(name,sqrtNumber);
    }

     static void DisplayWelcome()
            {
                Console.WriteLine("Welcome to the Programm!");
            }
    
   static string PromptUserName()
            {
                Console.WriteLine("Please, enter your name:");
                string userName = Console.ReadLine();
                return userName;
            }

    static int PromptUserNumber()
            {
                Console.WriteLine("Please, enter your favorite number:");
                int userNumber = int.Parse(Console.ReadLine());
                return userNumber;
                
            }
    static double SquareNumber(int number)
            { double sqrtNumber = number * number;
              return sqrtNumber;
            }
    static void DisplayResult( string name,double sqrtNumber) 
            {
            Console.WriteLine($"{name},the square of your number is {sqrtNumber}");
            }     


}