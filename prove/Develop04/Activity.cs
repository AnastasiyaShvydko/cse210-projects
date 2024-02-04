using System.Drawing;
using System.Reflection.Emit;

public class Activity{
    string _title = "";
    string _description = "";

    List<string> myAnimationList = new List<string>();
       
    
    public Activity(string title, string description){
    _title = title;
    _description = description;

    }

   

   


    public string ShowGreet(){
        return $"Whelcome to the {_title}!\n \n {_description} \n";
    }

    public void GetReadyMsg(){
        Console.Clear();
        Console.WriteLine("Get ready...");
    }


    public void AnimationCount(int sec){
        myAnimationList.Add("|");
        myAnimationList.Add("/");
        myAnimationList.Add("-");
        myAnimationList.Add("\\");
        myAnimationList.Add("|");
        myAnimationList.Add("/");
        myAnimationList.Add("-");
        myAnimationList.Add("\\");
     
      
        

        Animation getReadyAnimation = new Animation(myAnimationList);


       
        getReadyAnimation.AnimationCountFunc(sec);

   }

    public void NumbersCount(int sec){
        Animation countAnimation = new Animation();
        countAnimation.NumbersCountFunc(sec);



   }

    public void WellDoneMsg(){
        Console.WriteLine("\nWell Done!");
    }

    public void ReportMsg(string time){
        Console.WriteLine($"You have complited another {time} seconds of {_title}");
    }
}