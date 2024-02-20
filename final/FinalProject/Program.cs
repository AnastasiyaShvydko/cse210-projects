using System;
//This app gives user opportunity create and add recipes , save theminto recipe 
//book and than load them back. While user display the recipe it gives 
//information  such as title, description, ingredient list and calories per serves.
//*Note: Calories are calculated by getting info from CaloriesTable class, 
//I added just a few items of ingredients for test, if user entered ingredients
//which are not in the CaloriesTable Calories will be calculated as 0;
//Another function is to calculate BMR .
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello FinalProject World!");
        Main newProgram = new Main();
        newProgram.Start();
    }
}