using System;

namespace Word {

    public class RepeatWord {
        private int _CountWord;
        public string InputtedWord;
        public string SentenceSearch;

       
        public void RepeatWordChecker() 
        {
           InputtedWord = inputtedWord;

        }  

         public string FindWordAndSetIt() {
             return InputtedWord;
         }
        public void CountingWord() 
        {
            _CountWord = 0;
        }
         public int RepeatCounterFunction() 
         {
             return _CountWord;
         } 
       

         public void SearchingForSentence(string inputtedSentence)
         {
               SentenceSearch = inputtedSentence;
         }

         public string GetUserSentence() 
         {
             return SentenceSearch;
         }
            
        

         



    }
}