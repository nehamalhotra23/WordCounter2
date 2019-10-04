using System;

namespace Word {

    public class RepeatWord {
        public int CountWord;
        public string InputWord;
        public string Sentence;
         
         //initially value of no. of words is 0
        public RepeatWord() 
        {
           CountWord = 0;

        } 
         //returning value of no. Word 
         public int RepeatCounterFunction() 
         {
             return CountWord;
         }  

        // Inputted user's word
        public void GetWordInput(string inputWord) 

        {
            InputWord = inputWord;
        }
        //setting value of user's word
         public string FindWordAndSetIt() {
             return InputWord;
         }
         
        // inputted user's sentence 
         public void SearchingForSentence(string inputSentence)
         {
               Sentence = inputSentence;
         }
        
        // returning value of user's sentence
         public string GetUserSentence() 
         {
             return Sentence;
         }
            
        // public int CountRepetedWord() 
        // {
        //    foreach(string Inputtedword in SentenceSearch) 
        //    {
        //        if(InputtedWord == SentenceSearch) 
        //        {

        //        }
        //    }
        // }

    }
}