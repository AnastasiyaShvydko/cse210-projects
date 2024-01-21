using System.Configuration;
using System.Text.Json;
public class Journal{

        Prompts prompts = new Prompts();
      

        Entry notes = new Entry();
        File  file = new File();
        public  DB db = new DB();

         public void WriteJournal()
        {
    
                prompts._promptsList.Add("Who was the most interesting person I interacted with today?");
                prompts._promptsList.Add("What was the best part of my day?");
                prompts._promptsList.Add("How did I see the hand of the Lord in my life today?");
                prompts._promptsList.Add("What was the strongest emotion I felt today?");
                prompts._promptsList.Add("If I had one thing I could do over today, what would it be?");
                var newPrompt = prompts.DisplayPrompts();
                Console.WriteLine(newPrompt);
                string note = Console.ReadLine();
                DateTime date = DateTime.Now;
                var today = date.ToString("yyyy-MM-dd");
                var mynote = new Entry { 
                        CurrentPropmt = newPrompt,
                        Date =  today,
                        Note = note
                };
                //string jsonString = JsonSerializer.Serialize(mynote);

                //Console.WriteLine(jsonString);
                notes._notesList.Add(mynote); 
}
            public void DisplayJournal(){
                notes.DisplayNotes();
            
                
            }
            public void LoadJournal(String connectString, String docPath){
                Console.WriteLine("Do you want to read from a file or a Database? (File/Database)");
                string readOption = (Console.ReadLine()).ToLower();
                if(readOption == "file"){
                    Console.WriteLine("What is a file name?");
                    file._fileNameToRead = Console.ReadLine();
                    file._docPath = docPath;
                    file.ReadFile();
                    notes._notesList = file._notesList;
                    
                    //Console.WriteLine(file._journal);
                }
                else{
                    db._connectionString = connectString;
                    db.ReadDB();
                    notes._notesList = db._notesList;
                    }
                

            }
           public void SaveJournal(String connectString, String docPath){ 
                Console.WriteLine("Do you want to save to a file or a Database? (File/Database)");
                string saveOption = (Console.ReadLine()).ToLower();
                if(saveOption == "file"){
                    Console.WriteLine("What is a file name?");
                    file._fileName = Console.ReadLine();
                    file._docPath = docPath;
                    file._notesList = notes._notesList;
                    
                // Write the string array to a new file named .
                    file.SaveFile();
                    notes._notesList.Clear();
                    
                }
                else{
                    db._connectionString = connectString;
                    db._notesList = notes._notesList;
                    db.WriteDB();
                }
               
            
                }
            
         
    }  
        

        
