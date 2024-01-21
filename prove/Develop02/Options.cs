public class Options{
    public List<string> _optionsList = new List<string>();

     public void DisplayOptions(){
         foreach(string i in _optionsList){
            Console.WriteLine($"{_optionsList.IndexOf(i)+1}. {i}" );
        }
     }
}