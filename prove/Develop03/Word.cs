using System;
using System.Reflection.Metadata;
namespace NewDev03
{


    public class Word
    {
        String _text;

        Boolean _isHidden = false;

        public Word(String text)
        {
            _text = text;
        }

        public void Hide()
        {
            String newString = "";
            for (int j = 0; j < _text.Length; j++)
            {
                newString = newString + "_";
            }


            _text = newString;
            _isHidden = true;
            //Console.WriteLine(_text);

        }

        public void Show()
        {
            Console.WriteLine($"{_text} ");

        }

        public Boolean IsHidden()
        {

            return _isHidden;

        }

        public String GetDisplayText()
        {

            return _text;

        }


    }
}


