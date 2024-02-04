public class ReflectingActivity : Activity{

    List<String> _reflectingPromptList = new List<string>();
    List<String> _reflectingQuestionList = new List<string>();

     List<String> _reflectingQuestionListGhosen = new List<string>();

    public ReflectingActivity(string title, string description, List<String> promptList, List<String> questionList) : base (title, description){
        _reflectingPromptList = promptList;
        _reflectingQuestionList = questionList;
    }

    public void DisplayPrompt(){
       
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, _reflectingPromptList.Count);
        Console.WriteLine($"--- {_reflectingPromptList[randomIndex]} ---");
        

    }

    public void DisplayQuestion(int time){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
      

        while(DateTime.Now < endTime){   
            int rigthIndex = RightIndex();
        
            Console.Write($"\n> {_reflectingQuestionList[rigthIndex]}");
           // NumbersCount(5);
            //Thread.Sleep(4000);
            AnimationCount(5);
            _reflectingQuestionListGhosen.Add(_reflectingQuestionList[rigthIndex]);
        //     Random randomGenerator = new Random();
        //     int randomIndex = randomGenerator.Next(0, _reflectingQuestionList.Count); 
        
        //     Console.Write($"\n> {_reflectingQuestionList[randomIndex]}");
        //    // NumbersCount(5);
        //     //Thread.Sleep(4000);
        //     AnimationCount(5);
        //     _reflectingQuestionListGhosen.Add(_reflectingQuestionList[randomIndex]);

            
            
            
           
            //Console.Write('I');
        }
    }

     public int  RightIndex(){
            Random randomGenerator = new Random();
            int randomIndex = randomGenerator.Next(0, _reflectingQuestionList.Count); 
           // Console.WriteLine(_reflectingQuestionListGhosen.Contains(_reflectingQuestionList[randomIndex]));
            while(_reflectingQuestionListGhosen.Contains(_reflectingQuestionList[randomIndex]) != false)
            {
                randomIndex = randomGenerator.Next(0, _reflectingQuestionList.Count); 
            }
           

            return   randomIndex;
            
     }

    public void CoreActivity(int time){
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind please press enter to continue");
        String readyPress = Console.ReadLine();
        if (readyPress == ""){
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
            Console.Write("You may begin in: ");
            NumbersCount(5);
        
            // DateTime startActivityTime = DateTime.Now;
            // DateTime endActivityTime = startActivityTime.AddSeconds(time);
            
            // while(DateTime.Now < endActivityTime){
                Console.Clear();
            //     Console.WriteLine(DateTime.Now);
            //     Console.WriteLine(endActivityTime);
                DisplayQuestion(time);

            //}
        }
    }
}