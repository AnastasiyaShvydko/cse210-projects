public abstract class Goal{

string _shortName;

string _description;

int _points;

int _pointsLoose;

public Goal(string name, string description, int points,int pointsLoose ){
    _shortName = name;
    _description = description;
    _points = points;
    _pointsLoose = pointsLoose;
}

public string GetName(){
return _shortName;
}

public string GetDescription(){
return _description;
}

public int GetPoints(){
return _points;
}

public int GetPointsLoose(){
return _pointsLoose;
}

public void SetPoints(int points){
    _points = points;
}
public void SubctractPoints(int points){
    _points -= points;
}
public abstract void RecordEvent();
public abstract void RecordMissedEvent();

public abstract bool IsComplete();

public abstract string GetDetailsString();

public abstract string GetStringRepresentation();

}