public class Entry
{
    public string CurrentPropmt { get; set; }
    public string Date { get; set; }
    public string Note { get; set; }

    public List<Entry> _notesList = new List<Entry>{};

    public void DisplayNotes()
        {
            Console.WriteLine(_notesList.Count);
            foreach(Entry note in _notesList){
            Console.WriteLine($"Date: {note.Date} Prompt: {note.CurrentPropmt} {note.Note}");
            }

        }

         
}