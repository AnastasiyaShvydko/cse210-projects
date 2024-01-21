public class Prompts{
    public List<string> _promptsList = new List<string>();

    public string DisplayPrompts(){
         Random randomGenerator = new Random();
         int randomIndex =  randomGenerator.Next(0, _promptsList.Count);
         string note = _promptsList[randomIndex];
         return note;
     }
}