public class WritingAssignment : Assignment{
    string _title = "";
    

 
public WritingAssignment(string studentName, string topic,string title) : base ( studentName,topic )
{
_title = title;
}


public string GetWritingInfromation(){
    return _title;
}



    }