using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Word;

namespace Word.Tests 
{
   [TestClass]
   public class NumberOfWords {
    
    [TestMethod]
    public void CountingWords_noOfWords_Int() {
     
     string input = "word";
     RepeatWord newWord = new RepeatWord(input);
     int output = newWord.RepeatCounterFunction();
     Assert.AreEqual(output, 1);

    }


   }

}
