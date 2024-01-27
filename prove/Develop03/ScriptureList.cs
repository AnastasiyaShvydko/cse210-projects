using System;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Json;

namespace NewDev03
{
	public class ScriptureList
	{
       public string Book { get; set; }
       public string Chapter { get; set; }
       public string Verse { get; set; }
       public string EndVerse { get; set; }
       public string Text { get; set; }
       
        

        public List <ScriptureList> _scriptureList = new List<ScriptureList>{};


        public int RandomIndex()
		{
            Random randomGenerator = new Random();
            int randomIndex = randomGenerator.Next(0, _scriptureList.Count);
			return randomIndex;
        }

        public void SetScripture()
        {
            int index = RandomIndex();
            Book = _scriptureList[index].Book;
            Chapter = _scriptureList[index].Chapter;
            Verse = _scriptureList[index].Verse;
            Text = _scriptureList[index].Text;
            EndVerse = _scriptureList[index].EndVerse;


        }

        public string GetBook()
        {
            return Book;
        }

        public string GetChapter()
        {
            return Chapter;
        }
        public string GetVerse()
        {
            return Verse;
        }
        public string GetText()
        {
            return Text;
        }
        public string GetEndVerse()
        {
            return EndVerse;
        }

    }
}

