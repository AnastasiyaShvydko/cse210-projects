public class ChecklistGoal:Goal{
    int _amountComplete;
    int _bonus;
    int _target;

    int _pointsLoose;

    public ChecklistGoal(string name, string description,int points,int pointsLoose, int bonus, int target, int amountComplete = 0):base(name, description, points , pointsLoose){
        _bonus = bonus;
        _target = target;
        _amountComplete = amountComplete;
        _pointsLoose = pointsLoose;

    }

    public override  void  RecordEvent(){
        if(_amountComplete == _target){
        Console.WriteLine("Goal already complete!");
        SetPoints(0);
        }
        else{
        _amountComplete += 1;
        if(_amountComplete == _target){
        SetPoints(_bonus);
        Console.WriteLine($"Congadualtions you earned {GetPoints()}!");
        IsComplete();}
        
            

        }
    }
    public override  void RecordMissedEvent(){
        if(_amountComplete == _target){
        Console.WriteLine("Goal already complete!");
        SetPoints(0);
        }
        else{
        int pointsLoose = GetPointsLoose();
        SubctractPoints(pointsLoose);}

    
}

    // public bool SendComplete(){
    //     if(_amountComplete == _target){
    //         return true;
    //     }
    //     else{
    //         return false;
    //     }
    // }
    public override  bool  IsComplete(){
        return true;
    }



    public override  string  GetDetailsString(){
        string name = GetName();
        string description = GetDescription();
        string goalString;
        if(_target == _amountComplete){
            goalString = $"[X] Checklist Goal: {name} ({description}) -- Currently complited: {_amountComplete}/{_target}";
        }
        else{
            goalString = $"[ ] Checklist Goal: {name} ({description}) -- Currently complited: {_amountComplete}/{_target}";
        }

        return goalString;

    }
    public override  string GetStringRepresentation(){
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();

        string goalStringRepresentation = $"ChecklistGoal: {name}, {description}, {points},{_pointsLoose}, {_bonus}, {_target}, {_amountComplete}";
        return goalStringRepresentation;
    }


}