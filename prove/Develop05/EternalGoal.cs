public class EternalGoal:Goal{

    public EternalGoal(string name, string description,int points, int pointsLoose = 0):base(name, description, points , pointsLoose){

}

    public override  void  RecordEvent(){

    }
    public override  void RecordMissedEvent(){
    

    }

    public override  bool  IsComplete(){
        
        return false;
    }

    public override  string  GetStringRepresentation(){
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        string goalStringRepresentation = $"EternalGoal: {name}, {description}, {points}";
        return goalStringRepresentation;
    }

    public override  string  GetDetailsString(){
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        string goalString = $"[ ] Eternal: {name} ({description}) ";
        return goalString;
    }
}
