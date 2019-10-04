using System;

namespace Word {

    public class RepeatWord {
        public int CountWord;
        public string InputWord;
        public string Sentence;

        public RepeatWord(string inputWord, string inputSentence)
        {
            InputWord = inputWord;
            Sentence = inputSentence;
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
        
        // setting value of user's sentence
         public string GetUserSentence() 
        {
            return Sentence;
        }
            
        //checking no. of repeated words
        public int CountRepetedWord() 
        {
           string foundWord = InputWord.ToLower();
           string foundSentence = Sentence.ToLower();
           string[] array = foundSentence.Split(" ");
           for (int i = 0; i < array.Length; i++) {
               if (array[i] == foundWord) {
                   CountWord += 1;
                } 
               
        }
           return CountWord;
        }

    }
}