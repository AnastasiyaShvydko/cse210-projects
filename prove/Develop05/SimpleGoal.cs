public class SimpleGoal:Goal{
Boolean _isComplete = false;

public SimpleGoal(string name, string description,int points, int pointsLoose, bool isComlete):base(name, description, points , pointsLoose){
    _isComplete = isComlete;

}

public override  void  RecordEvent(){
    if(_isComplete == true){
        Console.WriteLine("Goal already complete!");
        SetPoints(0);
        }
    else{
        Console.WriteLine($"Congadualtions you earned {GetPoints()}!");
        IsComplete();
   }


}
public override  void RecordMissedEvent(){
    if(_isComplete == true){
        Console.WriteLine("Goal already complete!");
   }
    else{
        int pointsLoose = GetPointsLoose();
        SubctractPoints(pointsLoose);
        }
    }
public override  bool  IsComplete(){
    _isComplete = true;
    return _isComplete;
}


public override  string  GetStringRepresentation(){
    string name = GetName();
    string description = GetDescription();
    int points = GetPoints();
    int pointsLoose = GetPointsLoose();

    string goalStringRepresentation = $"SimpleGoal: {name}, {description}, {points},{pointsLoose}, {_isComplete}";
    return goalStringRepresentation;
}
public override  string  GetDetailsString(){
    string name = GetName();
    string description = GetDescription();

    string goalString;
    if(_isComplete == true){
        goalString = $"[X] Simple Goal: {name} ({description})"; 
    }
    else{
        goalString = $"[ ] Simple Goal: {name} ({description}) ";
    }
    
    return goalString;
}

}