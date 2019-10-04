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
    public void CountingWordsOne_noOfWords_String() {
     
     string input = "hello World";
     RepeatWord newWord = new RepeatWord();
     newWord.GetWordInput(input);
     string output = newWord.FindWordAndSetIt();
     Assert.AreEqual(output, input);

    }

        [TestMethod]
    public void InputtedSentence_SenetenceForSearch_String() {
     
     string input = "hello World";
     RepeatWord newWord = new RepeatWord();
     newWord.SearchingForSentence(input);
     string output = newWord.GetUserSentence();
     Assert.AreEqual(output, input);

    }


   }


   }




