using System;

namespace Word {

    public class RepeatWord {
        private int _CountWord;
        public string InputtedWord;
        public string SentenceSearch;

       
        public RepeatWord() 
        {
           _CountWord = 0;

        } 

         public int RepeatCounterFunction() 
         {
             return _CountWord;
         }  


        public void GetWordInput(string inputtedWord) 

        {
            InputtedWord = inputtedWord;
        }
         public string FindWordAndSetIt() {
             return InputtedWord;
         }

         public void SearchingForSentence(string inputtedSentence)
         {
               SentenceSearch = InputtedSentence;
         }

         public string GetUserSentence() 
         {
             return SentenceSearch;
         }
            
        

         



    }
}