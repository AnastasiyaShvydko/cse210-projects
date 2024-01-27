using System;
using System.Threading.Tasks.Dataflow;
namespace NewDev03
{
    

    public class Reference
    {
        String _book;
        int _chapter;
        int _verse;
        int _endVerse;

        public Reference(string userBook, int userChapter, int userVerse)
        {
            _book = userBook;
            _chapter = userChapter;
            _verse = userVerse;
        }

        public Reference(string userBook, int userChapter, int userVerse, int userEndVerse)
        {
            _book = userBook;
            _chapter = userChapter;
            _verse = userVerse;
            _endVerse = userEndVerse;
        }

        public String GetDisplayText(){

            String refString;
            if (_endVerse != 0) {
                refString = $"{_book} {_chapter}:{_verse}-{_endVerse} :";
            }
            else
            {
                refString = $"{_book} {_chapter}:{_verse} :";
            }

           


            return refString;
        }

    }
}

