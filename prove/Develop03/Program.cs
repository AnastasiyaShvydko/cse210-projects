
using System;
using System.ComponentModel;
using Microsoft.VisualBasic;
using NewDev03;

class Program
{
    static void Main(string[] args)

    {
        //Ask user how many verses he would like to learn if one scripture verse will be loaded from
        //one file if more verses will be loaded from another file.bbhbjbjnj
        Console.WriteLine("Do you want to learn one verse or more(one/more)?");
        String numbeOfVerses = Console.ReadLine();
        String docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        ScriptureList myList = new ScriptureList();
        FileConnect userFile;
        String userFileName;
        Reference myRef;
        if (numbeOfVerses == "one")
        {
            userFileName = "scripture.txt";    
        }
        else
        {
            userFileName = "scripture2.txt";
            
        }


        //Using FileConnect class we get document
         userFile = new FileConnect(userFileName, docPath);
        // read file and Deserialize its data to the scripture list 
        userFile.ReadFile();
         myList._scriptureList = userFile._userList;
        //Randomly choose element of the list 
         myList.SetScripture();
        //if it is multiple verses we call Reference constractor and pass there parameters and EndVerse parameter vggvvf
        if (numbeOfVerses == "one")
        {
            myRef = new Reference(myList.GetBook(), Convert.ToInt32(myList.GetChapter()), Convert.ToInt32(myList.GetVerse()));
        }
        else
        {
            myRef = new Reference(myList.GetBook(), Convert.ToInt32(myList.GetChapter()), Convert.ToInt32(myList.GetVerse()), Convert.ToInt32(myList.GetEndVerse()));
        }


        //In Scripture constarctor we pass reference  and text
        Scripture myScript = new Scripture(myRef, myList.GetText());
        Console.Clear();
        myScript.Show();
        //Ask user if he/she wants to choose the level . Level light will hide just one word int he verse
        //medium - 3, hard -  5 
        Console.WriteLine("\nPlease choose the level(light/medium/hard)");
        string level = Console.ReadLine();
        String answer = "yes";

        if (level == "light")

        {
            Console.Clear();
            myScript.Show();
            while (myScript.IsCompletlyHidden() != true && answer != "quit")
            {
                Console.WriteLine("\nPress Enter to continue or quit...");
                answer = Console.ReadLine();
                if (answer == "quit")
                { 
                    Console.WriteLine("Good Job");
                }
                else
                {
                    Console.Clear();
                    if (level == "light")
                    {
                       
                        myScript.HideRandomWord(1);
                        
                    }
                    else if(level == "medium")
                    {
                        myScript.HideRandomWord(3);
                    }
                    else if (level == "hard")
                    {
                        myScript.HideRandomWord(5);
                    }
                    myScript.Show();





                }
            }
        }
        
    }
}

