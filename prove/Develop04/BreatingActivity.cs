public class BreathingActivity : Activity{


public BreathingActivity(string title, string description) : base (title, description){

}

public void CoreActivity(int time){
    DateTime startActivityTime = DateTime.Now;
    DateTime endActivityTime = startActivityTime.AddSeconds(time);
    //int numberOfbreath = time/10;

    while (DateTime.Now < endActivityTime){
        int numberOfbreath = time/10;
        //Console.WriteLine(numberOfbreath);
        for(int i = 0; i < numberOfbreath; i++){
            Console.Write("\nBreath in...");
            NumbersCount(4);
            Console.Write("\nBreath out...");
            NumbersCount(6);
        }
    }
}

}