using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Word;

namespace Word.Tests 
{
   [TestClass]
   public class NumberOfWords {
    
    [TestMethod]
    public void CountingWords_noOfWords_Int() {
     
    
     RepeatWord newWord = new RepeatWord("hello");
     int output = newWord.RepeatCounterFunction();
     Assert.AreEqual(output, 0);

    }

    [TestMethod]
    public void CountingWordsOne_noOfWords_String() {
     
     string input = "hello";
     RepeatWord newWord = new RepeatWord();
     string output = newWord.FindWordAndSetIt();
     Assert.AreEqual(output, input);

    }

        [TestMethod]
    public void InputtedSentence_SenetenceForSearch_String() {
     
     string input = "hello World";
     
     newWord.SearchingForSentence(input);
     string stringOutput = 
     Assert.AreEqual(output, input);




   }


   }

}


