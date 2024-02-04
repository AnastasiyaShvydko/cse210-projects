using System;
using System.Media;



class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");
        List<String> newPromptList = new List<string>();
        newPromptList.Add("Think of a time when you stood up for someone else.");
        newPromptList.Add("Think of a time when you did something really difficult.");
        newPromptList.Add("Think of a time when you helped someone in need.");
        newPromptList.Add("Think of a time when you did something truly selfless.");

        List<String> newQuestionList = new List<string>();
        newQuestionList.Add("Why was this experience meaningful to you?");
        newQuestionList.Add("Have you ever done anything like this before?");
        newQuestionList.Add("How did you get started?");
        newQuestionList.Add("How did you feel when it was complete?");
        newQuestionList.Add("What made this time different than other times when you were not as successful?");
        newQuestionList.Add("What is your favorite thing about this experience?");


        List<String> listingQuestionList = new List<string>();
        listingQuestionList.Add("Who are people that you appreciate?");
        listingQuestionList.Add("What are personal strengths of yours?");
        listingQuestionList.Add("Who are people that you have helped this week?");
        listingQuestionList.Add("When have you felt the Holy Ghost this month?");
        listingQuestionList.Add("Who are some of your personal heroes?");




        string answer = "";
        while (answer != "5"){
            Console.Clear();
            Console.WriteLine("\n Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Start music activity");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Select a choice from the menu");
            answer = Console.ReadLine();
        
            if(answer == "1"){
                BreathingActivity breathActivity = new BreathingActivity("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Console.WriteLine(breathActivity.ShowGreet());
                Console.Write("How long, in seconds, would you like for your session ");
                string sessionLast = Console.ReadLine();
                breathActivity.GetReadyMsg();
                breathActivity.AnimationCount(10);
                breathActivity.CoreActivity(Convert.ToInt32(sessionLast));
                breathActivity.WellDoneMsg();
                breathActivity.AnimationCount(10);
                breathActivity.ReportMsg(sessionLast);
                breathActivity.AnimationCount(10);



            }
            if(answer == "2"){
                ReflectingActivity reflectActivity = new ReflectingActivity("Reflecting Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life", newPromptList, newQuestionList);
                Console.WriteLine(reflectActivity.ShowGreet());
                Console.Write("How long, in seconds, would you like for your session ");
                string sessionLast = Console.ReadLine();
                reflectActivity.GetReadyMsg();
                reflectActivity.AnimationCount(10);
                reflectActivity.CoreActivity(Convert.ToInt32(sessionLast));
                reflectActivity.WellDoneMsg();
                reflectActivity.AnimationCount(10);
                reflectActivity.ReportMsg(sessionLast);
                reflectActivity.AnimationCount(10);
            }

            if(answer == "3"){
               ListingActivity listActivity = new ListingActivity("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", listingQuestionList);
                Console.WriteLine(listActivity.ShowGreet());
                Console.Write("How long, in seconds, would you like for your session ");
                string sessionLast = Console.ReadLine();
                listActivity.GetReadyMsg();
                listActivity.AnimationCount(10);
                listActivity.CoreActivity(Convert.ToInt32(sessionLast));
                listActivity.WellDoneMsg();
                listActivity.AnimationCount(10);
                listActivity.ReportMsg(sessionLast);
                listActivity.AnimationCount(10);

              
            }

              if(answer == "4"){
                MusicActivity musicActivity = new MusicActivity("Music Activity","This activity will help you to relax and enjoy beautiful music .");
                Console.WriteLine(musicActivity.ShowGreet());
                Console.Write("How long, in seconds, would you like for your session ");
                string sessionLast = Console.ReadLine();
                musicActivity.GetReadyMsg();
                musicActivity.AnimationCount(10);
                musicActivity.CoreActivity(Convert.ToInt32(sessionLast));
                musicActivity.WellDoneMsg();
                musicActivity.AnimationCount(10);
                musicActivity.ReportMsg(sessionLast);
                musicActivity.AnimationCount(10);

              
            }

        }

    }
}