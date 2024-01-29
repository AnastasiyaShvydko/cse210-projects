using System;

class Program
{
    static void Main(string[] args)
    {
       // Console.WriteLine("Hello Learning04 World!");

        Assignment assignment1 = new Assignment("Brenet Andrew", "Miltiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Anna V", "Subtraction", "Section 9-12","Problems 5-9");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());


        WritingAssignment assignment3 = new WritingAssignment("Julia Ley", "Essay", "My favorite day");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInfromation());
    }
}