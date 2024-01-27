using System;
using System.Text.Json;
namespace NewDev03
{
    public class FileConnect
    {
        public string _fileName = "";
        public string _docPath = "";

        public List<ScriptureList> _userList = new List<ScriptureList>{};


       public FileConnect(String userFileName,String userDocPath)
        {
            _fileName = userFileName;
            _docPath = userDocPath;
                
        }

        public void ReadFile()
        {

            using (StreamReader outputFile = new StreamReader(Path.Combine(_docPath, _fileName)))
            {

                // Read the stream as a string, and write the string to the console

                string text = outputFile.ReadToEnd();
               
                _userList = JsonSerializer.Deserialize<List<ScriptureList>>(text);
               

            }
        }
    }
}

