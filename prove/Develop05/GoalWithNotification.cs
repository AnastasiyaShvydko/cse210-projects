public class GoalWithNotification:Goal{
int _pointsLoose;
int _days;

int _bonus;

int _daysComplete;

int _daysMissed;




public GoalWithNotification(string name, string description,int points,int pointsLoose, int bonus, int days,int daysComplete = 0,int daysMissed  = 0):base(name, description, points, pointsLoose){
    _days = days;
    _bonus = bonus;
    _pointsLoose = pointsLoose;
    _daysComplete = daysComplete;
    _daysMissed = daysMissed;
}

public override  void  RecordEvent(){
    if(_days!= 0){
        _days -= 1;
        _daysComplete +=1;
        Console.WriteLine($"Congadualtions you earned {GetPoints()}!");
        //int points = GetPoints();
        //SetPoints(points);
        if(_days == 0){
            IsComplete();
            SetPoints(_bonus);
        }
    }
    else{
        Console.WriteLine("Goal already complete!");
        SetPoints(0);
    }



}
public override  void RecordMissedEvent(){
    if(_days != 0){
        _daysMissed +=1;
        SubctractPoints(_pointsLoose);}
    else{
        Console.WriteLine("Goal already complete!");
    }
    
    
}
public override  bool  IsComplete(){
    return true;
}


public override  string  GetStringRepresentation(){
    string name = GetName();
    string description = GetDescription();
    int points = GetPoints();
    

    string goalStringRepresentation = $"GoalWithNotification: {name}, {description}, {points},{_bonus},{_pointsLoose},{_days},{_daysComplete},{_daysMissed}";
    return goalStringRepresentation;
}
public override  string  GetDetailsString(){
    string name = GetName();
    string description = GetDescription();
    string daysLeftString = "";
    string daysCompleteString = "";
    
    for (int i = 1; i <=_daysComplete; i++){
        string brakets = "[X],";
        daysCompleteString = daysCompleteString + brakets;
    }
    


    for (int i = 1; i <=_days; i++){
        string brakets = "[ ],";
        daysLeftString = daysLeftString + brakets;
    }

    string goalString;
    // if(_isComplete == true){
    //     goalString = $"[X] Simple Goal: {name} ({description})"; 
    // }
    // else{
    //     goalString = $"[ ] Simple Goal: {name} ({description}) ";
    // }

    if(_days == 0 ){
        goalString = $" [V] Goal with Notification: {name} ({description})";
        }
    else{
        goalString = $"You missed : {_daysMissed} days!\n Days completed:{_daysComplete}{daysCompleteString} \n Days left:{_days} {daysLeftString} \n Goal with Notification: {name} ({description})";
        }
    
    return goalString;
}


}