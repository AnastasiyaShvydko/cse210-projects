using System;
using System.Diagnostics;
using System.Windows;

namespace NewDev03
{
    public class Scripture
    {


        Reference _reference;
        List<Word> _words = new List<Word>();



        public Scripture(Reference refer, String text)
        {
            _reference = refer;
            List<String> myL = text.Split(' ').ToList();
            foreach (String e in myL)
            {
                Word myWord = new Word(e);
                _words.Add(myWord);
            }
        }
        //Display method
        public void Show()
        {

            Console.Write(_reference.GetDisplayText());
            foreach (Word w in _words)
            {
                Console.Write($"{w.GetDisplayText()} ");


            }

        }

        //Get randomIndex of unhidden element and Hide it using method Hide from Word class.
        public void HideRandomWord(int numberToHide)
        {

            for (int i = 1; i <= numberToHide; i++)
            {
                int rightIndex = RightIndex();
                _words[rightIndex].Hide();
            }



        }

        //this method look for first element not hidden itterating throught the list using
       // randomIndex
        public int RightIndex()

        {
            Random randomGenerator = new Random();
            int randomIndex = randomGenerator.Next(0, _words.Count);

            while (_words[randomIndex].IsHidden() != false)
            {
                randomIndex = randomGenerator.Next(0, _words.Count);
            }

            return randomIndex;
        }


        //This method ches if for all elements parameter isHidden = true and number of
        //hidden words equal to the lengh ot list _words.
        public Boolean IsCompletlyHidden()
        {
            int hideWordsCount = 0;
            foreach (Word i in _words)
            {
                if (i.IsHidden() == true)
                {
                    hideWordsCount++;
                }
            }
            if (hideWordsCount == _words.Count())
            {
                return true;
            }
            else
            {
                return false;
            }

        }






    }
}

