using System.Text.Json;
public class File{
        public string _fileName = "";


        public string _fileNameToRead = "";


        public string _docPath = "";

        public List<Entry> _notesList = new List<Entry>{};
       string _json;

        public void SaveFile(){
            //append:true will add lines in the end of the file 
            //using (StreamWriter outputFile = new StreamWriter(Path.Combine(_docPath, _fileName),append:true))
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(_docPath, _fileName)))
                        {
                            Console.WriteLine(Path.Combine(_docPath, _fileName));
                            _json = JsonSerializer.Serialize(_notesList);
                            outputFile.WriteLine(_json);
                            //outputFile.Flush();
                        }
                }

        public void ReadFile(){
    
               
                using (StreamReader outputFile = new StreamReader(Path.Combine(_docPath, _fileNameToRead))){
                        
                        // Read the stream as a string, and write the string to the console.
                        //Console.WriteLine(outputFile.ReadToEnd());
                        
                      string text = outputFile.ReadToEnd();
                      _notesList = JsonSerializer.Deserialize<List<Entry>>(text);
                    
                    }
        }
}