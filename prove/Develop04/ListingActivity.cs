public class ListingActivity : Activity{

    List<String> _listingQuestionList = new List<string>();
    List<string >_listAnsewrs = new List<string>();
    public ListingActivity(string title, string description, List<string> list) : base (title, description){
        _listingQuestionList = list;
    }

    public void DisplayQuestion(){
       
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(0, _listingQuestionList.Count);
        Console.WriteLine($"--- {_listingQuestionList[randomIndex]} ---");
        

    }
     public void Listing(int time){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
      

        while(DateTime.Now < endTime){   
            Console.Write("\n< ");
            String readyPress = Console.ReadLine();
            _listAnsewrs.Add(readyPress);

            // if (readyPress){
            // //Console.WriteLine("< ");
            //     Count++;
            // }


        }
     }




    public void CoreActivity(int time){
        Console.WriteLine("List as many responses as you can to the following prompt:");
        DisplayQuestion();
        Console.Write("You may begin in: ");
        NumbersCount(5);
        //Console.Clear();
        Listing(time);
        Console.Write($"You entered {_listAnsewrs.Count} thoutghts ");

        

    }   


}