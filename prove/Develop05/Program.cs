using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop05 World!");
        // As an extra feature I added opportunity to add goal with notification so when  user load the goals and this type of goal created 
        //he will see notification on the screen 
        //this type of goal also gives user to choose how many days he would like to work onthis goal
        //so when he list the goals he will see how many days are completed and how many days ar left.
        //Also I iproved that part of code when user adds event , if goal already comleted , he won't be able to add event assotiated with this
        //goal. Also I created method misses points so user will loose some points if he missed a day .
        GoalMahager goalManager = new GoalMahager();
        goalManager.Start();
    }
}