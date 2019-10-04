using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Word;

namespace Word.Tests 
{
   [TestClass]
   public class NumberOfWords {
    

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
        string word = "hello";
        string sentence = "hello hello hello World";
        RepeatWord newWord = new RepeatWord();
         newWord.GetWordInput(word);
        newWord.SearchingForSentence(sentence);
        newWord.GetUserSentence();

        int result = newWord.CountRepetedWord();
        Assert.AreEqual(result, 3);


    }
      [TestMethod]
    public void CountNoRepeatedWord_DecreaseCount_Int() 
    {
        string word = "hello";
        string sentence = "World is beautiful";
        RepeatWord newWord = new RepeatWord();
         newWord.GetWordInput(word);
        newWord.SearchingForSentence(sentence);
        newWord.GetUserSentence();

        int result = newWord.CountRepetedWord();
        Assert.AreEqual(result, 0);


    }



}

}




