using System;

namespace Word {

    public class RepeatWord {
        public int CountWord {get; set;} = 0;
        public string InputtedWord;
        public string SentenceSearch;

       
        public RepeatWord(string inputWord) 
        {
           InputtedWord = inputWord;
        }
        
         public int RepeatCounterFunction() 
         {
             return CountWord;
         } 
        



    }
}