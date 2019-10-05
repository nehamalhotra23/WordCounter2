using System;
using Word;
using System.Text.RegularExpressions;
public class Program
{
    static void Main()
    {
        Console.WriteLine("Type a Word. eg: 'Hello' ");
        string inputWord = Console.ReadLine();
        Console.WriteLine("Type a Sentence eg: 'Hello World' ");
        string inputSentence = Console.ReadLine();
        RepeatWord newWord = new RepeatWord(inputWord, inputSentence);
        Regex regex = new Regex(@"^[0-9]+$");
        Match wordMatch = regex.Match(inputWord);
        Match sentenceMatch = regex.Match(inputSentence);
        int repeats = newWord.CountRepetedWord(); 
       
        if (wordMatch.Success || sentenceMatch.Success){
         Console.WriteLine("Invalid Input. Please type a Word or Sentence");
         Main();
        } else if (inputWord.Contains(" ")) {
          Console.WriteLine("You can only search for One Word");
          Main();
        } else {
          Console.WriteLine("Number of match availabe " + repeats);
        }
    }
}