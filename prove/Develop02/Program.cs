using System;
using System.Runtime.CompilerServices;
using System.Transactions;
using MySql.Data.MySqlClient;
using System.Text.Json;
using Org.BouncyCastle.Tls.Crypto.Impl.BC;

class Program
{
    static void Main(string[] args)
        {   

        //Creating Options class instance;
        Options options = new Options();
       // There are two ways to add elements to the _optionsList
       // List<string> optionList = new List<string>(){ "Write", "Display", "Load", "Save", "Quit" }; or
        options._optionsList.Add("Write");
        options._optionsList.Add("Display");
        options._optionsList.Add("Load");
        options._optionsList.Add("Save");
        options._optionsList.Add("Quit");
       



        
        File file = new File();
        Journal journal = new Journal();

        
        String docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        String connectionString = "Server=localhost;Port=3306;Database=cs210;User=root;Password=12345678;";
        
     

        Console.WriteLine("Welcome to the Journal Program!");
        string answer = "";
       // string prompt;

         while (answer != "5"){
            Console.WriteLine("Please select one of the following choices:");
            options.DisplayOptions();
            Console.WriteLine("What would you like to do?");
            answer = Console.ReadLine();
            if(answer == "1"){
                journal.WriteJournal();
            }
            else if(answer == "2"){
                journal.DisplayJournal();
            }
             else if(answer == "3"){
                journal.LoadJournal(connectionString,docPath);
            }
             else if(answer == "4"){
                journal.SaveJournal(connectionString,docPath);
            }
             else if(answer == "5"){
                Console.WriteLine("Good Bye!");
            }
       
        }
}
}