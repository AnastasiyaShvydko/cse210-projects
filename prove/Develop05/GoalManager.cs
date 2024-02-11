public class GoalMahager{
    List<Goal> _goals = new List<Goal>();
    int _score = 0;

    string _notification = "";


    public void Start(){
      
         string answer = "";
         while(answer!= "6" ){
            DisplayPlayerInfo();
            DisplayNotification();
            List<String> menuOption = new List<string>();
            menuOption.Add("Create New Goal");
            menuOption.Add("List Goals");
            menuOption.Add("Save Goals");
            menuOption.Add("Load Goals");
            menuOption.Add("Record Event");
            menuOption.Add("Quit");
            Console.WriteLine("Menu Options:");
            foreach(string i in menuOption){
                Console.WriteLine($"  {menuOption.IndexOf(i)+1}. {i}");
            }
            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();
            if(answer == "1"){
                CreateGoal();
            }
            else if(answer == "2"){
                ListGoal();
            }
            else if(answer == "3"){
                SaveGoals();
            }
            else if(answer == "4"){
                LoadGoals();
            }
            else if(answer == "5"){
                RecordEvent();
            }
            else if(answer == "6"){
                Console.WriteLine("Good bye!");
            }
         }

    }

    public void DisplayPlayerInfo(){
        Console.WriteLine($"\nYou have {_score} points\n");
    }
    public void DisplayNotification(){
        if(_notification == ""){
            Console.WriteLine("\nYou don't have notifications\n");
        }
        else{
        Console.WriteLine($"\nDon't forget: {_notification}");}
    }


    public void CreateGoal(){
        List<String> goalOption = new List<string>();
        goalOption.Add("Simple Goal");
        goalOption.Add("Eternal Goal");
        goalOption.Add("Checklist Goal");
        goalOption.Add("Goal with notification");

        Console.WriteLine("\nThe type of Goals are:");
        foreach(string i in goalOption){
            Console.WriteLine($"  {goalOption.IndexOf(i)+1}. {i}");
        }
        string goalType = Console.ReadLine();
        if(goalType == "1"){
            string name = GetName();
            string description = GetDescription();
            int points = GetPoints();
            int pointsLoose = GetLoosePoints();
            bool isComplete = false;
            SimpleGoal newSimpleGoal = new SimpleGoal(name,description,points,pointsLoose,isComplete);
            _goals.Add(newSimpleGoal);
            

        }
        if(goalType == "2"){
            string name = GetName();
            string description = GetDescription();
            int points = GetPoints();
           // int pointsLoose = GetLoosePoints();
            EternalGoal newEternalGoal = new EternalGoal(name,description,points);
            _goals.Add(newEternalGoal);


        }
        if(goalType == "3"){
            string name = GetName();
            string description = GetDescription();
            int points = GetPoints();
            int pointsLoose = GetLoosePoints();
            int target = GetTarget();
            int bonus = GetBonus();
            ChecklistGoal newChecklistGoal = new ChecklistGoal(name,description,points,pointsLoose, bonus,target);
            _goals.Add(newChecklistGoal);

        }
        if(goalType == "4"){
            string name = GetName();
            string description = GetDescription();
            int points = GetPoints();
            int days = GetDays();
            int pointsLoose = GetLoosePoints();
            int bonus = GetBonus();

            _notification = $"{name} {days} ";

            GoalWithNotification newNotifyGoal = new GoalWithNotification(name,description,points,pointsLoose,bonus,days);
            _goals.Add(newNotifyGoal);
            

        }



    }

    public void ListGoal(){
        foreach(Goal g in _goals){
            Console.WriteLine($"{_goals.IndexOf(g)+1}. {g.GetDetailsString()}");
        }
    }

    public void ListGoalsName(){
          foreach(Goal g in _goals){
            Console.WriteLine($"{_goals.IndexOf(g)+1}. {g.GetName()}");
        }
    }

    public void SaveGoals(){
        Console.Write("What is a filename for the goals file?");
        string fileName = Console.ReadLine();

        string firstPart = $"{_score}\n";
        
        foreach(Goal g in _goals){
            firstPart = $"{firstPart}{g.GetStringRepresentation()}\n";
           
        }
            using (StreamWriter outputFile = new StreamWriter(fileName)){
            outputFile.WriteLine(firstPart);
            outputFile.Flush();

        }

    }

    public void LoadGoals(){
        Console.Write("What is a filename for the goals file?");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines){
                if(line.Length < 10 ){
                    _score = Convert.ToInt32(line);
                }
                else{
                    string[] parts = line.Split(":");

                    string goalType = parts[0];
                    string goalDetails = parts[1];
                    if(goalType == "SimpleGoal"){
                        string[] goalParts = goalDetails.Split(",");
                        string name = goalParts[0];
                        string description = goalParts[1];
                        int points = Convert.ToInt32(goalParts[2]);
                        int pointsLoose = Convert.ToInt32(goalParts[3]);
                        bool isComplete = Convert.ToBoolean(goalParts[4]);
                        SimpleGoal newSimpleGoal = new SimpleGoal(name,description,points, pointsLoose,isComplete);
                        _goals.Add(newSimpleGoal);
                    }
                    if(goalType == "EternalGoal"){
                        string[] goalParts = goalDetails.Split(",");
                        string name = goalParts[0];
                        string description = goalParts[1];
                        int points = Convert.ToInt32(goalParts[2]);
                        EternalGoal newEternalGoal = new EternalGoal(name,description,points);
                        _goals.Add(newEternalGoal);

                    }
                    if(goalType == "ChecklistGoal"){
                        string[] goalParts = goalDetails.Split(",");
                        string name = goalParts[0];
                        string description = goalParts[1];
                        int points = Convert.ToInt32(goalParts[2]);
                        int pointsLoose = Convert.ToInt32(goalParts[3]);
                        int bonus = Convert.ToInt32(goalParts[4]);
                        int target = Convert.ToInt32(goalParts[5]);
                        int amountComplete = Convert.ToInt32(goalParts[6]);
                    
                        ChecklistGoal newChecklostGoal = new ChecklistGoal(name,description,points, pointsLoose, bonus,target,amountComplete);
                        _goals.Add(newChecklostGoal);
                
                    }
                    if(goalType == "GoalWithNotification"){
                    //string goalDetails = parts[1];
                        string[] goalParts = goalDetails.Split(",");
                        string name = goalParts[0];
                        string description = goalParts[1];
                        int points = Convert.ToInt32(goalParts[2]);
                        int bonus = Convert.ToInt32(goalParts[3]);
                        int pointsLoose = Convert.ToInt32(goalParts[4]);
                        int days = Convert.ToInt32(goalParts[5]);
                        int daysComlete = Convert.ToInt32(goalParts[6]);
                        int daysMissed= Convert.ToInt32(goalParts[7]);
                        _notification += $"\n{name}{description}";
                   
                        GoalWithNotification newGoalWithNotification = new GoalWithNotification(name,description,points,bonus, pointsLoose, days, daysComlete, daysMissed);
                        _goals.Add(newGoalWithNotification);
                
                    }
                }
            }

        }
    public void RecordEvent(){

        Console.WriteLine("Did you accoplish goal or miss it?");
        Console.WriteLine("1. Missed");
        Console.WriteLine("2. Accoplished");
        string answer = Console.ReadLine();
        if(answer == "1"){
            Console.WriteLine("Which goal did you miss?");
            ListGoalsName();
            string missedGoalNumber = Console.ReadLine();
            int missedNumber = Convert.ToInt32(missedGoalNumber);
            foreach(Goal j in _goals){
                if(_goals.IndexOf(j) + 1  == missedNumber ){
                    //Console.WriteLine(_goals.IndexOf(j));
                    j.RecordMissedEvent();
                    //_score -= Convert.ToInt32(j.GetPointsLoose());
                }
            }
        }  
        if(answer == "2"){
         
            Console.WriteLine("Which goal did you accomplish?");
            ListGoalsName();
            string eventNumber = Console.ReadLine();
            int number = Convert.ToInt32(eventNumber);
            foreach(Goal g in _goals){
                if(_goals.IndexOf(g) + 1  == number ){
                    g.RecordEvent();
                    _score += Convert.ToInt32(g.GetPoints());
                    //Console.WriteLine(g.GetType());
                    //Console.WriteLine($"Congadualtions you earned {g.GetPoints()}!");
                    //Console.WriteLine($"Now you have {_score} points !");
                    //Type type = g.GetType();
                
                    

                }
            }

        }
    }




    public string GetName(){
        Console.Write("What is a name of your goal?");
        string name = Console.ReadLine();
        return name;
    }
     public string GetDescription(){
        Console.Write("What is a short description for it?");
        string description = Console.ReadLine();
        return description;
    }
     public int GetPoints(){
        Console.Write("What is the amount of poins associated with this goal?");
        int points = Convert.ToInt32(Console.ReadLine());
        return points;
    }
       public int GetTarget(){
        Console.Write("How many times does this goal need to be accopmplish to get bonus?");
        string target = Console.ReadLine();
        return Convert.ToInt32(target);
    }
       public int GetBonus(){
        Console.Write("What is the bonus for accomplishing it that many times?");
        string bonus = Console.ReadLine();
        return Convert.ToInt32(bonus);
    }
        public int GetDays(){
        Console.Write("How many days you want to work on this goal?");
        string bonus = Console.ReadLine();
        return Convert.ToInt32(bonus);
    }

        public int GetLoosePoints(){
        Console.Write("How many points you will loose if you was not diligent enough?");
        string bonus = Console.ReadLine();
        return Convert.ToInt32(bonus);

    }




}