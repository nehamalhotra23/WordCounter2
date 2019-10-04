using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Word;

namespace Word.Tests 
{
   [TestClass]
   public class NumberOfWords {
    
    [TestMethod]
    public void CountingWords_noOfWords_Int() {
     
     string input = "hello";
     RepeatWord newWord = new RepeatWord(input);
     int output = newWord.RepeatCounterFunction();
     Assert.AreEqual(output, 0);

    }

    // [TestMethod]
    // public void CountingWordsOne_noOfWords_String() {
     
    //  string input = "hello";
    //  RepeatWord newWord = new RepeatWord(input);
    //  string output = newWord.RepeatWord(input);
    //  Assert.AreEqual(output, input);

    // }





   }

}
