using MySql.Data.MySqlClient;
public class DB{
    public string _connectionString = "";

    public List<Entry> _notesList = new List<Entry>{};

    public void WriteDB(){
            //creating connection using connection string with all data we need to connect our database
                    MySqlConnection connection = new MySqlConnection(_connectionString);
            //SQL Query with table name, names of columns
            // need to open and close connection 
            //insertCommand.ExecuteNonQuery() - execute Command
                    foreach(Entry note in _notesList){
                    string insertSql = "INSERT INTO journal (date,prompt, note) VALUES (@value1, @value2, @value3 )";
                    MySqlCommand insertCommand = new MySqlCommand(insertSql, connection);
                    insertCommand.Parameters.AddWithValue("@value1", note.Date);
                    insertCommand.Parameters.AddWithValue("@value2", note.CurrentPropmt);
                    insertCommand.Parameters.AddWithValue("@value3", note.Note); 
                    connection.Open();
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    connection.Close();}
    }
    
    public void ReadDB(){
            MySqlConnection connection = new MySqlConnection(_connectionString);
            string readSql = "SELECT * FROM journal";
            MySqlCommand readCommand = new MySqlCommand(readSql, connection);
            connection.Open();
            MySqlDataReader myReader = readCommand.ExecuteReader();
            //int rowsAffected = readCommand.ExecuteNonQuery();
            while(myReader.Read()){
            string date = myReader["date"].ToString();
            string note = myReader["note"].ToString();
            string prompt = myReader["prompt"].ToString();
            //Console.WriteLine($"{date} {note} {prompt}");
            var noteFromDB = new Entry { 
                        CurrentPropmt = myReader["prompt"].ToString(),
                        Date =  myReader["date"].ToString() ,
                        Note = myReader["note"].ToString()
                };
           _notesList.Add(noteFromDB);
           
            }
            connection.Close();
    }
}