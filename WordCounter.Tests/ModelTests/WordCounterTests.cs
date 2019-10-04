using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Word;

namespace Word.Tests 
{
   [TestClass]
   public class NumberOfWords {
    
    [TestMethod]
    public void CountingWords_noOfWords_Int() {
     
     RepeatWord newWord = new RepeatWord();
     int output = newWord.RepeatCounterFunction();
     Assert.AreEqual(output, 0);

    }

    [TestMethod]
    public void MatchingWords_Words_String() {
     
     string input = "hello World";
     RepeatWord newWord = new RepeatWord();
     newWord.GetWordInput(input);
     string output = newWord.FindWordAndSetIt();
     Assert.AreEqual(output, input);

    }

        [TestMethod]
    public void InputtedSentence_Senetence_String() {
     
     string input = "hello World";
     RepeatWord newWord = new RepeatWord();
     newWord.SearchingForSentence(input);
     string output = newWord.GetUserSentence();
      Assert.AreEqual(output, input);

    }

    [TestMethod]

    public void CountRepeatedWord_IncreaseCount_Int() 
    {
        string word = "Hello";
        string sentence = "Hello hello World";
        RepeatWord newWord = new RepeatWord();
        newWord.GetWordInput(word);
        newWord.SearchingForSentence(sentence);
        newWord.GetUserSentence();

        int result = newWord.CountRepetedWord();
        Assert.AreEqual(result, 2);


    }


}

}




