using System;
using System.Diagnostics;

public class MusicActivity : Activity{

    public string _audioFilePath = "/Users/nastia_shvydko/Downloads/the_morning_breaks_accompaniment_eng.mp3";
    public MusicActivity(string title, string description) : base (title, description){

}

public void CoreActivity(int time){
    Process process = new Process();

        process.StartInfo.FileName = "afplay"; 
        process.StartInfo.Arguments = "\"" + _audioFilePath + "\""; 

       
        // Start the process
        process.Start();
        DateTime startActivityTime = process.StartTime;
        DateTime endActivityTime = startActivityTime.AddSeconds(time);

        // Wait for the process to exit
        Thread.Sleep(time*1000);
      
         

            if (DateTime.Now == endActivityTime)
            {
            process.WaitForExit();
            Console.WriteLine(DateTime.Now);
            process.Kill();
        }
    }

}

