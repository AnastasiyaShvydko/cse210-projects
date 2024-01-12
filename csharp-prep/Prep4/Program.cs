using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;


class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine(" Enter a list of numbers, type 0 when finished.");
        Console.WriteLine("Enter nmber");
        int number = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
        //int[] numbers; 
        while (number !=0){
            numbers.Add(number);
            Console.Write("Enter nmber");  
            number = int.Parse(Console.ReadLine());    
        }
        
    //     int sum = 0;
    int minPositiv = numbers.Max();
       foreach (int n in numbers)
            {
                if (n < minPositiv && n > 0) {
                    minPositiv  = n;
                   
                }
    // //             sum += n;
    // //             //Console.Write(n);
    // //  
           }
           int sum = numbers.Sum();
           int listLenght = numbers.Count;
           double averg = (double) sum/listLenght;
        Console.WriteLine($"The largest number is : {numbers.Max()}");
        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {averg}");
        Console.WriteLine($"Minimum Positive: {minPositiv}");
        numbers.Sort();
foreach (int num in numbers){
        Console.WriteLine(num);}

    }

}