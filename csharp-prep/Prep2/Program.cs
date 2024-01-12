using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade?");
        int grade = int.Parse(Console.ReadLine());
        int lastDigit = grade % 10;
        string letter;
                if (grade >= 90 && lastDigit < 3){
                    letter = "A-";
            Console.WriteLine($"Your letter grade is {letter}");
        }
         else if (grade >= 90 ){
            letter = "A";
              Console.WriteLine($"Your letter grade is {letter}");
        }
         else if(grade >= 80 && lastDigit >= 7){
            letter = "B+";
              Console.WriteLine($"Your letter grade is {letter}");
        
        }
         else if(grade >= 80 && lastDigit < 3){
            letter = "B-";
              Console.WriteLine($"Your letter grade is {letter}");
        
        }
         else if(grade >= 80 ){
            letter = "B";
              Console.WriteLine($"Your letter grade is {letter}");
        
        }
      else if(grade >= 70 && lastDigit >= 7){
            letter = "C+";
              Console.WriteLine($"Your letter grade is {letter}");
        
        }
         else if(grade >= 70 && lastDigit < 3){
            letter = "C-";
              Console.WriteLine($"Your letter grade is {letter}");
        
        }
         else if(grade >= 70 ){
            letter = "C";
              Console.WriteLine($"Your letter grade is {letter}");
        
        }
        else if(grade >= 60 && lastDigit >= 7){
            letter = "D+";
              Console.WriteLine($"Your letter grade is {letter}");
        
        }
         else if(grade >= 60 && lastDigit < 3){
            letter = "D-";
              Console.WriteLine($"Your letter grade is {letter}");
        
        }
         else if(grade >= 60 ){
            letter = "D";
              Console.WriteLine($"Your letter grade is {letter}");
        
        }
        else{
            letter = "F";
          Console.WriteLine($"Your letter grade is {letter}");
        }
        if(grade >= 70){
            Console.WriteLine("Congrats!");

        }
        else{
              Console.WriteLine("Sorry, you didn't pass the class");
        }
    }
}